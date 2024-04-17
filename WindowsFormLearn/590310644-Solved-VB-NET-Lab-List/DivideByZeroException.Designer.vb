<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DivideByZeroException
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
        btnDivide = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        SuspendLayout()
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(316, 224)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(75, 23)
        btnDivide.TabIndex = 0
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(204, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 1
        Label1.Text = "Num 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(204, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 2
        Label2.Text = "Num 2"
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(291, 85)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(120, 23)
        txtNum1.TabIndex = 3
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(291, 154)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(120, 23)
        txtNum2.TabIndex = 4
        ' 
        ' DivideByZeroException
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnDivide)
        Name = "DivideByZeroException"
        Text = "DivideByZeroException"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDivide As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
End Class
