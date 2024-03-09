Module Operator_Precedence
    Sub Main()
        'Declare and Initialize p, q, r, s variables  
        Dim p As Integer = 30
        Dim q As Integer = 15
        Dim r As Integer = 10
        Dim s As Integer = 5
        Dim result As Integer

        Console.WriteLine("Check Operator Precedence in VB.NET")
        'Check Operator Precedence  
        result = (p + q) * r / s      '  45 * 10 / 5  
        Console.WriteLine("Output of (p + q) * r / s is : {0}", result)

        result = (p + q) * (r / s)   ' (45) * (10/5)  
        Console.WriteLine("Output of (p + q) * (r / s) is  : {0}", result)

        result = ((p + q) * r) / s    ' (45 * 10 ) / 5  
        Console.WriteLine("Output of ((p + q) * r) / s is  : {0}", result)

        result = p + (q * r) / s     '  30 + (150/5)  
        Console.WriteLine("Output of p + (q * r) / s is  : {0}", result)

        result = ((p + q * r) / s)     '  ((30 + 150) /5)  
        Console.WriteLine("Output of ((p + q * r) / s) is  : {0}", result)

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
