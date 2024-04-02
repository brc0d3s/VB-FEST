Module num_Array
    Sub Main()
        Dim i As Integer
        Dim marksArray(5) As Integer
        Dim sum As Integer

        marksArray = {45, 78, 36, 90, 52, 89}

        For i = 0 To marksArray.Length() - 1 Step 1
            Console.WriteLine(marksArray(i))
            sum += marksArray(i)
        Next

        Console.WriteLine("Sum: {0}", sum)
        Console.ReadKey()
    End Sub
End Module
