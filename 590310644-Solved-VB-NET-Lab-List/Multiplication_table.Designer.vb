<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multiplication_table
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
        lstbxTable = New ListBox()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' lstbxTable
        ' 
        lstbxTable.FormattingEnabled = True
        lstbxTable.ItemHeight = 15
        lstbxTable.Location = New Point(339, 115)
        lstbxTable.Name = "lstbxTable"
        lstbxTable.Size = New Size(98, 199)
        lstbxTable.TabIndex = 0
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(298, 34)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(206, 50)
        btnCalculate.TabIndex = 1
        btnCalculate.Text = "Calculate Multiplication Table"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Multiplication_table
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(lstbxTable)
        Name = "Multiplication_table"
        Text = "Multiplication_table"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstbxTable As ListBox
    Friend WithEvents btnCalculate As Button
End Class
