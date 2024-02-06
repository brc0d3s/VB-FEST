Imports System

Module Local_Scope
    Sub Main()
        local_int()
        local_string()
    End Sub

    Sub local_int()
        Dim x As Integer
        x = 40
        Console.WriteLine("{0} is a local integer", x)
    End Sub

    Sub local_string()
        Dim y As String 
        y = "brc0d3s"
        Console.WriteLine("{0} is a local string", y)
    End Sub
End Module
