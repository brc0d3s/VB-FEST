Module Protected_Access_Modifier
    Class Student
        Protected studNo As Integer
        Protected stdName As String
        Protected fucalty As String
        Protected department As String

        Protected Sub getData()
            Console.WriteLine($"Reg No: {studNo}")
            Console.WriteLine($"Name: {stdName}")
            Console.WriteLine($"Fucalty: {fucalty}")
            Console.WriteLine($"Department: {department}")
        End Sub
    End Class


    Class stud
        Inherits Student

        Public Shared Sub Main()
            ' Dim st As Student = New Student()
            Dim sd As stud = New stud()

            ' Complier Error

            ' protected members can only accessible with derived classes

            ' u.studNo = 1045858


            sd.studNo = 1045858
            sd.stdName = "Brian"
            sd.fucalty = "Science"
            sd.department = "Comp And Info Science"
            sd.getData()

        End Sub
    End Class

End Module
