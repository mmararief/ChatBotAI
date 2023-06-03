Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text
Imports System.Web.UI.WebControls

Public Class ImageGeneration
    Private Async Sub btnGenerateImage_Click(sender As Object, e As EventArgs) Handles btnGenerateImage.Click
        Dim apiKey As String = "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"
        Dim apiUrl As String = "https://api.openai.com/v1/images/generations"
        Dim prompt As String = txtImage.Text
        Dim numImages As Integer = 1
        Dim imageSize As String = "1024x1024"

        ' Membuat HttpClient
        Dim httpClient As New HttpClient()
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)

        ' Membuat body JSON
        Dim body As String = $"{{""prompt"": ""{prompt}"", ""n"": {numImages}, ""size"": ""{imageSize}""}}"
        Dim content As New StringContent(body, Encoding.UTF8, "application/json")

        Try
            ' Mengirim permintaan HTTP secara asynchronous
            Dim response As HttpResponseMessage = Await httpClient.PostAsync(apiUrl, content)

            ' Menerima dan membaca respons
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()

            ' Mendapatkan URL gambar dari respons JSON
            Dim imageUrl As String = GetImageUrlFromJson(jsonResponse)

            ' Menampilkan gambar di PictureBox
            PictureBox1.Load(imageUrl)
        Catch ex As Exception
            ' Tangani jika terjadi kesalahan saat melakukan permintaan
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Function GetImageUrlFromJson(jsonResponse As String) As String
        ' Mem-parsing respons JSON untuk mendapatkan URL gambar
        Dim imageUrl As String = String.Empty

        Try
            Dim data As JObject = JObject.Parse(jsonResponse)
            Dim imageUrlObject As JToken = data.SelectToken("data[0].url")
            If imageUrlObject IsNot Nothing Then
                imageUrl = imageUrlObject.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to parse JSON response.", "Error")
        End Try

        Return imageUrl
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        If PictureBox1.Image IsNot Nothing Then
            Using saveDialog As New SaveFileDialog()
                saveDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp"
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = saveDialog.FileName
                    PictureBox1.Image.Save(filePath)
                    MessageBox.Show("Image saved successfully.", "Success")
                End If
            End Using
        Else
            MessageBox.Show("No image to save.", "Error")
        End If
    End Sub
End Class