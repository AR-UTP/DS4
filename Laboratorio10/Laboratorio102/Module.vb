
Module area
    Sub Main()
        Dim radio As Single
        Dim area As Single
        Dim circunferencia As Single
        Const pi = 3.1415926

        Console.WriteLine("Ingrese el radio")
        radio = Console.ReadLine()

        area = pi * radio ^ 2

        Console.WriteLine("El �rea es: {0}", area)
        Console.WriteLine("La circunferencia es: {0}", circunferencia)

        Console.ReadKey()
    End Sub
End Module