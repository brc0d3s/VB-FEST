Module Continue_Statement
    Sub Main()
        'Declaration and initialization of variable i, num  
        Dim i As Integer = 10
        Dim num As Integer
        'Define the For Loop Condition  
        For i = 10 To 1 Step -1

            If i = 5 Then ' if i = 5, it skips the iteration   
                num = i 'Assign the skip value to num variable  
                Continue For ' Continue with Next Iteration  
            End If
            Console.WriteLine(" Value of i is {0}", i)

        Next
        Console.WriteLine(" Skipped number is {0}", num)

    End Sub
End Module
