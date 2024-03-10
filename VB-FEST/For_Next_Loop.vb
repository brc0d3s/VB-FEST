Module For_Next_Loop
    Sub Main()
        ' It is a simple print statement, and 'vbCrLf' is used to jump in the next line.  
        Console.Write(" The number starts from 1 to 10 " & vbCrLf)

        ' declare and initialize variable i  
        For i As Integer = 1 To 10 Step 1
            ' if the condition is true, the following statement will be executed  
            Console.WriteLine(" Number is {0} ", i)
            ' after completion of each iteration, next will update the variable counter  
        Next
        Console.WriteLine(" Press any key to exit... ")
        Console.ReadKey()
    End Sub
End Module
