Public Class ConcertTickets
    Dim tickets As Integer
    Dim subTotal As Double
    Dim discount As Double
    Dim totalDue As Double

    Const standardCost As Double = 62.5
    Const vipCost As Double = 300.0

    Function standardTicket(ticketsCount As Integer) As (Double, Double, Double)
        subTotal = ticketsCount * standardCost
        discount = (10 / 100 * standardCost) * ticketsCount
        totalDue = subTotal - discount

        Return (subTotal, discount, totalDue)
    End Function

    Function vipTicket(ticketsCount As Integer) As (Double, Double, Double)
        subTotal = ticketsCount * vipCost
        discount = (10 / 100 * vipCost) * ticketsCount
        totalDue = subTotal - discount

        Return (subTotal, discount, totalDue)
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Not Integer.TryParse(txtTickets.Text, tickets) Then
            MsgBox("Please enter valid number of tickets")
            Exit Sub
        End If

        Dim result As (Double, Double, Double)
        If rbtnStandard.Checked Then
            result = standardTicket(tickets)
        ElseIf rbtnVIP.Checked Then
            result = vipTicket(tickets)
        Else
            MsgBox("Please select your ticket type/category")
            Exit Sub
        End If

        ' Update textbox values after calculation
        txtSubTotal.Text = result.Item1.ToString("F2") ' Subtotal
        txtDiscount.Text = result.Item2.ToString("F2") ' Discount
        txtTotal.Text = result.Item3.ToString("F2") ' Total Due
    End Sub

    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        Application.Exit()
    End Sub

End Class