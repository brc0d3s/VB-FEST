Module While_End_Loop
    Sub Main()
        'Declare an Integer variable  
        Dim n, remainder, sum As Integer
        sum = 0

        Console.WriteLine(" Enter the number :")
        n = Console.ReadLine()  ' Accept a number from the user  

        ' Use While loop and write given below condition    
        While (n > 0)
            remainder = n Mod 10
            sum += remainder
            n = n \ 10
        End While
        Console.WriteLine(" Sum of digit is :{0}", sum)

    End Sub
End Module
