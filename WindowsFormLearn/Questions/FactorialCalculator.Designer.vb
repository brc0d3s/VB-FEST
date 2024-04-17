<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FactorialCalculator
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
        Label1 = New Label()
        Label2 = New Label()
        btnCalculate = New Button()
        btnExit = New Button()
        txtNum = New TextBox()
        txtFact = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(194, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 0
        Label1.Text = "Number :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 1
        Label2.Text = "Factorial :"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(248, 238)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(456, 238)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 3
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtNum
        ' 
        txtNum.Location = New Point(268, 74)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(142, 23)
        txtNum.TabIndex = 4
        ' 
        ' txtFact
        ' 
        txtFact.Location = New Point(268, 150)
        txtFact.Name = "txtFact"
        txtFact.Size = New Size(142, 23)
        txtFact.TabIndex = 5
        ' 
        ' FactorialCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtFact)
        Controls.Add(txtNum)
        Controls.Add(btnExit)
        Controls.Add(btnCalculate)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FactorialCalculator"
        Text = "FactorialCalculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtFact As TextBox
End Class
