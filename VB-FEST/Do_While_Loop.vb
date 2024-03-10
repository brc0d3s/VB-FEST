Module Do_While_Loop
    Sub Main()
        ' Initialization and Declaration of variable i  
        Dim i As Integer = 1

        Do
            ' Executes the following Statement  
            Console.WriteLine(" Value of variable I is : {0}", i)
            i = i + 1 'Increment the variable i by 1  
        Loop While i <= 10 ' Define the While Condition  

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
