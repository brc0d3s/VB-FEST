Public Class BMI
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim weight As Double
        Dim height As Double

        If Double.TryParse(txtWeight.Text, weight) AndAlso Double.TryParse(txtHeight.Text, height) Then
            CalculateBMI(weight, height)
        Else
            MessageBox.Show("Please enter valid numeric values for weight and height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub CalculateBMI(ByVal weight As Double, ByVal height As Double)
        Dim bmi As Double = weight / (height * height)
        txtBMI.Text = "Your BMI: " & bmi.ToString("F2")

        If bmi < 18.5 Then
            txtBMI.Text = "You are underweight."
        ElseIf bmi >= 18.5 AndAlso bmi < 25 Then
            txtBMI.Text = "You are normal weight."
        ElseIf bmi >= 25 AndAlso bmi < 30 Then
            txtBMI.Text = "You are overweight."
        Else
            txtBMI.Text = "You are obese."
        End If
    End Sub

End Class