Module Get_Chars
    Sub Main()
        Dim name As String = "Brian Omondi"
        Dim i As Integer

        For i = 0 To name.Length() - 1 Step 1
            Console.WriteLine(name(i))
        Next

        Console.WriteLine(name.Length())

        Console.ReadKey()
    End Sub
End Module
