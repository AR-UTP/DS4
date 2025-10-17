using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Matriz
    {
        private int[,] mat;

        public int[,] Mat
        {
            get { return mat; }
        }

        //Método para definir el tamaño de la matriz
        public void DefinirMatriz(int n)
        {
            this.mat = new int[n, n];
        }

        //Método para llenar la matriz
        public void LlenarMatriz(Random rnd)
        {
            for (int f = 0; f < mat.GetLength(0); f++)
                for (int c = 0; c < mat.GetLength(1); c++)
                    if ((f == 0 || f == mat.GetLength(0) - 1) || (c == 0 || c == mat.GetLength(1) - 1))
                        mat[f, c] = Convert.ToInt32(rnd.Next(1, 101));
                    else
                    {
                        mat[f, c] = 0;
                    }
        }

        public int CalcularSuma()
        {
            int result = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    result = result + mat[f, c];
                }
            }
            return result;
        }
    }
}
