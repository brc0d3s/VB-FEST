Module Dynamic_Arr
    Sub Main()
        'Declaration and Initialization of String Array Days()  
        Dim Days() As String
        ' Resize an Array using the ReDim Statement  
        ReDim Days(2)
        Days(0) = "Sunday"
        Days(1) = "Monday"
        Days(2) = "Tuesday"
        Console.WriteLine(" Before Preserving the Elements")
        For i As Integer = 0 To Days.Length - 1
            Console.WriteLine("Days Name in [{0}] index is {1}", i, Days(i))
        Next
        Console.WriteLine()

        Console.WriteLine(" After Preserving 0 to 2 index Elements")
        ReDim Preserve Days(6)
        Days(3) = "Wednesday"
        Days(4) = "Thursday"
        Days(5) = "Friday"
        Days(6) = "Saturday"
        For i As Integer = 0 To Days.Length - 1
            Console.WriteLine("Days Name in [{0}] index is {1}", i, Days(i))
        Next
        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
