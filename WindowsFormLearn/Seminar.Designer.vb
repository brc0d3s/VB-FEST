<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seminar
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
        Me.cbxFinace = New System.Windows.Forms.CheckBox()
        Me.cbxHealth = New System.Windows.Forms.CheckBox()
        Me.cbxMarketing = New System.Windows.Forms.CheckBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxFinace
        '
        Me.cbxFinace.AutoSize = True
        Me.cbxFinace.Location = New System.Drawing.Point(179, 77)
        Me.cbxFinace.Name = "cbxFinace"
        Me.cbxFinace.Size = New System.Drawing.Size(97, 17)
        Me.cbxFinace.TabIndex = 0
        Me.cbxFinace.Text = "Finance ($150)"
        Me.cbxFinace.UseVisualStyleBackColor = True
        '
        'cbxHealth
        '
        Me.cbxHealth.AutoSize = True
        Me.cbxHealth.Location = New System.Drawing.Point(179, 139)
        Me.cbxHealth.Name = "cbxHealth"
        Me.cbxHealth.Size = New System.Drawing.Size(90, 17)
        Me.cbxHealth.TabIndex = 1
        Me.cbxHealth.Text = "Health ($125)"
        Me.cbxHealth.UseVisualStyleBackColor = True
        '
        'cbxMarketing
        '
        Me.cbxMarketing.AutoSize = True
        Me.cbxMarketing.Location = New System.Drawing.Point(179, 206)
        Me.cbxMarketing.Name = "cbxMarketing"
        Me.cbxMarketing.Size = New System.Drawing.Size(106, 17)
        Me.cbxMarketing.TabIndex = 2
        Me.cbxMarketing.Text = "Marketing ($135)"
        Me.cbxMarketing.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(221, 293)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(72, 13)
        Me.lblAmount.TabIndex = 3
        Me.lblAmount.Text = "Amount Due :"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(334, 275)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(224, 31)
        Me.txtAmount.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(518, 77)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(518, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Seminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.cbxMarketing)
        Me.Controls.Add(Me.cbxHealth)
        Me.Controls.Add(Me.cbxFinace)
        Me.Name = "Seminar"
        Me.Text = "Seminar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxFinace As CheckBox
    Friend WithEvents cbxHealth As CheckBox
    Friend WithEvents cbxMarketing As CheckBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
