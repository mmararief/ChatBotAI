Imports MySqlConnector
Imports Newtonsoft.Json.Linq
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Web.UI.WebControls
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class ImageGeneration

    Dim connectionString As String = "server=103.153.3.20;user id=webkadupa_ammar;password=Juken12345678;database=webkadupa_bot"
    Dim connection As New MySqlConnection(connectionString)
    Dim username As String = Globals.loggedInUsername
    Dim apiKey As String = "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"
    Dim apiUrl As String = "https://api.openai.com/v1/images/generations"
    Dim prompt As String
    Dim image As String

    Private Async Sub btnGenerateImage_Click(sender As Object, e As EventArgs) Handles btnGenerateImage.Click

        prompt = txtImage.Text
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

            ' Mendapatkan URL gambar dari respons JSONA
            Dim imageUrl As String = GetImageUrlFromJson(jsonResponse)

            image = imageUrl

            InsertImage(username, image, prompt)

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

    Private Async Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnPnlWa.Click
        Dim connectionString As String = "server=103.153.3.20;user id=webkadupa_ammar;password=Juken12345678;database=webkadupa_bot"
        Dim connection As New MySqlConnection(connectionString)
        Dim username = Globals.loggedInUsername
        Dim sql As String = "SELECT Number FROM users WHERE username = @username"
        Dim command As New MySqlCommand(sql, connection)
        command.Parameters.AddWithValue("@username", username)

        connection.Open()
        Dim reader As MySqlDataReader = command.ExecuteReader()
        reader.Read()
        Dim PhoneNumber = reader("Number").ToString()
        Using client As New HttpClient()
            Using content As New MultipartFormDataContent()
                content.Add(New StringContent(image), "file")
                content.Add(New StringContent(PhoneNumber), "number")
                content.Add(New StringContent(prompt), "caption")

                Try
                    Dim response As HttpResponseMessage = Await client.PostAsync("https://ammar-wa.herokuapp.com/send-media", content)
                    response.EnsureSuccessStatusCode()

                    ' pesan berhasil terkirim
                    MessageBox.Show("Gambar berhasil terkirim ke nomor " & PhoneNumber)
                Catch ex As HttpRequestException
                    ' nomor tidak ditemukan
                    MessageBox.Show("Nomor tidak ditemukan." & image)
                End Try
            End Using
        End Using

        reader.Close()
        connection.Close()
    End Sub

    Private Function InsertImage(username As String, image As String, prompt As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO ImageGen (username, image, prompt) VALUES (@username, @image, @prompt)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@image", image)
            command.Parameters.AddWithValue("@prompt", prompt)
            command.ExecuteNonQuery()

        End Using
    End Function
End Class