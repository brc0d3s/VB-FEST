Module Que_col
    Sub Main()
        ' Create and initialize a Queue  
        Dim q_col As Queue = New Queue()
        ' Inserting items ino the Queue using the Enqueue() Operation  
        q_col.Enqueue("JavaTpoint")
        q_col.Enqueue("VB.NET")
        q_col.Enqueue("Tutorial")
        q_col.Enqueue("Queue")
        q_col.Enqueue("Array")
        q_col.Enqueue(10)

        ' Count all items of the Queue  
        Console.WriteLine(" Total Inserted Elements in Queue is : {0}", q_col.Count)
        Console.WriteLine(" Elements of Queue are :")
        For Each item In q_col
            Console.WriteLine(item)
        Next
        Console.WriteLine()

        ' Use of Contains() function  
        Console.WriteLine(" Is the Element 'Array' exists in Queue? : {0}", q_col.Contains("Array"))
        Console.WriteLine(" Is the Element '5' exists in Queue? : {0}", q_col.Contains(5))
        Console.WriteLine()

        ' Use of Peek() function  
        Console.WriteLine(" Next value to be popped out from the Queue is : {0}", q_col.Peek())
        Console.WriteLine(" Next value to be popped out from the Queue is : {0}", q_col.Peek())

        ' Use of Dequeue() function  
        Console.WriteLine(" Remove some elements from Queue")
        Dim obj As Object
        obj = q_col.Dequeue()
        Console.WriteLine(" Removed Value is: {0}", obj)
        obj = q_col.Dequeue()
        Console.WriteLine(" Removed Value is: {0}", obj)

        Console.WriteLine(" After removing elements from Queue ")
        For Each item In q_col
            Console.WriteLine(item)
        Next

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
