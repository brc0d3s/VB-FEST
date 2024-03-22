<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Function_Operations
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
        Me.btnNum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNum
        '
        Me.btnNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum.ForeColor = System.Drawing.Color.Red
        Me.btnNum.Location = New System.Drawing.Point(315, 156)
        Me.btnNum.Name = "btnNum"
        Me.btnNum.Size = New System.Drawing.Size(163, 59)
        Me.btnNum.TabIndex = 0
        Me.btnNum.Text = "CLICK ME"
        Me.btnNum.UseVisualStyleBackColor = True
        '
        'Function_Operations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNum)
        Me.Name = "Function_Operations"
        Me.Text = "Function_Operations"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNum As Button
End Class
