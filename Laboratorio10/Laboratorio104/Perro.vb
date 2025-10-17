
Public Class Perro
    Public nombre As String
    Public raza As String
    Pubic altura As String

    Public Function comer(carne As String) As String
        Return nombre + " mide " + altura + " y comerá " + carne
    End Function
    Public Sub Dormir()

    End Sub

    Public Sub Ladrar()

    End Sub

    Public Funtion CalcularCosto(costo As Double, impuesto As Double) As
        Dim precioTotal As Double
        precioTotal = costo + (costo * impuesto)
        Return precioTotal
    End Function

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
End Class