Imports Npgsql

Public Class CRUD
    Dim id As Integer
    Dim username As String
    Dim email As String
    Dim password As String


    Dim rowsAffected As Integer
    Dim connection As New NpgsqlConnection("Host=ep-hidden-night-a5bx4vqf-pooler.us-east-2.aws.neon.tech;Port=5432;Username=neondb_owner;Password=M6uzyPULT5RA;Database=ADO;")
    Dim cmd As NpgsqlCommand
    Dim reader As NpgsqlDataReader

    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            connection.Open()
            Dim cmd As New NpgsqlCommand("select * from adoTest", connection)
            Dim ad As New NpgsqlDataAdapter(cmd)
            Dim table As New DataTable
            ad.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        username = txtUsername.Text
        email = txtEmail.Text
        password = txtPassword.Text

        Try
            cmd = New NpgsqlCommand("INSERT INTO adoTest(username,email,password) VALUES(@username,@email,@password)", connection)
            'Add parameters
            cmd.Parameters.AddWithValue("username", username)
            cmd.Parameters.AddWithValue("email", email)
            cmd.Parameters.AddWithValue("password", password)

            connection.Open()
            rowsAffected = cmd.ExecuteNonQuery()
            connection.Close()

            If rowsAffected > 0 Then
                MsgBox("Record Inserted", MsgBoxStyle.Information)
                txtID.Clear()
                txtUsername.Clear()
                txtEmail.Clear()
                txtPassword.Clear()
                LoadData()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not Integer.TryParse(txtID.Text, id) Then
            MsgBox("Please enter a valid number for ID", MsgBoxStyle.Exclamation)
            Return
        End If

        username = txtUsername.Text
        email = txtEmail.Text
        password = txtPassword.Text

        Try
            cmd = New NpgsqlCommand("UPDATE adoTest SET username = @username, email = @email, password = @password WHERE userid = @id", connection)
            ' Add parameters
            cmd.Parameters.AddWithValue("username", username)
            cmd.Parameters.AddWithValue("email", email)
            cmd.Parameters.AddWithValue("password", password)
            cmd.Parameters.AddWithValue("id", id)

            connection.Open()
            rowsAffected = cmd.ExecuteNonQuery()
            connection.Close()

            If rowsAffected > 0 Then
                MsgBox("Record Updated", MsgBoxStyle.Information)
                txtID.Clear()
                txtUsername.Clear()
                txtEmail.Clear()
                txtPassword.Clear()
                LoadData()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not Integer.TryParse(txtID.Text, id) Then
            MsgBox("Please enter a valid number for ID", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            cmd = New NpgsqlCommand("DELETE FROM adoTest WHERE userid = @id", connection)
            ' Add parameter
            cmd.Parameters.AddWithValue("id", id)

            connection.Open()
            rowsAffected = cmd.ExecuteNonQuery()
            connection.Close()

            If rowsAffected > 0 Then
                MsgBox("Record Deleted", MsgBoxStyle.Information)
                txtID.Clear()
                txtUsername.Clear()
                txtEmail.Clear()
                txtPassword.Clear()
                LoadData()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Not Integer.TryParse(txtID.Text, id) Then
            MsgBox("Please enter a valid number for ID", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            cmd = New NpgsqlCommand("SELECT username,email,password FROM adoTest WHERE userid= @id", connection)
            cmd.Parameters.AddWithValue("id", id)

            connection.Open()

            reader = cmd.ExecuteReader()
            If reader.Read() Then
                txtUsername.Text = reader("username").ToString()
                txtEmail.Text = reader("email").ToString()
                txtPassword.Text = reader("password").ToString()
                connection.Close()
                MsgBox("Record Found", MsgBoxStyle.Information)
                txtID.Clear()
                LoadData()
            Else
                ' If no data is found, notify the user
                MsgBox("No record found for the provided ID", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Close()
        End Try
    End Sub

End Class
