Module Parameterized_Constructor
    Class User

        Public name, location As String

        ' Parameterized Constructor

        Public Sub New(ByVal a As String, ByVal b As String)

            name = a

            location = b

        End Sub

    End Class

    Sub Main()

        ' The constructor will be called automatically once the instance of the class created

        Dim user As User = New User("Suresh Dasari", "Hyderabad")

        Console.WriteLine(user.name)

        Console.WriteLine(user.location)
    End Sub
End Module
