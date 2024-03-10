Module For_Next_Loop_Pattern
    Sub Main()
        Dim i, n, j As Integer
        Console.WriteLine(" Enter a number to show rows in a Pattern")
        ' take a number from user  
        n = Console.ReadLine()

        'Outer loop  
        For i = 1 To n
            'Inner loop  
            'value of j should be less than i  
            For j = 1 To i
                Console.Write(" * ")
            Next
            Console.WriteLine("")
        Next

    End Sub
End Module
