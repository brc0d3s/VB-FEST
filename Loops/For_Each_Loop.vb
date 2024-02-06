Module For_Each_loop  
    Sub Main()  
        'declare and initialize an array as integer  
        Dim An_array() As Integer = {1, 2, 3, 4, 5}  
        Dim i As Integer 'Declare i as Integer  
  
        For Each i In An_array  
            Console.WriteLine(" Value of i is {0}", i)  
        Next   
    End Sub  
End Module  