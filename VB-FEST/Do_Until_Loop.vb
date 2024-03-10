Module Do_Until_Loop
    Sub Main()
        ' Initialization and Declaration of variable i  
        Dim i As Integer = 1

        Do
            ' Executes the following Statement  
            Console.WriteLine(" Value of variable i is : {0}", i)
            i = i + 1 'Increment variable i by 1
            '
        Loop Until i = 10 ' Define the Until Condition  

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
