Public Class Age
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim age As Integer
        Dim registered As String

        If Integer.TryParse(txtAge.Text, age) Then
            registered = txtRegistered.Text.ToUpper()

            If age >= 18 Then
                If registered = "Y" Then
                    txtDisplay.Text = "You Can Vote"
                ElseIf registered = "N" Then
                    txtDisplay.Text = "You Need To register to vote"
                Else
                    MsgBox("Invalid registration status. Please enter Y or N.")
                End If
            Else
                txtDisplay.Text = "You Are underage to vote"
            End If
        Else
            MsgBox("Please enter a valid age.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
