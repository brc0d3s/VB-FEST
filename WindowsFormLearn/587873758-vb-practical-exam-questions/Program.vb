Imports System

Module Program
    Sub rectanglePattern()
        Dim row As Integer
        Dim column As Integer
        For row = 1 To 6
            For column = 1 To 6
                Console.Write("@")
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub trianglePattern()
        Dim row As Integer
        Dim column As Integer
        For row = 1 To 6
            For column = 1 To 6
                If row > column Then
                    Console.Write("@")
                Else
                    Console.Write("")
                End If
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub Main()
        rectanglePattern()
        trianglePattern()
    End Sub
End Module
