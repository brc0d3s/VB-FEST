Module String_cmp
    Sub Main()
        'Definition of local String variable  
        Dim Str1 As String = "Hello"
        Dim Str2 As String = "Cello"
        ' Use of String.compare() function  
        Console.WriteLine(" Comparison of String {0} and {1} result is {2}", Str1, Str2, String.Compare(Str1, Str2))

        Dim Sdata As String = " WELCOME"
        Dim Sdata2 As String = " Welcome"
        ' Use of String.Compare() function  
        Console.WriteLine(" Comparison result of String {0} and {1} result is {2}", Sdata, Sdata2, String.Compare(Sdata, Sdata2))

        Dim Sdata3 As String = "Hello"
        Dim Sdata4 As String = "Hello"
        ' Use of String.Compare() function  
        Console.WriteLine(" Comparison result of String {0} and {1} result is {2}", Sdata3, Sdata4, String.Compare(Sdata3, Sdata4))

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module