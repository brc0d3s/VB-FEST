Module For_Each_loop
    Sub main()
        Try
            Dim stachArray() As String = {"Python", "Java", "Javascript", "C", "VB.Net", "C#", "C++"}

            Console.WriteLine("My stack is :" & vbCrLf)
            For Each language In stachArray
                Console.WriteLine(language)
            Next
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message )
        End Try
    End Sub
End Module
