<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrossPayCalculator
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
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.rbtnWeekly = New System.Windows.Forms.RadioButton()
        Me.rbtnTwiceMonth = New System.Windows.Forms.RadioButton()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(167, 59)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(47, 15)
        Me.lblSalary.TabIndex = 0
        Me.lblSalary.Text = "Salary :"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(147, 107)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 22)
        Me.txtSalary.TabIndex = 1
        '
        'rbtnWeekly
        '
        Me.rbtnWeekly.AutoSize = True
        Me.rbtnWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnWeekly.Location = New System.Drawing.Point(396, 79)
        Me.rbtnWeekly.Name = "rbtnWeekly"
        Me.rbtnWeekly.Size = New System.Drawing.Size(71, 20)
        Me.rbtnWeekly.TabIndex = 2
        Me.rbtnWeekly.TabStop = True
        Me.rbtnWeekly.Text = "Weekly"
        Me.rbtnWeekly.UseVisualStyleBackColor = True
        '
        'rbtnTwiceMonth
        '
        Me.rbtnTwiceMonth.AutoSize = True
        Me.rbtnTwiceMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTwiceMonth.Location = New System.Drawing.Point(396, 135)
        Me.rbtnTwiceMonth.Name = "rbtnTwiceMonth"
        Me.rbtnTwiceMonth.Size = New System.Drawing.Size(124, 20)
        Me.rbtnTwiceMonth.TabIndex = 3
        Me.rbtnTwiceMonth.TabStop = True
        Me.rbtnTwiceMonth.Text = "Twice Per Month"
        Me.rbtnTwiceMonth.UseVisualStyleBackColor = True
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(167, 217)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(68, 15)
        Me.lblGross.TabIndex = 4
        Me.lblGross.Text = "Gross Pay :"
        '
        'txtGross
        '
        Me.txtGross.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(147, 252)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(124, 24)
        Me.txtGross.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(414, 254)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(571, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GrossPayCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.rbtnTwiceMonth)
        Me.Controls.Add(Me.rbtnWeekly)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Name = "GrossPayCalculator"
        Me.Text = "GrossPayCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalary As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents rbtnWeekly As RadioButton
    Friend WithEvents rbtnTwiceMonth As RadioButton
    Friend WithEvents lblGross As Label
    Friend WithEvents txtGross As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
