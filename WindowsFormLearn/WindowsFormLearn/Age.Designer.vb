<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Age
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAge = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtRegistered = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAge
        '
        Me.btnAge.AutoSize = True
        Me.btnAge.Location = New System.Drawing.Point(197, 121)
        Me.btnAge.Name = "btnAge"
        Me.btnAge.Size = New System.Drawing.Size(29, 13)
        Me.btnAge.TabIndex = 0
        Me.btnAge.Text = "Age:"
        '
        'btnRegister
        '
        Me.btnRegister.AutoSize = True
        Me.btnRegister.Location = New System.Drawing.Point(320, 121)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(87, 13)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = " Registered: Y/N"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(503, 173)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 41)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(657, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 42)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(256, 261)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(349, 43)
        Me.txtDisplay.TabIndex = 4
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(180, 172)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(70, 42)
        Me.txtAge.TabIndex = 5
        '
        'txtRegistered
        '
        Me.txtRegistered.Location = New System.Drawing.Point(323, 172)
        Me.txtRegistered.Multiline = True
        Me.txtRegistered.Name = "txtRegistered"
        Me.txtRegistered.Size = New System.Drawing.Size(70, 42)
        Me.txtRegistered.TabIndex = 6
        '
        'Age
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtRegistered)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnAge)
        Me.Name = "Age"
        Me.Text = "Voter Eligibility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAge As Label
    Friend WithEvents btnRegister As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtRegistered As TextBox
End Class
