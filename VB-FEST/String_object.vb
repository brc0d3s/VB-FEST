Module String_object
    Sub Main()
        Dim firstName, lastName, fullName, data As String

        firstName = "Cypher"
        lastName = "wie=ne"
        'using string concatenation
        fullName = firstName + " " + lastName

        Console.WriteLine(" Message is {0}", firstName)
        Console.WriteLine(" Message is {0}", lastName)
        Console.WriteLine(" Fullname is {0}", fullName)

        ' By using string constructor  
        Dim str3 As Char() = {"H", "e", "l", "l", "o"}
        data = New String(str3)

        Console.WriteLine(" Your message is {0}", data)

        ' Use of returning string  
        Dim arr() As String = {" Hello", "Welcome", "to", "JavaTpoint"}
        Dim msg As String = String.Join(" ", arr)
        Console.WriteLine(" You have defined these parameters as string array {0}", msg)

        'Use of Formatting method to convert a value to the string  
        Dim time As DateTime = New Date(2020, 6, 18, 18, 48, 2)
        Dim sentmsg As String = String.Format(" Your message has been successfully sent at {0:t} on {0:D}", time)
        Console.WriteLine(" Your text is that {0}", sentmsg)

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub

End Module
