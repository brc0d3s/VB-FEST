Module Const1
    Const PI As Double = 3.14
    Dim radius,height As Double

    Sub userInputs()
        Console.WriteLine("Enter Radius: ")
        radius = Console.ReadLine()
        Console.WriteLine("Enter Height: ")
        height = Console.ReadLine()
    End Sub

    Function calculateVolume() As Double
        Return PI * (radius * radius) * height
    End Function

    Sub display()
        Console.WriteLine("Radius: {0}",radius)
        Console.WriteLine("Height: {0}",height)
        Console.WriteLine("Volume: {0}",calculateVolume())
    End Sub

    Sub Main()
        userInputs()
        display()
    End Sub
End Module