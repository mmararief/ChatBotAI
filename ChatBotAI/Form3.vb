Imports System.Net.Http

Public Class Form3


    Private Async Sub btnWa_Click(sender As Object, e As EventArgs) Handles btnWa.Click
        Dim nomor As String = txtNomer.Text.Trim()
        If nomor.StartsWith("0") Then
            nomor = "62" & nomor.Substring(1)
        End If
        Dim number As String = nomor & "@c.us" ' nomor telepon penerima

        Dim caption = ImageGeneration.prompt
        Dim file = ImageGeneration.image

        Using client As New HttpClient()
            Using content As New MultipartFormDataContent()
                content.Add(New StringContent(file), "file")
                content.Add(New StringContent(number), "number")
                content.Add(New StringContent(caption), "caption")

                Try
                    Dim response As HttpResponseMessage = Await client.PostAsync("https://ammar-wa.herokuapp.com/send-media", content)
                    response.EnsureSuccessStatusCode()

                    ' pesan berhasil terkirim
                    MessageBox.Show("Gambar berhasil terkirim ke nomor " & nomor)
                Catch ex As HttpRequestException
                    ' nomor tidak ditemukan
                    MessageBox.Show("Nomor tidak ditemukan." & ImageGeneration.image)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Hide()
    End Sub
End Class