Imports System
Imports System.Windows.Forms
Imports System.Drawing

Public Class Program

    <STAThread>
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

    
        Dim form As New Form()
        form.Text = "Login"
        form.Size = New Size(700, 500)
        form.StartPosition = FormStartPosition.CenterScreen
        form.BackColor = Color.White


        Dim lblUsername As New Label()
        lblUsername.Text = "First Num:"
        lblUsername.Location = New Point(200, 100)
        lblUsername.ForeColor = Color.Purple


        Dim txtUsername As New TextBox()
        txtUsername.Location = New Point(330, 100)


        Dim lblPassword As New Label()
        lblPassword.Text = "Second Num:"
        lblPassword.Location = New Point(200, 150)
        lblPassword.ForeColor = Color.Purple


        Dim txtPassword As New TextBox()
        txtPassword.Location = New Point(330, 150)

        Dim btnLogin As New Button()
        btnLogin.Text = "SUM : "
        btnLogin.Location = New Point(200, 200)
        btnLogin.Size = New Size(120, 30)
        btnLogin.BackColor = Color.LightBlue
        btnLogin.ForeColor = Color.Red

        Dim txtsum As New TextBox()
        txtsum.Location = New Point(330, 200)
        txtsum.ReadOnly = True

        form.Controls.Add(lblUsername)
        form.Controls.Add(txtUsername)
        form.Controls.Add(lblPassword)
        form.Controls.Add(txtPassword)
        form.Controls.Add(btnLogin)
        form.Controls.Add(txtsum)

        AddHandler btnLogin.Click, Sub(sender As Object,e As EventArgs)
                                        Dim num1 As Integer = txtUsername.Text
                                        Dim num2 As Integer = txtPassword.Text

                                        Dim result As Integer = num1 + num2

                                        txtsum.Text = result.ToString

                                    End Sub

        Application.Run(form)
    End Sub
End Class
