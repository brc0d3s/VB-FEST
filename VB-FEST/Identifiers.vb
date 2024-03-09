Module Identifiers
    ' There are various rules For identifier In VB.NET, As follows:

    ' 1. The first character Of an identifier must start With an alphabet Or underscore, that could be followed by
    ' any sequence Of digits (0-9), letter Or underscore.
    ' 2. identifier should Not contain any reserved keyword.
    ' 3.It should Not start With any digit.
    ' 4. It should Not more than 51 characters.
    ' 5. An identifier can contain two underscores, but should Not be consecutive.
    ' 6. It should Not include any commas Or white spaces In-between characters.

    Public Sub myfunc()
        Console.WriteLine("Hello friends..")
    End Sub

    Sub Main()
        myfunc()
        Console.WriteLine("Nice to meet you...")
        Console.WriteLine("press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
