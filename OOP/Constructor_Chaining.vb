Module Constructor_Chaining
    Class User

        Public Sub New()

            Console.Write("Hi, ")

        End Sub

        Public Sub New(ByVal a As String)

            Me.New()

            Console.Write(a)

        End Sub

        Public Sub New(ByVal a As String, ByVal b As String)

            Me.New("welcome")

            Console.Write(a & " " & b)

        End Sub

    End Class

    Sub Main()

        Dim user1 As User = New User(" to", "tutlane")

        Console.WriteLine()

    End Sub
End Module
