<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMI
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.ForeColor = System.Drawing.Color.Red
        Me.btnCalculate.Location = New System.Drawing.Point(320, 235)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(153, 33)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "CALCULATE BMI"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(396, 83)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(160, 20)
        Me.txtWeight.TabIndex = 1
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(396, 171)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(160, 20)
        Me.txtHeight.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Weight (KGS)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Height (Metres)"
        '
        'txtBMI
        '
        Me.txtBMI.Location = New System.Drawing.Point(331, 334)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(160, 20)
        Me.txtBMI.TabIndex = 5
        '
        'BMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "BMI"
        Me.Text = "BMI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBMI As TextBox
End Class
