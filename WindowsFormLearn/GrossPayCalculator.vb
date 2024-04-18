Public Class GrossPayCalculator
    Dim salary As Double
    Dim grossPay As Double

    Function weeklyPayment() As String
        If Not Double.TryParse(txtSalary.Text, salary) Then
            MsgBox("Please enter valid number for salary")
            Return ""
        End If

        grossPay = salary / 52

        Return $"${grossPay.ToString("F2")}"
    End Function

    Function twicePerMonth() As String
        If Not Double.TryParse(txtSalary.Text, salary) Then
            MsgBox("Please enter valid number for salary")
            Return ""
        End If

        grossPay = salary / 26

        Return $"${grossPay.ToString("F2")}"
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If rbtnWeekly.Checked Then
            txtGross.Text = weeklyPayment()
        ElseIf rbtnTwiceMonth.Checked Then
            txtGross.Text = twicePerMonth()
        Else
            MsgBox("Please select your period of payment")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class