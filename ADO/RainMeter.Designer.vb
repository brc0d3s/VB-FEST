<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RainMeter
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
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.txtMedian = New System.Windows.Forms.TextBox()
        Me.txtMode = New System.Windows.Forms.TextBox()
        Me.txtHighest = New System.Windows.Forms.TextBox()
        Me.txtDeviation = New System.Windows.Forms.TextBox()
        Me.txtLowest = New System.Windows.Forms.TextBox()
        Me.btnDeviation = New System.Windows.Forms.Button()
        Me.btnMedian = New System.Windows.Forms.Button()
        Me.btnHighest = New System.Windows.Forms.Button()
        Me.btnLowest = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(123, 206)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 1
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(346, 206)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 2
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(104, 152)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(119, 23)
        Me.btnTotal.TabIndex = 3
        Me.btnTotal.Text = "Total Rainfall"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(346, 152)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(105, 23)
        Me.btnAverage.TabIndex = 4
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnMode
        '
        Me.btnMode.Location = New System.Drawing.Point(104, 296)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(119, 23)
        Me.btnMode.TabIndex = 5
        Me.btnMode.Text = "Mode"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'txtMedian
        '
        Me.txtMedian.Location = New System.Drawing.Point(595, 298)
        Me.txtMedian.Name = "txtMedian"
        Me.txtMedian.Size = New System.Drawing.Size(100, 20)
        Me.txtMedian.TabIndex = 6
        '
        'txtMode
        '
        Me.txtMode.Location = New System.Drawing.Point(245, 298)
        Me.txtMode.Name = "txtMode"
        Me.txtMode.Size = New System.Drawing.Size(100, 20)
        Me.txtMode.TabIndex = 7
        '
        'txtHighest
        '
        Me.txtHighest.Location = New System.Drawing.Point(245, 391)
        Me.txtHighest.Name = "txtHighest"
        Me.txtHighest.Size = New System.Drawing.Size(100, 20)
        Me.txtHighest.TabIndex = 8
        '
        'txtDeviation
        '
        Me.txtDeviation.Location = New System.Drawing.Point(586, 206)
        Me.txtDeviation.Name = "txtDeviation"
        Me.txtDeviation.Size = New System.Drawing.Size(100, 20)
        Me.txtDeviation.TabIndex = 9
        '
        'txtLowest
        '
        Me.txtLowest.Location = New System.Drawing.Point(595, 387)
        Me.txtLowest.Name = "txtLowest"
        Me.txtLowest.Size = New System.Drawing.Size(100, 20)
        Me.txtLowest.TabIndex = 10
        '
        'btnDeviation
        '
        Me.btnDeviation.Location = New System.Drawing.Point(576, 152)
        Me.btnDeviation.Name = "btnDeviation"
        Me.btnDeviation.Size = New System.Drawing.Size(119, 23)
        Me.btnDeviation.TabIndex = 11
        Me.btnDeviation.Text = "Standard Deviation"
        Me.btnDeviation.UseVisualStyleBackColor = True
        '
        'btnMedian
        '
        Me.btnMedian.Location = New System.Drawing.Point(452, 295)
        Me.btnMedian.Name = "btnMedian"
        Me.btnMedian.Size = New System.Drawing.Size(119, 23)
        Me.btnMedian.TabIndex = 12
        Me.btnMedian.Text = "Median"
        Me.btnMedian.UseVisualStyleBackColor = True
        '
        'btnHighest
        '
        Me.btnHighest.Location = New System.Drawing.Point(104, 387)
        Me.btnHighest.Name = "btnHighest"
        Me.btnHighest.Size = New System.Drawing.Size(119, 23)
        Me.btnHighest.TabIndex = 13
        Me.btnHighest.Text = "Highest Value"
        Me.btnHighest.UseVisualStyleBackColor = True
        '
        'btnLowest
        '
        Me.btnLowest.Location = New System.Drawing.Point(452, 389)
        Me.btnLowest.Name = "btnLowest"
        Me.btnLowest.Size = New System.Drawing.Size(119, 23)
        Me.btnLowest.TabIndex = 14
        Me.btnLowest.Text = "Lowest Value"
        Me.btnLowest.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.ForeColor = System.Drawing.Color.Red
        Me.btnEnter.Location = New System.Drawing.Point(346, 41)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(165, 51)
        Me.btnEnter.TabIndex = 15
        Me.btnEnter.Text = "CLICK TO ENTER VALUES"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'RainMeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnLowest)
        Me.Controls.Add(Me.btnHighest)
        Me.Controls.Add(Me.btnMedian)
        Me.Controls.Add(Me.btnDeviation)
        Me.Controls.Add(Me.txtLowest)
        Me.Controls.Add(Me.txtDeviation)
        Me.Controls.Add(Me.txtHighest)
        Me.Controls.Add(Me.txtMode)
        Me.Controls.Add(Me.txtMedian)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtTotal)
        Me.Name = "RainMeter"
        Me.Text = "RainMeter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnMode As Button
    Friend WithEvents txtMedian As TextBox
    Friend WithEvents txtMode As TextBox
    Friend WithEvents txtHighest As TextBox
    Friend WithEvents txtDeviation As TextBox
    Friend WithEvents txtLowest As TextBox
    Friend WithEvents btnDeviation As Button
    Friend WithEvents btnMedian As Button
    Friend WithEvents btnHighest As Button
    Friend WithEvents btnLowest As Button
    Friend WithEvents btnEnter As Button
End Class
