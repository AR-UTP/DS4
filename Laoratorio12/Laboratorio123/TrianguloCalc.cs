using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio123
{
    internal class TrianguloCalc
    {
        public int Semiperimetro(int ladoA, int ladoB, int ladoC)
        { 
          return (ladoA + ladoB + ladoC) / 2;
        }
        public double Area(int ladoA, int ladoB, int ladoC)
        {
            double semiP = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(semiP * (semiP - ladoA) * (semiP - ladoB) * (semiP - ladoC));
        }
    }
}
