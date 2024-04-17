<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RectangleandSquare
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
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnArea1 = New Button()
        btnArea2 = New Button()
        txtSide = New TextBox()
        txtBreadth = New TextBox()
        txtLength = New TextBox()
        btnPer1 = New Button()
        btnPer2 = New Button()
        txtResult2 = New TextBox()
        txtResult1 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtResult1)
        GroupBox1.Controls.Add(txtSide)
        GroupBox1.Controls.Add(btnPer1)
        GroupBox1.Controls.Add(btnArea1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(376, 351)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "SQUARE"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtResult2)
        GroupBox2.Controls.Add(btnPer2)
        GroupBox2.Controls.Add(txtBreadth)
        GroupBox2.Controls.Add(txtLength)
        GroupBox2.Controls.Add(btnArea2)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(412, 49)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(376, 351)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "RECTANGLE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter Side :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter Length :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 2
        Label3.Text = "Enter Breadth :"
        ' 
        ' btnArea1
        ' 
        btnArea1.Location = New Point(42, 199)
        btnArea1.Name = "btnArea1"
        btnArea1.Size = New Size(75, 23)
        btnArea1.TabIndex = 1
        btnArea1.Text = "Area"
        btnArea1.UseVisualStyleBackColor = True
        ' 
        ' btnArea2
        ' 
        btnArea2.Location = New Point(73, 199)
        btnArea2.Name = "btnArea2"
        btnArea2.Size = New Size(75, 23)
        btnArea2.TabIndex = 2
        btnArea2.Text = "Area"
        btnArea2.UseVisualStyleBackColor = True
        ' 
        ' txtSide
        ' 
        txtSide.Location = New Point(138, 90)
        txtSide.Name = "txtSide"
        txtSide.Size = New Size(100, 23)
        txtSide.TabIndex = 2
        ' 
        ' txtBreadth
        ' 
        txtBreadth.Location = New Point(144, 143)
        txtBreadth.Name = "txtBreadth"
        txtBreadth.Size = New Size(100, 23)
        txtBreadth.TabIndex = 3
        ' 
        ' txtLength
        ' 
        txtLength.Location = New Point(144, 82)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(100, 23)
        txtLength.TabIndex = 4
        ' 
        ' btnPer1
        ' 
        btnPer1.Location = New Point(225, 199)
        btnPer1.Name = "btnPer1"
        btnPer1.Size = New Size(75, 23)
        btnPer1.TabIndex = 5
        btnPer1.Text = "Perimeter"
        btnPer1.UseVisualStyleBackColor = True
        ' 
        ' btnPer2
        ' 
        btnPer2.Location = New Point(229, 199)
        btnPer2.Name = "btnPer2"
        btnPer2.Size = New Size(75, 23)
        btnPer2.TabIndex = 6
        btnPer2.Text = "Perimeter"
        btnPer2.UseVisualStyleBackColor = True
        ' 
        ' txtResult2
        ' 
        txtResult2.Location = New Point(123, 281)
        txtResult2.Name = "txtResult2"
        txtResult2.Size = New Size(140, 23)
        txtResult2.TabIndex = 7
        ' 
        ' txtResult1
        ' 
        txtResult1.Location = New Point(119, 281)
        txtResult1.Name = "txtResult1"
        txtResult1.Size = New Size(134, 23)
        txtResult1.TabIndex = 8
        ' 
        ' RectangleandSquare
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "RectangleandSquare"
        Text = "RectangleandSquare"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResult1 As TextBox
    Friend WithEvents txtSide As TextBox
    Friend WithEvents btnPer1 As Button
    Friend WithEvents btnArea1 As Button
    Friend WithEvents txtResult2 As TextBox
    Friend WithEvents btnPer2 As Button
    Friend WithEvents txtBreadth As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents btnArea2 As Button
End Class
