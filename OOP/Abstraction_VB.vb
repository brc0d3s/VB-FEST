Module Abstraction_VB
    Public Class Laptop

        Private brand As String

        Private model As String

        Public Property Lbrand() As String

            Get

                Return brand

            End Get

            Set(ByVal value As String)

                brand = value

            End Set

        End Property

        Public Property Lmodel() As String

            Get

                Return model

            End Get

            Set(ByVal value As String)

                model = value

            End Set

        End Property

        Public Sub LaptopDetails()

            Console.WriteLine("Brand: " & Lbrand)

            Console.WriteLine("Model: " & Lmodel)

        End Sub

    End Class

    Sub Main()

        Dim l As Laptop = New Laptop()

        l.Lbrand = "Dell"

        l.Lmodel = "Inspiron 14R"

        l.LaptopDetails()

    End Sub
End Module
