﻿Imports MySqlConnector
Public Class RegisterNew
    Private connectionString As String = "server=103.153.3.20;user id=webkadupa_ammar;password=Juken12345678;database=webkadupa_bot"


    Private Sub Guna2HtmlLabel13_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel13.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub txtSubmit_Click(sender As Object, e As EventArgs) Handles txtSubmit.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(nama) OrElse String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Username, nama, email, dan Kata sandi harus diisi.")
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Check if the username and password combination already exists
            Dim selectQuery As String = "SELECT * FROM users WHERE username = @username OR password = @email"
            Dim selectCommand As New MySqlCommand(selectQuery, connection)
            selectCommand.Parameters.AddWithValue("@username", username)
            selectCommand.Parameters.AddWithValue("@email", email)

            Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("Email id Already Registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            ' Insert the new user registration information
            Dim insertQuery As String = "INSERT INTO users VALUES('', @email, @username, @nama, @password)"
            Dim insertCommand As New MySqlCommand(insertQuery, connection)
            insertCommand.Parameters.AddWithValue("@username", username)
            insertCommand.Parameters.AddWithValue("@password", password)
            insertCommand.Parameters.AddWithValue("@nama", nama)
            insertCommand.Parameters.AddWithValue("@email", email)

            insertCommand.ExecuteNonQuery()

            MessageBox.Show("Sukses membuat akun, silahkan login", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()

            Dim login As New Form1()
            login.Show()
        End Using
    End Sub
End Class