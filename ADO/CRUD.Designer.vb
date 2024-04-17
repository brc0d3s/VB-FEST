<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAdd = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        lblID = New Label()
        lblAddress = New Label()
        lblName = New Label()
        txtID = New TextBox()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        dgv = New DataGridView()
        Panel2 = New Panel()
        txtPassword = New TextBox()
        Label2 = New Label()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnAdd.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = SystemColors.ControlLightLight
        btnAdd.Location = New Point(786, 167)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(111, 46)
        btnAdd.TabIndex = 0
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(278, 23)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 33)
        Label1.TabIndex = 4
        Label1.Text = "CRUD OPERATIONS"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(-4, 65)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1129, 11)
        Panel1.TabIndex = 5
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.ForeColor = Color.White
        lblID.Location = New Point(159, 100)
        lblID.Margin = New Padding(4, 0, 4, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(28, 20)
        lblID.TabIndex = 6
        lblID.Text = "ID"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.White
        lblAddress.Location = New Point(159, 252)
        lblAddress.Margin = New Padding(4, 0, 4, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(53, 20)
        lblAddress.TabIndex = 9
        lblAddress.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.White
        lblName.Location = New Point(159, 177)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(91, 20)
        lblName.TabIndex = 10
        lblName.Text = "Username"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(303, 100)
        txtID.Margin = New Padding(4, 3, 4, 3)
        txtID.Name = "txtID"
        txtID.Size = New Size(277, 26)
        txtID.TabIndex = 11
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(303, 252)
        txtEmail.Margin = New Padding(4, 3, 4, 3)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(277, 26)
        txtEmail.TabIndex = 12
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(303, 177)
        txtUsername.Margin = New Padding(4, 3, 4, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(277, 26)
        txtUsername.TabIndex = 14
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnUpdate.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = SystemColors.ControlLightLight
        btnUpdate.Location = New Point(786, 263)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(111, 46)
        btnUpdate.TabIndex = 20
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ControlLightLight
        btnDelete.Location = New Point(786, 364)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(111, 46)
        btnDelete.TabIndex = 21
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSearch.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ControlLightLight
        btnSearch.Location = New Point(786, 92)
        btnSearch.Margin = New Padding(4, 3, 4, 3)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(111, 46)
        btnSearch.TabIndex = 22
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(30, 460)
        dgv.Margin = New Padding(4, 3, 4, 3)
        dgv.Name = "dgv"
        dgv.Size = New Size(904, 196)
        dgv.TabIndex = 23
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Location = New Point(-4, 434)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(977, 11)
        Panel2.TabIndex = 26
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(303, 337)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(277, 26)
        txtPassword.TabIndex = 27
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(159, 343)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 28
        Label2.Text = "Password"
        ' 
        ' CRUD
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        ClientSize = New Size(974, 684)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(Panel2)
        Controls.Add(dgv)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(txtUsername)
        Controls.Add(txtEmail)
        Controls.Add(txtID)
        Controls.Add(lblName)
        Controls.Add(lblAddress)
        Controls.Add(lblID)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(btnAdd)
        Margin = New Padding(4, 3, 4, 3)
        Name = "CRUD"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblID As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
End Class
