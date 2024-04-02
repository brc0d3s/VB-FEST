Public Class Warehouse
    Dim destination As String
    Dim thelocation As String

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        destination = txtDestination.Text.ToUpper()

        If destination = "A" Then
            thelocation = "Tennessee"
        ElseIf destination = "B" Then
            thelocation = "Kentucky"
        ElseIf destination = "C" Or destination = "D" Then
            thelocation = "Louisiana"
        Else
            MsgBox("Invalid destination.")
            Exit Sub
        End If

        txtLocation.Text = thelocation
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
