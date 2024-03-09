Module Assign_Operator
    Sub Main()
        'Declare variable and b As Integer  
        Dim A As Integer = 5
        Dim B As Integer
        Dim Str, name As String
        name = "come"
        Str = "Wel"

        'Use of = Operator  
        B = A
        Console.WriteLine(" Assign value A to B is {0}", B)

        'Use of += Operator  
        B += A
        Console.WriteLine(" Output of B += A is {0}", B)

        'Use of -= Operator  
        B -= A
        Console.WriteLine(" Output of B -= A is {0}", B)

        'Use of *= Operator  
        B *= A
        Console.WriteLine(" Output of B *= A is {0}", B)

        'Use of /= Operator  
        B /= A
        Console.WriteLine(" Output of B /= A is {0}", B)

        'Use of = Operator  
        B \= A
        Console.WriteLine(" Output of B \= A is {0}", B)

        'Use of ^= Operator  
        B ^= A
        Console.WriteLine(" Output of B ^= A is {0}", B)

        'Use of &= Operator  
        Str &= name
        Console.WriteLine(" Output of Str &= name is {0}", Str)

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
