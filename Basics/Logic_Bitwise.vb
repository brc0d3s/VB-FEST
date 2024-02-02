Module  Logic_Bitwise
    Sub Main()
        Dim A As Boolean = True  
        Dim B As Boolean = False  
        Dim c, d As Integer  
        c = 10  
        d = 20  
  
        'Use of And Operator  
        If A And B Then  
            Console.WriteLine(" Operands A And B are True")  
        End If  
  
        'Use of Or Operator  
        If A Or B Then  
            Console.WriteLine(" Operands A Or B are True")  
        End If  
  
        'Use of Xor Operator  
        If A Xor B Then  
            Console.WriteLine(" Operands A Xor B is True")  
        End If  
  
        'Use of And Operator  
        If c And d Then  
            Console.WriteLine(" Operands c And d is True")  
        End If  
  
        'Use of Or Operator  
        If c Or d Then  
            Console.WriteLine(" Operands c Or d is True")  
        End If  
  
        'Use of AndAlso Operator  
        If A AndAlso B Then  
            Console.WriteLine(" Operand A AndAlso B is True")  
        End If  
  
        'Use of OrElse Operator  
        If A OrElse B Then  
            Console.WriteLine(" Operand A OrElse B is True")  
        End If  
  
        'Use of Not Operator  
        If Not (A And B) Then  
            Console.WriteLine(" Output of Not (A And B) is True")  
        End If  
    End Sub
End Module