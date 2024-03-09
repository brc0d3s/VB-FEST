Module BitShift_Operator
    Sub Main()
        Dim x, y, z As Integer
        x = 12
        y = 25
        Dim a, b As Double
        a = 5 ' a = 5(00000101)  
        b = 9 ' b = 9(00001001)  

        ' Use of And Operator  
        z = x And y
        Console.WriteLine(" BitShift Operator x And y is {0}", z)

        'Use of Or Operator  
        z = x Or y
        Console.WriteLine(" BitShift Operator x Or y is {0}", z)

        z = x Xor y
        Console.WriteLine(" BitShift Operator x Xor y is {0}", z)

        z = Not y
        Console.WriteLine(" BitShift Operator Not y is {0}", z)

        'Use of << Left-Shift Operator  
        ' Output is 00001010  
        Console.WriteLine(" Bitwise Left Shift Operator - a<<1 = {0}", a << 1)

        'Output is 00010010  
        Console.WriteLine(" Bitwise Left Shift Operator - b<<1 = {0}", b << 1)

        'Use of >> Right-Shift Operator  
        'Output is 00000010  
        Console.WriteLine(" Bitwise Right Shift Operator - a>>1 = {0}", a << 1)

        'Output is 00000100  
        Console.WriteLine(" Bitwise Right Shift Operator - b>>1 = {0}", a << 1)

        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
