Public Class LstNumbers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNum.Click
        Dim intData(6) As Integer
        intData(0) = 12
        intData(1) = 198
        intData(2) = 209
        intData(4) = 8767
        intData(5) = 656
        intData(5) = 676

        For num = 0 To 6 Step 1
             lstNum.Items.Add(intData(num))
        Next


        lstNum.Items.Add(" ")
        lstNum.Items.Add(intData.Length)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intData(6) As Integer

        For num = 0 To 6 Step 1
            intData(num) = InputBox("Key in an integer number")
        Next

        For num = 0 To 6 Step 1
            lstNum.Items.Add(intData(num))
        Next

        lstNum.Items.Add(" ")
        lstNum.Items.Add(intData.Length)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intData(6) As Integer
        Dim num, newSize As Integer

        newSize = InputBox("How many values do you want to input?")
        ReDim intData(newSize)

        lstNum.Items.Add("Your array length is " & newSize + 1)

        For num = 0 To newSize
            intData(num) = InputBox("Key in an integer " & num + 1)

        Next

        For num = 0 To newSize
            lstNum.Items.Add(intData(num))
        Next
    End Sub
End Class