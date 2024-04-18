Module Copy_Constructor
    Class User

        Public name, location As String

        ' Parameterized Constructor

        Public Sub New(ByVal a As String, ByVal b As String)

            name = a

            location = b

        End Sub

        ' Copy Constructor

        Public Sub New(ByVal user As User)

            name = user.name

            location = user.location

        End Sub

    End Class

    Sub Main()

        ' User object with Parameterized constructor

        Dim user As User = New User("Dasari", "Kenya")

        ' Another User object (user1) by copying user details

        Dim user1 As User = New User(user)

        user1.name = "Rohini"

        user1.location = "Uganda"

        Console.WriteLine(user.name & ", " & user.location)

        Console.WriteLine(user1.name & ", " & user1.location)

    End Sub
End Module
