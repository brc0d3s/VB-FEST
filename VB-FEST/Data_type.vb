Module Data_type
    Sub Main()
        ' defining the Data Type to the variables  
        Dim b As Byte = 1
        Dim num As Integer = 5
        Dim si As Single
        Dim db As Double
        Dim get_date As Date
        Dim c As Char
        Dim str As String

        b = 1
        num = 20
        si = 0.12
        db = 2131.787
        get_date = Today
        c = "A"
        str = "Hello Friends..."

        Console.WriteLine("Welcome to the JavaTpoint")
        Console.WriteLine("Byte is: {0}", b)
        Console.WriteLine("Integer number is: {0}", num)
        Console.WriteLine("Single data type is: {0}", si)
        Console.WriteLine("Double data type is: {0}", db)
        Console.WriteLine("Today is: {0}", get_date)
        Console.WriteLine("Character is: {0}", b)
        Console.WriteLine("String message is: {0}", str)
        Console.ReadKey()
    End Sub
End Module
