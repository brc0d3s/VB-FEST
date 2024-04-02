Module AList
    Sub Main()
        Dim arrList As ArrayList = New ArrayList()
        Dim i As Integer
        Console.WriteLine(" Added elements in the ArrayList")

        ' Use of Add() function  
        arrList.Add(50)
        arrList.Add(55)
        arrList.Add(10)
        arrList.Add(70)
        arrList.Add(10)
        arrList.Add(40)
        arrList.Add(13)
        For Each i In arrList
            Console.WriteLine("{0}", i)
        Next i
        Console.WriteLine()


        'Use of Count to count the total elements in the ArrayList  
        Console.WriteLine(" Total Elements = {0}", arrList.Count)

        'Use of Capacity to check the element can be contained in ArrayList  
        Console.WriteLine(" Capacity of the ArrayList = {0}", arrList.Capacity)

        Console.WriteLine("Sorted Elements in ArrayList:")
        arrList.Sort()  ' Use of Sort() function  

        For Each i In arrList
            Console.WriteLine(" {0} ", i)
        Next i

        ' Use of Remove() Function  
        Console.WriteLine(" Remove 13 from the ArrayList")
        arrList.Remove(13)
        For Each i In arrList
            Console.WriteLine(" {0} ", i)
        Next i

        ' Use of RemoveAt() Function  
        Console.WriteLine(" Remove an item from a specified position [3]")
        arrList.RemoveAt(3)
        Console.WriteLine(" After Removing the item")
        For Each i In arrList
            Console.WriteLine(" {0} ", i)
        Next i
        Console.WriteLine()
        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
