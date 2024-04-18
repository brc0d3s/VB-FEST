Module Constructor_Overloading
    Public Class Students
        Public Sno As Integer
        Public Sname As String

        Sub New()
            Sno = 1045858
            Sname = "Brian"
        End Sub

        Sub New(ByVal no As Integer, ByVal name As String)
            Sno = no
            Sname = name
        End Sub

        Public Sub getDetails()
            Console.WriteLine($"Student No:{Sno}, Name:{Sname}")
        End Sub

    End Class

    Sub Main()

        Dim stud As Students = New Students()
        Dim stud1 As Students = New Students(1045121, "lucky")

        stud.getDetails()
        stud1.getDetails()


    End Sub
End Module
