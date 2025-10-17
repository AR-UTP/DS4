

using Laboratorio84;

namespace Laboratorio8
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
            Empleado empleado = new Empleado();
            empleado.Nombre = "John Doe";
            Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

            CuentaBancaria cta = new CuentaBancaria();
            cta.Saldo = 100;
           // cta.Saldo = -22;
            Console.WriteLine($"El saldo del empleado: {cta.Saldo}");

            Cobertura c = new Cobertura(5);
            Console.WriteLine($"Cobertura: {c.Radio}");
        }
    }
}