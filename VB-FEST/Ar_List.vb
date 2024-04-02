Module Ar_List
    Sub Main()
        Dim Lt As List(Of Integer) = New List(Of Integer)()
        Dim i As Integer
        'Dim j As String  
        Console.WriteLine(" Added elements in List1")
        ' Use of Add() function  
        Lt.Add(50)
        Lt.Add(55)
        Lt.Add(10)
        'Lt.Add(70)  

        Dim Lt2 As List(Of String) = New List(Of String)()
        Lt2.Add("Welcome")
        Lt2.Add("to")
        Lt2.Add("JavaTpoint")
        Lt2.Add("Site")

        'Access all element of List1  
        For Each i In Lt
            Console.WriteLine("{0}", i)
        Next i
        Console.WriteLine("Total elements in list1: {0}", Lt.Count)
        Console.WriteLine("Number of elements can be placed in list1: {0}", Lt.Capacity)
        Console.WriteLine()

        'Access all element of list2  
        Console.WriteLine(" Added elements in List2")
        For Each j In Lt2
            Console.WriteLine("{0}", j)
        Next j
        Console.WriteLine("Total elements in list2: {0}", Lt2.Count)
        Console.WriteLine("Number of elements can be placed in list2: {0}", Lt2.Capacity)
        Console.WriteLine()

        'Use Remove() function to delete an element  
        Console.WriteLine("The 'Site' Element to be removed from the List2", Lt2.Remove("Site"))
        'Retrieve using For Loop  
        For Each j In Lt2
            Console.WriteLine("{0}", j)
        Next j
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
