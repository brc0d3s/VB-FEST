Public Class FactorialCalculator
    Dim number As Integer
    Dim factorial As Integer

    Function factorialCalculate(ByVal num As Integer) As Integer
        If num = 0 Then
            Return 1
        Else
            factorial = num * factorialCalculate(num - 1)
        End If


        Return factorial
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Not Integer.TryParse(txtNum.Text, number) Then
            MsgBox("Please enter a valid number")
        End If

        txtFact.Text = factorialCalculate(number)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class