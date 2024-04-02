Module Input_array
    Sub Main()
        Dim marksArray(5) As Integer
        Dim i As Integer


        For i = 0 To marksArray.Length() - 1 Step 1
            Console.WriteLine("Enter number {0}", i + 1)
            marksArray(i) = Console.ReadLine()
        Next


        Console.WriteLine("The Values are : ")
        For i = 0 To marksArray.Length() - 1 Step 1
            Console.WriteLine(marksArray(i))
        Next
    End Sub
End Module
