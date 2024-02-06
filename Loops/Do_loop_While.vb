Module Do_loop
    Sub Main()
        Dim val As Integer = 10

        Do 
            Console.WriteLine("{0}",val)
            val += 1

        Loop While val<=100
    End Sub
End Module