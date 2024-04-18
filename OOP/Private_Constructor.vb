Module Private_Constructor
    Class User
        ' Private Constructor

        Private Sub New()

            Console.WriteLine("I am Private Constructor")

        End Sub

        Public Shared name, location As String

        ' Default Constructor

        Public Sub New(ByVal a As String, ByVal b As String)

            name = a

            location = b

        End Sub

    End Class

    Sub Main()

        ' The following comment line will throw an error because constructor is inaccessible

        'Dim user As User = New User()



        ' Only Default constructor with parameters will invoke

        Dim user1 As User = New User("Suresh Dasari", "Hyderabad")

        Console.WriteLine(User.name & ", " & User.location)

    End Sub
End Module
