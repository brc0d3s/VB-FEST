Public Class Form1
    Dim sales As Double
    Dim commision As Double


    Private Sub btneight_Click(sender As Object, e As EventArgs) Handles btneight.Click
        sales = txtsales.Text
        commision = 0.08 * sales
        txtcommision.Text = commision
    End Sub

    Private Sub btnten_Click(sender As Object, e As EventArgs) Handles btnten.Click
        sales = txtsales.Text
        commision = 0.1 * sales
        txtcommision.Text = commision
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnAge_Click(sender As Object, e As EventArgs) Handles btnAge.Click
        Me.Hide()
        Age.Show()
    End Sub

    Private Sub btnWarehouse_Click(sender As Object, e As EventArgs) Handles btnWarehouse.Click
        Me.Hide()
        Warehouse.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnSeminar.Click
        Me.Hide()
        Seminar.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Me.Hide()
        Payment.Show()
    End Sub
End Class
