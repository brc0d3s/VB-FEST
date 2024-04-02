Public Class Seminar
    Dim financeCost As Integer = 150
    Dim healthCost As Integer = 125
    Dim marketingCost As Integer = 135

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim totalCost As Integer = 0

        If cbxFinace.Checked Then
            totalCost += financeCost
        End If

        If cbxHealth.Checked Then
            totalCost += healthCost
        End If

        If cbxMarketing.Checked Then
            totalCost += marketingCost
        End If

        txtAmount.Text = "$" & totalCost.ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class