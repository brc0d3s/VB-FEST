Module With_Statement
    Public Class Student
        Public stud_name As String 'Define the variable of a class  
        Public stud_course As String
        Public stud_rollno As Integer
    End Class

    Sub Main()
        Dim stud As Student = New Student()

        ' To define the member of an object using With Statement  
        With stud
            .stud_name = " Mr. Robert"
            .stud_course = "Computer Science"
            .stud_rollno = "01"
        End With


        With stud
            ' use stud as a reference  
            Console.WriteLine(" Student Name is : {0}", .stud_name)
            Console.WriteLine(" Student Course Name is : {0}", .stud_course)
            Console.WriteLine(" Student RollNo. is : {0}", .stud_rollno)
        End With
    End Sub
End Module
