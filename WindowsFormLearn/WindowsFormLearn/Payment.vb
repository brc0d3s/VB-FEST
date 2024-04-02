Public Class Payment
    Const MonthsInYear As Integer = 12 ' Constant for the number of months in a year

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 30 Step 0.5
            lstRate.Items.Add(i.ToString("F1"))
        Next
    End Sub

    Function calculatePayment() As String ' Change return type to String
        Dim principalAmount As Double
        Dim selectedRate As Double
        Dim monthlyPayment As Double

        'M = P [ I(1 + I)N ] / [ (1 + I)N − 1]

        'M = Monthly payment: This Is what you're solving for.
        'P = principal amount: This Is the loan balance, Or what you're trying to pay off.
        'I = Interest rate: Remember, you'll want to use the base interest rate and not the APR. Additionally, because the mortgage interest rate you’re charged is an annual interest rate that represents the interest that’s supposed to be paid over the whole year, you want to divide this by 12 to get the monthly interest rate.
        '
        'N = Number Of payments: This Is the total number Of payments In your loan term. For instance, If it's a 30-year mortgage with monthly payments, there are 360 payments.


        ' Attempt to parse principal amount from the text box
        If Not Double.TryParse(txtPrincipal.Text, principalAmount) Then
            MessageBox.Show("Invalid principal amount. Please enter a valid number.")
            Return "" ' Return empty string in case of error
        End If

        ' Attempt to get the selected rate from the list box
        If lstRate.SelectedIndex = -1 Then
            MessageBox.Show("Please select an interest rate.")
            Return "" ' Return empty string in case of error
        Else
            selectedRate = Convert.ToDouble(lstRate.SelectedItem)
        End If

        ' Calculate monthly interest rate
        Dim monthlyInterestRate As Double = selectedRate / 100 / MonthsInYear ' Use constant for months in a year

        ' Number of payments
        Dim numberOfPayments As Integer = 0

        ' Calculate monthly payments for 15, 20, 25, and 30 years
        Dim terms As Integer() = {15, 20, 25, 30}
        Dim output As String = ""

        For Each term In terms
            numberOfPayments = term * MonthsInYear ' Convert years to months
            monthlyPayment = principalAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments) / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1)
            output &= $"{term} years:    ${monthlyPayment.ToString("F2")}{vbNewLine}{vbNewLine}"
        Next


        Return output
    End Function

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        ' Display the monthly payments in the txtPayment textbox
        txtPayment.Text = calculatePayment()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
