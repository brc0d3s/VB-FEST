Module Encapsulation_VB
    Class Student
        Private regno As Integer
        Private name As String

        Public Sub DisplayData()
            Console.WriteLine($"RegNo: {regno}, Name: {name}")
        End Sub

        Public Property Sregno() As Integer
            Get
                Return regno
            End Get
            Set(ByVal value As Integer)
                regno = value
            End Set
        End Property

        Public Property Sname() As String
            Get
                Return name
            End Get
            Set(ByVal value As String)
                name = value
            End Set
        End Property
    End Class

    Sub Main()
        Dim s As Student = New Student()
        s.Sregno = 1045858
        s.Sname = "Brian"
        s.DisplayData()
    End Sub
End Module
