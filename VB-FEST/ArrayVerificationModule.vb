Module ArrayVerificationModule
    Sub Main()
        Dim setofArrays(6) As Integer

        Try

            setofArrays(0) = 18
            setofArrays(1) = 28
            setofArrays(2) = 38
            setofArrays(3) = 48
            setofArrays(4) = 58
            setofArrays(5) = 68
            setofArrays(6) = 78

            'setofArrays(7) = 88

            For Each num As Integer In setofArrays
                Console.WriteLine(num)
            Next
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try
    End Sub
End Module
