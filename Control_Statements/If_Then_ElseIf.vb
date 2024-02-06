Module If_Then_ElseIf
    Sub Main()  
        Dim var1 As Integer  
  
        Console.WriteLine(" Input the value of var1: ")  
        var1 = Console.ReadLine()  
        If var1 = 20 Then    
            Console.WriteLine(" Entered value is equal to 20")  
        ElseIf var1 < 50 Then  
            Console.WriteLine(" Entered value is less than 50")           
         ElseIf var1 >= 100 Then  
            Console.WriteLine(" Entered value is greater than 100")  
        Else    
            Console.WriteLine(" Value is not matched with above condition")  
        End If 

        Console.WriteLine(" You have entered : {0}", var1) 

        End Sub
End Module