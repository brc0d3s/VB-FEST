Public Class Multiplication_table
    Dim number As Integer

    Private Sub Multiplication_table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        number = InputBox("Enter Number to Display Multiplication table")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        For i As Integer = 1 To 10 Step 1
            lstbxTable.Items.Add($"{number} * {i} = {number * i}")
        Next
    End Sub

End Class