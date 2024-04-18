Module Default_Constructor
    Class User

        Public name, location As String

        ' Default Constructor

        Public Sub New()

            name = "brc0d3s"

            location = "Kenya"

        End Sub

    End Class

    Sub Main()

        ' The constructor will be called automatically once the instance of the class created

        Dim user As User = New User()

        Console.WriteLine(user.name)

        Console.WriteLine(user.location)

    End Sub
End Module
