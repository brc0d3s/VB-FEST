Module Local_Scope
    Sub Main()
        Console.WriteLine(" Scope of local varibale within a function")
        local() ' call local() and local() function without any object reference  
        local2()
        Console.WriteLine("press any key to exit...")
        Console.ReadKey()
    End Sub
    Sub local()
        Dim X As Integer
        ' declaration of local variable  
        X = 50
        Console.WriteLine(" Value of Local value X is {0}", X)

    End Sub
    Sub local2()
        Dim X As String
        ' scope of local variable within a function  
        X = "JavaTpoint"
        Console.WriteLine(" Value of X is {0}", X)
    End Sub
End Module
