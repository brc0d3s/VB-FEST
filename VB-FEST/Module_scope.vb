Module Module_scope
    'module-level variable declaration  
    Dim x As Integer
    Private y As Integer
    Private name As String = "JavaTpoint"
    Sub example()
        x = 10
        y = x + 10
        Console.WriteLine(" Value of Y is {0}", y)
    End Sub
    Sub example2()
        Console.WriteLine(" Value of X is {0}", x)
        Console.WriteLine(" Value of Y is {0}", y)
        Console.WriteLine(" Name is {0}", name)
    End Sub
    Sub example3()
        Dim A As Integer  ' local variable or local scope  
        A = x + y
        Console.WriteLine(" Local scope within a function of variable A {0}", A)
    End Sub
    Sub Main()
        Console.WriteLine(" Module scope of variable")
        example()
        example2()
        example3()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
