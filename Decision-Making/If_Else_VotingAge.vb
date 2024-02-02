Module If_Else_VotingAge
    Sub Main()
        Dim age As Integer
        Console.WriteLine("Enter Your Age: ")
        age = Console.ReadLine()

        If age >= 18 Then
            Console.WriteLine("You are an Eligible Voter!")
        Else
            Console.WriteLine("Underage!")
        End If
    End Sub
End Module