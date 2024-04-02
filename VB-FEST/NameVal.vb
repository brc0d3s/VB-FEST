Module NameVal
    Sub Main()
        'Defining an array NVCol As NameValueCollection  
        Dim NVCol As NameValueCollection = New NameValueCollection()
        Dim key As String
        'Use of Add() function  
        NVCol.Add("flower", "Rose")
        NVCol.Add("flower", "Lotus")
        NVCol.Add("flower", "Sunflower")
        NVCol.Add("planet", "Earth")
        NVCol.Add("planet", "Mars")
        NVCol.Add("planet", "Mercury")
        NVCol.Add("planet", "Jupiter")

        For Each key In NVCol
            Console.WriteLine("Key Name: {0} ", key)
            Console.WriteLine("Elements are: {0} ", NVCol.Get(key))
        Next
        Console.WriteLine()

        'Display the First Key  
        Console.WriteLine("Name of first Key is: {0}", NVCol.GetKey(1))

        'Display the First value of Key using the GetValues(key)  
        Console.WriteLine("Value of first Key is: {0}", NVCol.GetValues(0))

        Console.WriteLine(" Total keys in NameValueCollection {0}", NVCol.Count)
        Console.WriteLine()

        'Use of Remove() function  
        Console.WriteLine(" Remove key 'flower' from NameValueCollection ")
        NVCol.Remove("flower")
        For Each key In NVCol
            Console.WriteLine("Current Key Name: {0} ", key)
            Console.WriteLine("Current Key Elements are: {0} ", NVCol.Get(key))
        Next
        Console.WriteLine()

        Console.WriteLine(" Press any key to exit")
        Console.ReadKey()
    End Sub
End Module
