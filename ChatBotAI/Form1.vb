Imports System.Net.Http
Imports System.Web.UI.WebControls
Imports Guna.UI2.WinForms
Imports MySqlConnector
Imports System.Globalization
Imports System.Text

Public Module Globals
    Public loggedInUsername As String
    Public loggedInNumber As String
    ' Tambahkan variabel lain yang diperlukan
End Module

Public Class Form1
    Dim connectionString As String = "server=103.153.3.20;user id=webkadupa_ammar;password=Juken12345678;database=webkadupa_bot"
    Dim connection As New MySqlConnection(connectionString)
    Public Shared username As String

    Public Shared PhoneNumber As String
    Public Shared otpCode As String
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Kata sandi harus diisi.")
            Return
        End If

        Dim sql As String = "SELECT * FROM users WHERE username = @username AND password = @password"
        Dim command As New MySqlCommand(sql, connection)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                Dim phoneNumberQuery As String = "SELECT Number FROM users WHERE username = @username"
                Dim phoneNumberCommand As New MySqlCommand(phoneNumberQuery, connection)
                phoneNumberCommand.Parameters.AddWithValue("@username", username)


                If reader.Read() Then
                    PhoneNumber = reader("Number").ToString()
                    reader.Close() ' Close the reader before executing the next query

                    otpCode = GenerateOTP() ' Menghasilkan OTP acak

                    Dim pesan As String = "Kode OTP Anda adalah: " & otpCode

                    Dim postData As String = "number=" & PhoneNumber & "&message=" & pesan

                    Using client As New HttpClient()
                        Dim content As New StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded")

                        Try
                            Dim response As HttpResponseMessage = Await client.PostAsync("https://ammar-wa.herokuapp.com/send-message", content)
                            response.EnsureSuccessStatusCode()

                            ' Pesan berhasil terkirim
                            OTP.Show()
                            Globals.loggedInUsername = username
                        Catch ex As HttpRequestException
                            ' Nomor tidak ditemukan
                            MessageBox.Show("Nomor tidak ditemukan: " & PhoneNumber)
                        End Try
                    End Using
                End If
            Else
                MessageBox.Show("Username atau kata sandi salah.")
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPassword.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin_Click(Me, EventArgs.Empty)
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged


        If CheckBox1.Checked = False Then

            txtPassword.PasswordChar = "●"
        Else
            txtPassword.PasswordChar = ""
        End If

    End Sub


    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click
        Me.Hide()
        Dim RegisterNew As New RegisterNew()
        RegisterNew.Show()
    End Sub

    Private Async Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        username = txtUsername.Text.Trim()
        Dim sql As String = "SELECT Number FROM users WHERE username = @username"
        Dim command As New MySqlCommand(sql, connection)
        command.Parameters.AddWithValue("@username", username)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                PhoneNumber = reader("Number").ToString()
                ' Lakukan tindakan yang diinginkan dengan nomor telepon
                otpCode = GenerateOTP() ' Menghasilkan OTP acak
                Dim pesan As String = "Kode OTP Anda adalah: " & otpCode

                Dim postData As String = "number=" & PhoneNumber & "&message=" & pesan
                Using client As New HttpClient()
                    Dim content As New StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded")
                    Try

                        Dim response As HttpResponseMessage = Await client.PostAsync("https://ammar-wa.herokuapp.com/send-message", content)
                        response.EnsureSuccessStatusCode()
                        'pesan berhasil terkirim
                        OTP.Show()
                        Globals.loggedInUsername = username
                    Catch ex As HttpRequestException
                        'nomor tidak ditemukan
                        MessageBox.Show("Nomor tidak ditemukan." & PhoneNumber)
                    End Try
                End Using
            Else
                MessageBox.Show("Pengguna tidak ditemukan.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Function GenerateOTP() As String
        Dim otp As String = ""
        Dim random As New Random()

        For i As Integer = 1 To 6
            otp &= random.Next(0, 10)
        Next

        Return otp
    End Function

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
