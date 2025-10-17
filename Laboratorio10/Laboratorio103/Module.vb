
Module peso

    Sub Main()
        Dim M As Double
        Dim G As Double
        Dim P As Double

        'Ingresar los valores
        G = 9.8
        Console.WriteLine("Ingrese la masa deobjeto")
        M = Console.ReadLine()

        'Realizar procesos:
        P = M * G

        'Mostrar resultados
        Console.WriteLine("El peso del objeto es: {0}", P)
        Console.ReadKey()
    End Sub
End Module