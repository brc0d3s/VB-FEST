Module Partial_Class
    Partial Public Class User

        Private name As String

        Private location As String

        Public Sub New(ByVal a As String, ByVal b As String)

            Me.name = a

            Me.location = b

        End Sub

    End Class

    Partial Public Class User

        Public Sub GetUserDetails()

            Console.WriteLine("Name: " & name)

            Console.WriteLine("Location: " & location)

        End Sub

    End Class

    Sub Main()

        Dim u As User = New User("Suresh Dasari", "Hyderabad")

        u.GetUserDetails()

    End Sub
End Module
