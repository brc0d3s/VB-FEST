Module For_Next_Loop_Multiplication_Table
    Sub Main()
        Dim i, num As Integer

        Console.WriteLine("Enter the number for its Multiplication table to be provided: ")
        num = Console.ReadLine()

        Console.WriteLine("The table for {0} :", num)
        For i = 1 To 10 Step 1
            Console.WriteLine(num & "*" & i & "=" & i * num)
        Next
    End Sub
End Module
