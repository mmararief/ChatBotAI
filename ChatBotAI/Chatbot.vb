Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text

Imports System.Web.UI.WebControls
Imports Newtonsoft.Json.Linq

Public Class Chatbot
    Private Async Function callOpenAi(sQuestion As String) As Task(Of String)
        Dim apiKey As String = "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"
        Dim apiUrl As String = "https://api.openai.com/v1/chat/completions"
        Dim responseContent As String = ""

        ' Membuat HttpClient
        Dim httpClient As New HttpClient()
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)

        ' Membuat body JSON
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
        End If

        ' Mengatur scroll ke paling bawah
        txtChat.SelectionStart = txtChat.TextLength
        txtChat.ScrollToCaret()

        txtQuestion.Text = ""
    End Sub

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
        Guna2GradientButton3.Visible = True
        Guna2GradientButton2.Visible = False
        Guna2GradientButton1.Visible = False
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        pnlContent.Visible = False
        Guna2GradientButton2.Visible = True
        Guna2GradientButton3.Visible = False
        Guna2GradientButton1.Visible = True
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub
End Class