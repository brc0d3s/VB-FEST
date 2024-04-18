Public Class RectangleandSquare
    Dim side As Double
    Dim lengthvalue As Double
    Dim widthvalue As Double



    Private Sub btnArea1_Click(sender As Object, e As EventArgs) Handles btnArea1.Click
        If Not Double.TryParse(txtSide.Text, side) Then
            MsgBox("Please enter valid value")
            Return
        End If

        txtResult1.Text = Math.Pow(side, 2)
    End Sub

    Private Sub btnPer1_Click(sender As Object, e As EventArgs) Handles btnPer1.Click
        If Not Double.TryParse(txtSide.Text, side) Then
            MsgBox("Please enter valid value")
            Return
        End If

        txtResult1.Text = side * 4

    End Sub

    Private Sub btnArea2_Click(sender As Object, e As EventArgs) Handles btnArea2.Click
        If Not Double.TryParse(txtLength.Text, lengthvalue) AndAlso Not Double.TryParse(txtBreadth.Text, widthvalue) Then
            MsgBox("Please enter a valid values")
            Return
        End If

        txtResult2.Text = lengthvalue * widthvalue
    End Sub

    Private Sub btnPer2_Click(sender As Object, e As EventArgs) Handles btnPer2.Click
        If Not Double.TryParse(txtLength.Text, lengthvalue) AndAlso Not Double.TryParse(txtBreadth.Text, widthvalue) Then
            MsgBox("Please enter a valid values")
            Return
        End If

        txtResult2.Text = 2 * (lengthvalue + widthvalue)
    End Sub
End Class