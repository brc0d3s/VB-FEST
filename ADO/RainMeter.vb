Public Class RainMeter
    ' Declare the array to store rainfall amounts as a class-level variable
    Private rainAmounts(11) As Double

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Loop through each month and prompt user to enter rainfall amount
        For i = 0 To 11
            rainAmounts(i) = CDbl(InputBox("Enter the amount of rainfall for month " & (i + 1)))
        Next
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        ' Calculate total rainfall
        Dim totalRainfall As Double = 0
        For Each amount In rainAmounts
            totalRainfall += amount
        Next

        txtTotal.Text = totalRainfall.ToString()
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        ' Calculate average rainfall
        Dim totalRainfall As Double = 0
        For Each amount In rainAmounts
            totalRainfall += amount
        Next

        Dim averageRainfall As Double = totalRainfall / 12
        txtAverage.Text = averageRainfall.ToString()
    End Sub


    ' Helper function to calculate standard deviation
    Private Function CalculateStandardDeviation(ByVal values() As Double) As Double
        Dim sum As Double = 0
        Dim mean As Double
        For Each value As Double In values
            sum += value
        Next
        mean = sum / values.Length
        sum = 0
        For Each value As Double In values
            sum += (value - mean) ^ 2
        Next
        Return Math.Sqrt(sum / values.Length)
    End Function
    Private Sub btnDeviation_Click(sender As Object, e As EventArgs) Handles btnDeviation.Click
        ' Calculate standard deviation of rainfall
        Dim deviation As Double = CalculateStandardDeviation(rainAmounts)
        txtDeviation.Text = deviation.ToString()
    End Sub


    ' Helper function to calculate mode
    Private Function CalculateMode(ByVal values() As Double) As Double
        Dim mode As Double
        Dim countDictionary As New Dictionary(Of Double, Integer)

        For Each value In values
            If countDictionary.ContainsKey(value) Then
                countDictionary(value) += 1
            Else
                countDictionary.Add(value, 1)
            End If
        Next

        Dim maxCount As Integer = countDictionary.Values.Max()

        For Each pair In countDictionary
            If pair.Value = maxCount Then
                mode = pair.Key
            End If
        Next

        Return mode
    End Function

    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        ' Calculate mode of rainfall
        Dim mode As Double = CalculateMode(rainAmounts)
        txtMode.Text = mode.ToString()
    End Sub



    ' Helper function to calculate median
    Private Function CalculateMedian(ByVal values() As Double) As Double
        Array.Sort(values)
        Dim n As Integer = values.Length
        If n Mod 2 = 0 Then
            Return (values(n \ 2 - 1) + values(n \ 2)) / 2
        Else
            Return values(n \ 2)
        End If
    End Function

    Private Sub btnMedian_Click(sender As Object, e As EventArgs) Handles btnMedian.Click
        ' Calculate median of rainfall
        Dim median As Double = CalculateMedian(rainAmounts)
        txtMedian.Text = median.ToString()
    End Sub

    Private Sub btnHighest_Click(sender As Object, e As EventArgs) Handles btnHighest.Click
        ' Find highest rainfall amount
        Dim highest As Double = rainAmounts.Max()
        txtHighest.Text = highest.ToString()
    End Sub

    Private Sub btnLowest_Click(sender As Object, e As EventArgs) Handles btnLowest.Click
        ' Find lowest rainfall amount
        Dim lowest As Double = rainAmounts.Min()
        txtLowest.Text = lowest.ToString()
    End Sub

End Class
