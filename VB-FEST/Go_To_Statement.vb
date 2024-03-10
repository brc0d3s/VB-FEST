Module Go_To_Statement
    Sub Main()
        'Declaration of local variable  
        Dim num As Integer
        Console.WriteLine(" Enter the number :")
        num = Console.ReadLine() ' Accept a number from the user  
        If (num Mod 2 = 0) Then
            GoTo even ' Jump to even label  
        Else
            GoTo odd   ' Jump to odd label  
        End If
        odd:
                Console.WriteLine(" It is an Odd number")

        even:
                Console.WriteLine(" It is an Even number ")

    End Sub
End Module
