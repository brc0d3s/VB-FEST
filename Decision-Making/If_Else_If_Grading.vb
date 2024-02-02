Module If_Else_If_Grading
    Sub Main
        Dim marks As Integer
        Dim grade As Char
        Console.WriteLine("Enter Your Marks : ")
        marks = Console.ReadLine() 
        
        While marks < 0 Or marks > 100
            Console.WriteLine("Invalid Re-enter Your Marks : ")
            marks = Console.ReadLine()
        End While

        If marks >= 70 And marks <= 100 Then
            grade = "A"c
        ElseIf marks >= 60 And marks <= 69 Then
            grade = "B"c
        ElseIf marks >= 50 And marks <= 59 Then
            grade = "C"c
        ElseIf marks >= 40 And marks <= 49 Then
            grade = "D"c
        ElseIf marks >= 0 And marks <= 39 Then
            grade = "F"c
        End If 

        Console.WriteLine("Your grade is : {0}", grade)
    End Sub
End Module
