﻿Module Misc_Operator
    Sub Main()
        ' Initialize a variable  
        Dim a As Integer = 50
        ' GetType of the Defined Type  
        Console.WriteLine(GetType(Double).ToString())
        Console.WriteLine(GetType(Integer).ToString())
        Console.WriteLine(GetType(String).ToString())
        Console.WriteLine(GetType(Single).ToString())
        Console.WriteLine(GetType(Decimal).ToString())

        'Use of Function()   
        Dim multiplywith10 = Function(sum As Integer) sum * 10
        Console.WriteLine(multiplywith10(10))
        Console.WriteLine(If(a >= 0, "Negative", "Positive"))

        Console.WriteLine(" Press any key to exit...")
        Console.ReadLine()

    End Sub
End Module
