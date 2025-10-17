using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio12
{
    internal class Calculos
    {
        int res;
        public int DistanciaRecorrida(int speed, int time)
        { 
            res = speed * time;
            return res;
        }
    }
}
