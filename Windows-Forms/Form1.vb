Imports System
Imports System.Windows.Forms
Imports System.Drawing

Public Class Program


    <STAThread>
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Create and configure the form
        Dim form As New Form()
        form.Text = "Login Form"
        form.BackColor = System.Drawing.Color.Black

        ' Create controls
        Dim lblUsername As New Label()
        lblUsername.Text = "First Num:"
        lblUsername.Location = New Point(20, 20)
        lblUsername.ForeColor = System.Drawing.Color.Blue

        Dim txtUsername As New TextBox()
        txtUsername.Location = New Point(120, 20)

        Dim lblPassword As New Label()
        lblPassword.Text = "Second Num:"
        lblPassword.Location = New Point(20, 50)
        lblPassword.ForeColor = System.Drawing.Color.Blue

        Dim txtPassword As New TextBox()
        txtPassword.Location = New Point(120, 50)

        Dim btnSubmit As New Button()
        btnSubmit.Text = "Submit"
        btnSubmit.Location = New Point(120, 80)
        btnSubmit.Size = New Size(80, 30)
        btnSubmit.BackColor = System.Drawing.Color.LightBlue
        btnSubmit.ForeColor = System.Drawing.Color.Red
        btnSubmit.Font = New Font(btnSubmit.Font.FontFamily, btnSubmit.Font.Size, FontStyle.Regular)

        ' Add controls to form
        form.Controls.Add(lblUsername)
        form.Controls.Add(txtUsername)
        form.Controls.Add(lblPassword)
        form.Controls.Add(txtPassword)
        form.Controls.Add(btnSubmit)

        
        Application.Run(form)
    End Sub

    

End Class
