Imports MySqlConnector
Public Class Register
    Dim connectionString As String = "server=localhost;user id=root;password=;database=bot_sidudu"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        If username = "" Or password = "" Or nama = "" Or email = "" Then
            MessageBox.Show("Username, nama, email dan Kata sandi harus diisi.")
            Return
        End If

        Dim sql As String = "SELECT * FROM users WHERE username =@username AND password=@password"
        Dim command As New MySqlCommand(sql, connection)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        connection.Open()
        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            MsgBox("Email id Already Registered", MsgBoxStyle.Critical)
            connection.Close()
        Else
            connection.Close()
            connection.Open()
            Dim register As String = "INSERT INTO users VALUES('', @email, @username, @nama, @password)"

            Dim commandReg As New MySqlCommand(register, connection)
            commandReg.Parameters.AddWithValue("@username", username)
            commandReg.Parameters.AddWithValue("@password", password)
            commandReg.Parameters.AddWithValue("@nama", nama)
            commandReg.Parameters.AddWithValue("@email", email)
            commandReg.ExecuteNonQuery()

            MsgBox("sukses membuat akun, silahkan login")
            Me.Hide()
            Dim login As New Form1()
            login.Show()
            login.Show()


        End If
    End Sub
End Class