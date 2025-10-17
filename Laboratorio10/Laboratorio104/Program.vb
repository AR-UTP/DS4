
Public Module Program
    Public Sub Main(arg() As String)
        Dim perrito As Perro = New Perro()
        perrito.nombre = "chizu"
        perrito.raza = "Pastor Aleman"
        perrito.altura = "0.70 cm"

        Console.WriteLine(perrito.comer("carne de res"))

        Dim perrito2 As Perrito = New Perro()
        perrito2.nombre = "Lasy"
        perrito2.altura = "0.60"

        Console.Write line(perrito2.comer("Pollo"))

        Dim perrito3 As Perro = New Perro("Peluchin", "Poodle" + "0.50")
        Console.WriteLine(perrito3.comer("Pan")
    End Sub
End Module