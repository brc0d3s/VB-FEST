Public Class DivideByZeroException
    'Inherits Exception

    Dim answer, num1, num2 As Double

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If Not Double.TryParse(txtNum1.Text, num1) OrElse Not Double.TryParse(txtNum2.Text, num2) Then
            MsgBox("Enter valid double numbers")
            Return
        End If

        Try
            If num2 = 0 Then
                Throw New System.DivideByZeroException("Attempted to divide by zero.")
            End If

            answer = num1 / num2
        Catch ex As System.DivideByZeroException
            MsgBox("Divide By Zero Exception Caught")
        Catch ex As Exception
            MsgBox($"An error occurred: {ex.Message}")
        Finally
            MsgBox($"The answer is: {answer.ToString("F2")}")
        End Try
    End Sub
End Class
