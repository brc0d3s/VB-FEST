Public Module Keywords_as_Variable
    Public Class [Class]
        Public age As Integer
    End Class

    Sub Main()
        Dim p As [Class] = new [Class]()
        p.age = 10
        Console.WriteLine("Age : {0}",p.age)
    End Sub
End Module