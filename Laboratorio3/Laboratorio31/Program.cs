
//Ejercicio #1:
//El usuario debe ingresar dos números y la aplicación consola mostrará
//el resultado de la operación (a+b)*(a-b). La operación debe estar bajo
//el método Calcular de la clase CalculosMatemáticos y el programa principal
//bajo la clase Program.

using System;

class Program
{

    private static void Main(string[] args)
    {
        Calculos calc = new Calculos();
        Console.Write("Escriba el número 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escriba el número 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = calc.CalculosMatematicos(num1, num2);
        Console.WriteLine($"El resultado de la operación (a+b)*(a-b) es: {resultado}");
    }
}

class Calculos()
{ 
    public int CalculosMatematicos(int a, int b)
    {
        return (a + b) * (a - b);
    }
}