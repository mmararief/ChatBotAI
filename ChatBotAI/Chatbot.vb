﻿Imports System.Net
Imports System.Net.Http
Imports System.Net.NetworkInformation
Imports System.Text
Imports MySqlConnector
Imports Newtonsoft.Json.Linq
Imports QRCoder
Public Class Chatbot
    Dim id As String
    Dim connectionString As String = "server=localhost;user id=root;password=;database=bot_sidudu"
    Dim connection As New MySqlConnection(connectionString)
    Dim username As String = Globals.loggedInUsername
    Dim IPv4 As String
    Dim urlLink As String
    Private Async Function callOpenAi(sQuestion As String) As Task(Of String)
        Dim apiKey As String = "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"
        Dim apiUrl As String = "https://api.openai.com/v1/chat/completions"
        Dim responseContent As String = ""

        ' Membuat HttpClient
        Dim httpClient As New HttpClient()
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)

        ' Membuat bod JSON
        Dim body As String = $"{{""model"": ""gpt-3.5-turbo"", ""messages"": [{{""role"": ""user"", ""content"": ""{cleanString(sQuestion)}""}}]}}"
        Dim content As New StringContent(body, Encoding.UTF8, "application/json")

        Try
            ' Mengirim permintaan HTTP secara asynchronous
            Dim response As HttpResponseMessage = Await httpClient.PostAsync(apiUrl, content)

            ' Menerima dan membaca respons
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()

            ' Mendapatkan isi konten dari respons JSON
            Dim data As JObject = JObject.Parse(jsonResponse)
            Dim contentObject As JToken = data.SelectToken("choices[0].message.content")
            If contentObject IsNot Nothing Then
                responseContent = contentObject.ToString()
            End If
        Catch ex As Exception
            ' Tangani jika terjadi kesalahan saat melakukan permintaan
            MessageBox.Show(ex.Message, "Error")
        End Try

        Return responseContent
    End Function
    Private Function cleanString(ByVal s As String) As String
        If s.IndexOf("\") <> -1 Then s = Replace(s, "\", "\\")
        If s.IndexOf(vbCrLf) <> -1 Then s = Replace(s, vbCrLf, "\n")
        If s.IndexOf(vbCr) <> -1 Then s = Replace(s, vbCr, "\r")
        If s.IndexOf(vbLf) <> -1 Then s = Replace(s, vbLf, "\f")
        If s.IndexOf(vbTab) <> -1 Then s = Replace(s, vbTab, "\t")
        If s.IndexOf("""") = -1 Then
            Return s
        Else
            Return Replace(s, """", "\""")
        End If
    End Function
    Private Async Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim humanMessage As String = "    Human     : " & txtQuestion.Text

        ' Menambahkan pesan manusia
        txtChat.SelectionFont = New Font(txtChat.Font, FontStyle.Bold)
        txtChat.AppendText(vbCrLf & vbCrLf & humanMessage)

        Dim response As String = Await callOpenAi(txtQuestion.Text)

        ' Menambahkan pesan Dudu dan respons hanya jika respons diterima
        If Not String.IsNullOrEmpty(response) Then
            Dim duduMessage As String = "    Dudu        : "
            Dim formattedResponse As String = response.Replace(vbCrLf, " ")
            ' Menambahkan pesan Dudu
            txtChat.SelectionFont = New Font(txtChat.Font, FontStyle.Regular)
            txtChat.AppendText(vbCrLf & duduMessage & formattedResponse)
            ' Menyimpan chat ke database
            Dim chatMessage As String = humanMessage & vbNewLine & duduMessage & formattedResponse
            InsertChatMessage(username, chatMessage)
        End If

        ' Mengatur scroll ke paling bawah
        txtChat.SelectionStart = txtChat.TextLength
        txtChat.ScrollToCaret()

        txtQuestion.Text = ""
    End Sub

    Private Function InsertChatMessage(username As String, message As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO ChatMessages (Username, Message) VALUES (@Username, @Message)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Message", message)
            command.ExecuteNonQuery()
        End Using
    End Function

    Private Sub txtQuestion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuestion.KeyDown
        If txtQuestion.Text IsNot "" AndAlso e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Mengabaikan suara "beep" saat menekan tombol Enter
            btnSend_Click(Me, EventArgs.Empty)
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        End
    End Sub

    Private Sub txtQuestion_TextChanged(sender As Object, e As EventArgs) Handles txtQuestion.TextChanged
        If txtQuestion.Text = "" Then
            btnSend.FillColor = Color.FromArgb(172, 172, 190)
            btnSend.Enabled = False
        Else
            btnSend.FillColor = Color.FromArgb(25, 195, 125)
            btnSend.Enabled = True
        End If

    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        txtChat.Text = ""

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        pnlContent.Visible = True
        With ImageGeneration
            .TopLevel = False
            pnlContent.Controls.Add(ImageGeneration)
            .BringToFront()
            .Show()
        End With
        Guna2GradientButton2.FillColor = Color.MidnightBlue
        Guna2GradientButton3.FillColor = Color.FromArgb(64, 64, 64)
        Dim url As String = $"http://{IPv4}:3000/image/{username}"
        urlLink = url
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrCodeData)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(10)

        QRCodePictureBox.Image = qrCodeImage

    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        pnlContent.Visible = False
        Guna2GradientButton2.FillColor = Color.FromArgb(64, 64, 64)
        Guna2GradientButton3.FillColor = Color.FromArgb(49, 195, 162)

        Dim url As String = $"http://{IPv4}:3000/chat/{username}"
        urlLink = url
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrCodeData)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(10)

        QRCodePictureBox.Image = qrCodeImage

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        pnlContent.Visible = True
        With about
            .TopLevel = False
            pnlContent.Controls.Add(about)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Chatbot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = $"http://{IPv4}:3000/chat/{username}"
        urlLink = url
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrCodeData)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(10)

        QRCodePictureBox.Image = qrCodeImage

        ' Memperoleh semua alamat IP yang terhubung dengan komputer
        Dim hostName As String = Dns.GetHostName()
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(hostName)
        Dim ipAddresses As IPAddress() = ipEntry.AddressList

        ' Menampilkan alamat IPv4
        For Each ipAddress As IPAddress In ipAddresses
            If ipAddress.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                IPv4 = ipAddress.ToString()
            End If
        Next
    End Sub

    Private Sub QRCodePictureBox_Click(sender As Object, e As EventArgs) Handles QRCodePictureBox.Click
        System.Diagnostics.Process.Start(urlLink)
    End Sub
End Class