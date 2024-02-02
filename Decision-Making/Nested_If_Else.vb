Module Nested_If_Else
  Sub Main()
   Dim x As Integer = 5, y As Integer = 20
   If x > y Then
     If x >= 10 Then
       Console.WriteLine("x value greater than or equal to 10")
     Else
       Console.WriteLine("x value less than 10")
     End If
   Else
     If y <= 20 Then
      Console.WriteLine("y value less than or equal to 20")
     Else
      Console.WriteLine("y value greater than 20")
     End If
   End If
   Console.WriteLine("Press Enter Key to Exit..")
   Console.ReadLine()
  End Sub
End Module