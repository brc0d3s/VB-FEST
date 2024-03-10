Module If_Then_Else_Statement
    Sub Main()
        Dim num As Integer
        Console.WriteLine("Enter the Number")
        num = Console.ReadLine() 'read data from console  

        If (num Mod 2 = 0) Then ' if condition is true, print the if statement  
            Console.WriteLine("It is an even number")

        Else 'otherwise, Else statement is executed.  
            Console.WriteLine("It is an odd number")
        End If

        Console.WriteLine("press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
