Module Constants
    Sub main()
        'declaration and initialization of Constant variable using Const keywords  
        Const intData As Integer = 20
        Const name As String = "JavaTpoint"
        Const topic As String = "VB.NET"
        Const PI = 3.14
        Dim radius, area As Integer

        Console.WriteLine(" Constant integer is {0}", intData)
        Console.WriteLine(" You have entered {0}", name)
        Console.WriteLine(" Your Topic is {0}", topic)
        Console.WriteLine("Enter the Radius")
        radius = Console.ReadLine()
        area = PI * radius * radius
        Console.WriteLine(" Area of Circle is {0}", area)
        Console.ReadKey()

    End Sub
End Module
