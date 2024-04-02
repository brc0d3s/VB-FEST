Module Stack_Collection
    Sub Main()
        ' Create and initialize a Stack  
        Dim St_col As Stack = New Stack()
        ' Inserting item in the Stack using the Push() Operation  
        St_col.Push("JavaTpoint")
        St_col.Push("VB.NET")
        St_col.Push("Tutorial")
        St_col.Push("Stack")
        St_col.Push("Array")
        St_col.Push(10)

        ' Count all items of the Stack.  
        Console.WriteLine(" Total Number of Inserted Elements in Stack is : {0}", St_col.Count)
        Console.WriteLine(" Elements of Stack are :")
        For Each item In St_col
            Console.WriteLine(item)
        Next
        Console.WriteLine()

        ' Use of Contains() function  
        Console.WriteLine(" Is the Element 'Array' exists in Stack? : {0}", St_col.Contains("Array"))
        Console.WriteLine(" Is the Element '5' exists in Stack? : {0}", St_col.Contains(5))
        Console.WriteLine()

        ' Use of Peek() function  
        Console.WriteLine(" Next value to be popped at the top in Stack is : {0}", St_col.Peek())
        For Each item In St_col
            Console.WriteLine(item)
        Next
        Console.WriteLine()
        ' Use of Pop() function  
        Console.WriteLine(" Remove elements from the Stack")
        St_col.Pop()
        St_col.Pop()
        St_col.Pop()
        St_col.Pop()
        Console.WriteLine(" After removing elements from the stack")
        For Each item In St_col
            Console.WriteLine(item)
        Next

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
