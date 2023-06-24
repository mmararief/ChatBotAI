Imports System.Net.Http
Imports System.Text

Public Class OTP
    Dim otp = Form1.otpCode
    Dim Number = Form1.PhoneNumber
    Private Sub OTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim userEnteredOTP As String = otp1.Text & otp2.Text & otp3.Text & otp4.Text & otp5.Text & otp6.Text
        If userEnteredOTP = otp Then
            MessageBox.Show("Kode OTP yang dimasukkan benar. Proses login berhasil.")
            Me.Hide()
            Form1.Hide()
            Dim chat As New Chatbot()
            chat.Show()
        Else
            MessageBox.Show("Kode OTP yang dimasukkan salah. Proses login gagal.")
        End If
    End Sub

    Private Sub otp1_TextChanged(sender As Object, e As EventArgs) Handles otp1.TextChanged
        If otp1.Text.Length = 1 Then
            otp2.Focus()
        End If
    End Sub

    Private Sub otp2_TextChanged(sender As Object, e As EventArgs) Handles otp2.TextChanged
        If otp2.Text.Length = 1 Then
            otp3.Focus()
        End If
    End Sub

    Private Sub otp3_TextChanged(sender As Object, e As EventArgs) Handles otp3.TextChanged
        If otp3.Text.Length = 1 Then
            otp4.Focus()
        End If
    End Sub

    Private Sub otp4_TextChanged(sender As Object, e As EventArgs) Handles otp4.TextChanged
        If otp4.Text.Length = 1 Then
            otp5.Focus()
        End If
    End Sub

    Private Sub otp5_TextChanged(sender As Object, e As EventArgs) Handles otp5.TextChanged
        If otp5.Text.Length = 1 Then
            otp6.Focus()
        End If
    End Sub

    Private Sub otp6_TextChanged(sender As Object, e As EventArgs) Handles otp6.TextChanged
        ' Proses terakhir, misalnya memeriksa OTP yang diinputkan
        ' atau melanjutkan tindakan setelah memasukkan OTP lengkap
    End Sub

    Private Sub otp2_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles otp2.PreviewKeyDown
        If e.KeyCode = Keys.Back AndAlso String.IsNullOrEmpty(otp2.Text) Then
            otp1.Focus()
        End If
    End Sub

    Private Sub otp3_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles otp3.PreviewKeyDown
        If e.KeyCode = Keys.Back AndAlso String.IsNullOrEmpty(otp3.Text) Then
            otp2.Focus()
        End If
    End Sub

    Private Sub otp4_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles otp4.PreviewKeyDown
        If e.KeyCode = Keys.Back AndAlso String.IsNullOrEmpty(otp4.Text) Then
            otp3.Focus()
        End If
    End Sub

    Private Sub otp5_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles otp5.PreviewKeyDown
        If e.KeyCode = Keys.Back AndAlso String.IsNullOrEmpty(otp5.Text) Then
            otp4.Focus()
        End If
    End Sub

    Private Sub otp6_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles otp6.PreviewKeyDown
        If e.KeyCode = Keys.Back AndAlso String.IsNullOrEmpty(otp6.Text) Then
            otp5.Focus()
        End If
    End Sub


    Private Async Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        otp = GenerateOTP() ' Menghasilkan OTP acak
        Dim pesan As String = "Kode OTP Anda adalah: " & otp

        Dim postData As String = "number=" & Number & "&message=" & pesan
        Using client As New HttpClient()
            Dim content As New StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded")

            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("https://ammar-wa.herokuapp.com/send-message", content)
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Kode OTP baru telah dikirim.")

            Catch ex As HttpRequestException
                ' Nomor tidak ditemukan
                MessageBox.Show("Nomor tidak ditemukan: " & Number)
            End Try
        End Using
    End Sub

    Private Function GenerateOTP() As String
        Dim otp As String = ""
        Dim random As New Random()

        For i As Integer = 1 To 6
            otp &= random.Next(0, 10)
        Next

        Return otp
    End Function
End Class