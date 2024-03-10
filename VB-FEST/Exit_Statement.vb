Module Exit_Statement
    Sub Main()
        'Definition of num variable  
        Dim num As Integer
        Dim sum As Double = 0.0

        'Execution of For loop  
        For i As Integer = 1 To 10 Step 2
            'Accept a number from the user  
            Console.WriteLine("Enter a number : ")
            num = Console.ReadLine()
            ' If the user enters a negative number, the loop terminates  
            If num < 0 Then
                Exit For ' terminate the For loop   
            End If
            sum += num
        Next

        Console.WriteLine(" Exit from the For loop when (num < 0) is: {0}", num)
        Console.WriteLine(" Total sum is : {0}", sum)

    End Sub
End Module
