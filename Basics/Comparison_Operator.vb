Module Comparison_Operator
    Sub Main()
         'declaration of Integer, Object and String Data Type variables  
        Dim x As Integer = 5  
        Dim y As Integer = 10  
        Dim Result, obj, obj2 As Object  
        Dim str, str2 As String  
        str = "Apple12345"  
        str2 = "Apple12345"  
        obj = 10  
        obj2 = 20  
  
        Console.WriteLine(" Program of Comparison Operator")  
        'Use of > Operator  
        Console.WriteLine(" Output of x > y is {0}", x > y)  
  
        'Use of < Operator  
        Console.WriteLine(" Output of x < y is {0}", x < y)  
  
        'Use of = Operator  
        Console.WriteLine(" Output of x = y is {0}", x = y)  
  
        'Use of <> Operator  
        Console.WriteLine(" Output of x <> y is {0}", x <> y)  
  
        'Use of >= Operator  
        Console.WriteLine(" Output of x >= y is {0}", x >= y)  
  
        'Use of <= Operator  
        Console.WriteLine(" Output of x <= y is {0}", x <= y)  
  
        'Use of Is Operator  
        Result = obj Is obj2  
        Console.WriteLine(" Output of obj Is obj2 is {0}", Result)  
  
        'Use of Is Operator  
        Result = obj IsNot obj2  
        Console.WriteLine(" Output of obj IsNot obj2 is {0}", Result)  
  
        'Use of Like Operator  
        Result = str Like str2  
        Console.WriteLine(" Output of str Like str2 is {0}", Result)  
    End Sub
End Module