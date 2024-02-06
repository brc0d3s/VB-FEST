Module Select_case
     Sub Main()  
        'define a local variable.   
        Dim Days As String  
        Days = "Thurs"  
        Select Case Days  
            Case "Mon"  
                Console.WriteLine(" Today is Monday")  
            Case "Tue"  
                Console.WriteLine(" Today is Tuesday")  
            Case "Wed"  
                Console.WriteLine("Today is Wednesday")  
            Case "Thurs"  
                Console.WriteLine("Today is Thursday")  
            Case "Fri"  
                Console.WriteLine("Today is Friday")  
            Case "Sat"  
                Console.WriteLine("Today is Saturday")  
            Case "Sun"  
                Console.WriteLine("Today is Sunday")  
            Case Else  
                Console.WriteLine(" You have typed Something wrong")  
  
        End Select  
        Console.WriteLine("You have selected : {0}", Days)   
    End Sub  
End Module