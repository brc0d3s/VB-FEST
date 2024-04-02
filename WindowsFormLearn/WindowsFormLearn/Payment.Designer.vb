<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.pctHouse = New System.Windows.Forms.PictureBox()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstRate = New System.Windows.Forms.ListBox()
        CType(Me.pctHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctHouse
        '
        Me.pctHouse.Image = Global.WindowsFormLearn.My.Resources.Resources.house
        Me.pctHouse.Location = New System.Drawing.Point(57, 15)
        Me.pctHouse.Name = "pctHouse"
        Me.pctHouse.Size = New System.Drawing.Size(71, 86)
        Me.pctHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHouse.TabIndex = 0
        Me.pctHouse.TabStop = False
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(216, 59)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(53, 13)
        Me.lblPrincipal.TabIndex = 1
        Me.lblPrincipal.Text = "Principal :"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipal.Location = New System.Drawing.Point(176, 88)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(143, 26)
        Me.txtPrincipal.TabIndex = 2
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(490, 49)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(50, 13)
        Me.lblRate.TabIndex = 4
        Me.lblRate.Text = "Rate: (%)"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(54, 174)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(91, 13)
        Me.lblPayment.TabIndex = 5
        Me.lblPayment.Text = "Monthly Payment:"
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(57, 207)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(288, 158)
        Me.txtPayment.TabIndex = 6
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(493, 267)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(75, 23)
        Me.btncalculate.TabIndex = 7
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(493, 324)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstRate
        '
        Me.lstRate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lstRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRate.FormattingEnabled = True
        Me.lstRate.ItemHeight = 15
        Me.lstRate.Location = New System.Drawing.Point(493, 77)
        Me.lstRate.Name = "lstRate"
        Me.lstRate.Size = New System.Drawing.Size(63, 154)
        Me.lstRate.TabIndex = 9
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstRate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.pctHouse)
        Me.Name = "Payment"
        Me.Text = "Payment"
        CType(Me.pctHouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctHouse As PictureBox
    Friend WithEvents lblPrincipal As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents lblRate As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstRate As ListBox
End Class
