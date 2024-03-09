Module Variables
    Sub Main()
        'declaration of intData as Integer  
        Dim intData As Integer
        'declaration of charData as Char  
        Dim CharData As Char
        'declaration of strData as String  
        Dim strData As String
        'declaration of dblData as Double  
        Dim dblData As Double
        'declaration of single_data as Single  
        Dim single_data As Single
        'Initialization of intData  
        intData = 10
        'Initialization of CharData  
        CharData = "A"
        'Initialization of strData  
        strData = " VB.NET is a Programming Language."
        dblData = 4567.676
        'Initialization of dblData  
        'Initialization of single_data  
        single_data = 23.08

        Console.WriteLine(" Value of intData is: {0}", intData)
        Console.WriteLine(" Value of CharData is: {0}", CharData)
        Console.WriteLine(" Value of strData is: {0}", strData)
        Console.WriteLine(" Value of dblData is: {0}", dblData)
        Console.WriteLine(" Value of single_data is: {0}", single_data)

        Console.WriteLine("press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
