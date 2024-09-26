Public Class Perro
    Public nombre As String
    Public raza As String
    Public altura As String

    Public Function comer(carne As String) As String
        Return nombre + " mide " + altura + " y comió " + carne
    End Function
    Public Sub dormir()

    End Sub
    Public Sub ladrar()

    End Sub
    Public Function calcularCosto(costo As Double, impuesto As Double) As Double
        Dim preciototal As Double
        preciototal = costo + (costo * impuesto)
        Return preciototal
    End Function
    Public Sub New()

    End Sub
    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
End Class

Public Module Labs104
    Public Sub Main(args() As String)
        Dim perrito As New Perro()
        perrito.nombre = "Max"
        perrito.raza = "Pastor Alemán"
        perrito.altura = "0.50"
        Console.WriteLine(perrito.comer("carne"))

        Dim perrito2 As Perro = New Perro()
        perrito2.nombre = "Coco"
        perrito2.altura = "0.60"

        Console.WriteLine(perrito2.comer("Pollo"))

        Dim perrito3 As Perro = New Perro("Collechin", "Poodle", "0.30")
        Console.WriteLine(perrito3.comer("pan"))
    End Sub
End Module
