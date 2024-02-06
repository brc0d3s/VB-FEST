Module Do_loop_Until
    Sub Main()
        Dim val As Integer = 10

        Do 
            Console.WriteLine("{0}",val)
            val += 1

        Loop While val<=50
    End Sub
End Module