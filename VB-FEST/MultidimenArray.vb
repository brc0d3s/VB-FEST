Module MultidimenArray
    Sub Main()
        ' Definition of 2 Dimensional Array  
        Dim intArray(,) As Integer = {{5, 4}, {3, 2}, {4, 7}, {4, 5}}

        ' Definition of 3 Dimensional Array  
        Dim threeDimen(,,) As Integer =
            {{{1, 3, 2}, {2, 3, 4}},
            {{5, 3, 6}, {3, 4, 5}},
        {{1, 2, 2}, {5, 2, 3}}}

        Console.WriteLine(" Two Dimensional Arraye in VB.NET are")
        For i As Integer = 0 To 3
            For j As Integer = 0 To 1
                Console.WriteLine("intArray[{0}, {1}] = {2}", i, j, intArray(i, j))
            Next j
        Next i

        Console.WriteLine(" Three Dimensional Arraye in VB.NET are")
        For i As Integer = 0 To 2 - 1
            For j As Integer = 0 To 2 - 1
                For k As Integer = 0 To 4
                    Console.WriteLine("intArray[{0}, {1}, {2}] = {3}", i, j, k, threeDimen(i, j, k))
                Next k
            Next j
        Next i

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
