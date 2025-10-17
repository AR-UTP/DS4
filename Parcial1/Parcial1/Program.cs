

namespace Parcial1;
public class Program
{
    public static void Main(string[] args)
    {
        int n;
        Matriz m = new Matriz();

        //Definir tamaño de la matriz
        do
        {
            Console.WriteLine("Ingrese el tamaño de la matriz (Debe ser par)");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 != 0)
            {
                Console.WriteLine("El tamaño de la matriz debe ser par");
            }
        } while (n % 2 != 0);
                m.DefinirMatriz(n);
            Console.WriteLine();


            int[,] matriz = m.Mat;

            //Llenar la matriz
            Random rnd = new Random();
            m.LlenarMatriz(rnd);
            Console.WriteLine("La matriz es: ");
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int sumaMat = m.CalcularSuma();
            Console.WriteLine("La suma de los elementos de la matriz es: " + sumaMat);

    }
}