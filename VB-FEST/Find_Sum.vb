Module Find_Sum

    ' Create the SumOfTwo() Function and pass the parameters.  
    Function SumOfTwo(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        ' Define the local variable.  
        Dim sum As Integer = 0
        sum = n1 + n2
        Return sum
    End Function
    Function SubtractionOfTwo(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        ' Define the local variable.  
        Dim subtract As Integer
        subtract = n1 - n2
        Return subtract
    End Function
    Sub Main()
        ' Define the local variable a and b.  
        Dim a As Integer = 50
        Dim b As Integer = 20
        Dim total, total1 As Integer
        Console.WriteLine(" First Number is : {0}", a)
        Console.WriteLine(" Second Number is : {0}", b)
        total = SumOfTwo(a, b) 'call SumOfTwo() Function  
        total1 = SubtractionOfTwo(a, b) 'call SubtractionOfTwo() Function  
        Console.WriteLine(" Sum of two number is : {0}", total)
        Console.WriteLine(" Subtraction of two number is : {0}", total1)
        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
