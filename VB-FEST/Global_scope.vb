Module Global_scope
    'Global declaration of a variable  
    Public str As String = "Hello, Programmer."
    Public topic As String
    Public exp As Integer

    Sub Main()
        Console.WriteLine(" You have passed {0}", str)
        Console.WriteLine(" Enter the topic name")
        topic = Console.ReadLine
        Console.WriteLine(" Topic Name :{0}", topic)
        Console.WriteLine("How many years of experienced in {0}?", topic)
        exp = Console.ReadLine
        Console.WriteLine(" Your Experienced is {0} ", exp)
        Console.ReadKey()
    End Sub
End Module
