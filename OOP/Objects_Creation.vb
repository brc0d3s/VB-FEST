Module Objects_Creation

    Public Class Users
        Public Property Uname As String
        Public Property Uage As Integer

        Public Sub New(ByVal name As String, ByVal age As Integer)
            Uname = name
            Uage = age
        End Sub

        Public Sub getUserDetails()
            Console.WriteLine($"Name:{Uname}, Age:{Uage}")
        End Sub


    End Class


    Sub Main()
        Dim user As Users = New Users("brc0d3s", 21)
        user.getUserDetails()
    End Sub

End Module
