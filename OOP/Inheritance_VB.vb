Module Inheritance_VB
    Class Person
        Protected name As String
        Protected age As Integer

        Public Overridable Sub GetData()
            Console.Write("Enter Name: ")
            name = Console.ReadLine()

            Console.Write("Enter Your Age: ")
            age = (Console.ReadLine())
        End Sub
    End Class

    Class Student
        Inherits Person

        Private regNo As String
        Private faculty As String
        Private department As String

        Public Overrides Sub GetData()
            MyBase.GetData() ' Call base class method to get name and age

            Console.Write("Enter Your RegNo: ")
            regNo = Console.ReadLine()

            Console.Write("Enter Your Faculty: ")
            faculty = Console.ReadLine()

            Console.Write("Enter Your Department: ")
            department = Console.ReadLine()
        End Sub

        Public Sub DisplayData()
            Console.WriteLine($"Name: {name}")
            Console.WriteLine($"Age: {age}")
            Console.WriteLine($"RegNo: {regNo}")
            Console.WriteLine($"Faculty: {faculty}")
            Console.WriteLine($"Department: {department}")
        End Sub
    End Class

    Class Program
        Public Shared Sub Main()
            Dim stud As New Student()
            stud.GetData()
            stud.DisplayData()
        End Sub
    End Class
End Module
