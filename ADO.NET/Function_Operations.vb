Public Class Function_Operations

    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btnNum.Click
        Dim num1 As Integer = CInt(InputBox("Enter num 1"))
        Dim num2 As Integer = CInt(InputBox("Enter num 2"))
        Dim out As Integer = AddThem(num1, num2)
        MessageBox.Show("Result: " & out)
    End Sub

    Function AddThem(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim res As Integer = num1 + num2
        Return res
    End Function

End Class
