Module Type_Conversion_Functions
    'The following functions are available for conversion:
    ' CBool(expression): It is used to convert an expression into a Boolean data type.
    ' CByte(expression): It is used to convert an expression to a Byte data type.
    ' CChar(expression): It is used to convert an expression to a Char data type.
    ' CDate(expression): It is used to convert an expression to a Date data type.
    ' CDbl(expression): It is used to convert an expression into a Double data type.
    ' CDec(expression): It is used to convert an expression into a Decimal data type.
    ' CInt(expression): It is used to convert an expression to an Integer data type.
    ' CLng(expression): It is used to convert an expression to a Long data type.
    ' CObj(expression): It is used to convert an expression to an Object data type.
    ' CSByte(expression): It is used to convert an expression to an SByte data type.
    ' CShort(expression): It is used to convert an expression to a Short data type.
    ' CSng(expression): It is used to convert an expression into a Single data type.
    ' CStr(expression): It is used to convert an expression into a String data type.
    ' CUInt(expression): It is used to convert an expression to a UInt data type.
    ' CULng(expression): It is used to convert an expression to a ULng data type.
    ' CUShort(expression): It is used to convert an expression into a UShort data type.


    Sub Main()
        'defining the Data type conversion  
        Dim dblData As Double
        dblData = 5.78
        Dim A, B As Char
        Dim bool As Boolean = True
        Dim x, Z, B_int As Integer
        A = "A"
        B = "B"
        B_int = AscW(B)

        Console.WriteLine(" Ascii value of B is {0}", B_int)

        x = 1
        Z = AscW(A)
        Z = Z + x
        Console.WriteLine("String to integer {0}", Z)
        Console.WriteLine("Boolean value is : {0}", CStr(bool))
        Dim num, intData As Integer

        num = CInt(dblData)
        intData = CType(dblData, Integer)
        Console.WriteLine(" Explicit conversion of Data type " & Str(intData))
        Console.WriteLine(" Value of Double is: {0}", dblData)
        Console.WriteLine("Double to Integer: {0}", num)
        Console.ReadKey()
    End Sub
End Module
