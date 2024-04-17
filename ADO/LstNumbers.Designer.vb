<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LstNumbers
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
        Me.lstNum = New System.Windows.Forms.ListBox()
        Me.btnNum = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNum
        '
        Me.lstNum.FormattingEnabled = True
        Me.lstNum.Location = New System.Drawing.Point(446, 69)
        Me.lstNum.Name = "lstNum"
        Me.lstNum.Size = New System.Drawing.Size(96, 316)
        Me.lstNum.TabIndex = 0
        '
        'btnNum
        '
        Me.btnNum.BackColor = System.Drawing.SystemColors.Control
        Me.btnNum.ForeColor = System.Drawing.Color.Red
        Me.btnNum.Location = New System.Drawing.Point(296, 79)
        Me.btnNum.Name = "btnNum"
        Me.btnNum.Size = New System.Drawing.Size(75, 23)
        Me.btnNum.TabIndex = 1
        Me.btnNum.Text = "Click Me"
        Me.btnNum.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(296, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Click Me 2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(296, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Click Me 3"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LstNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNum)
        Me.Controls.Add(Me.lstNum)
        Me.Name = "LstNumbers"
        Me.Text = "LstNumbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstNum As ListBox
    Friend WithEvents btnNum As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
