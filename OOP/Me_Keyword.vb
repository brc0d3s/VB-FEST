Module Me_Keyword
    Class User

        Public name, location As String

        Public marks As Long = 470

        Public Sub New(ByVal name As String, ByVal location As String)

            ' Use Me to distinguish between parameters and variables

            Me.name = name

            Me.location = location

        End Sub

        Public Sub GetUserDetails()

            Console.WriteLine("Name: {0}", name)

            Console.WriteLine("Location: {0}", location)

            ' Passing a class instance to the method using this

            Console.WriteLine("Marks: {0}", Exams.GetPercentage(Me))

        End Sub

    End Class

    Class Exams

        Public Shared Function GetPercentage(ByVal u As User) As Double

            Dim i As Double = ((470) / 600) * 100

            Return (Math.Round(i, 2))

        End Function

    End Class

    Sub Main()

        Dim u As User = New User("Suresh Dasari", "Hyderabad")

        u.GetUserDetails()

    End Sub
End Module
