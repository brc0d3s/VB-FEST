Module If_Then_ElseIf_statement
    ' CUEA grading system

    Dim marks As Integer
    Dim grade As Char

    Sub main()
        Console.WriteLine("Enter your marks : ")
        marks = Console.ReadLine()

        If 100 >= marks AndAlso marks >= 70 Then
            grade = "A"
        ElseIf 69 >= marks AndAlso marks >= 60 Then
            grade = "B"
        ElseIf 59 >= marks AndAlso marks >= 50 Then
            grade = "C"
        ElseIf 49 >= marks AndAlso marks >= 40 Then
            grade = "D"
        ElseIf 39 >= marks  AndAlso marks >= 0 Then
            grade = "B"
        Else
            Console.WriteLine("INVALID")
        End If

        Console.WriteLine("Your Grade is : {0}", grade)
    End Sub
End Module
