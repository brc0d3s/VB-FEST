Module Destructor_Example
    Class User

        Public Sub New()

            Console.WriteLine("An Instance of class created")

        End Sub

        Protected Overrides Sub Finalize()

            Console.WriteLine("An Instance of class destroyed")

        End Sub

    End Class

    Public Sub Details()

        Dim user As User = New User()

    End Sub

    Sub Main()

        Details()

        GC.Collect()

    End Sub

End Module
