Module Select_Case_Statement
    Sub Main()
        'Number of the month

        Dim monthNo As Integer
        Dim month As String = ""

        Console.WriteLine("Enter Month Number: ")
        monthNo = Console.ReadLine

        Select Case monthNo
            Case 1
                month = "January"
            Case 2
                month = "February"
            Case 3
                month = "March"
            Case 4
                month = "April"
            Case 5
                month = "May"
            Case 6
                month = "June"
            Case 7
                month = "July"
            Case 8
                month = "August"
            Case 9
                month = "September"
            Case 10
                month = "October"
            Case 11
                month = "November"
            Case 12
                month = "December"
            Case Else
                Console.WriteLine("INVALID")

        End Select

        Console.WriteLine("Month number {0} is {1}", monthNo, month)
    End Sub
End Module
