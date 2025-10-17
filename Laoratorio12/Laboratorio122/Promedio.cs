using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio122
{
    internal class Promedio
    {
        float res;
        float promedio;

        public float SumaCalificaciones(float cal1, float cal2, float cal3)
        {
            res = cal1 + cal2 + cal3;
            return res;
        }
        public float CalcularPromedio(float suma)
        {
            promedio = suma / 3;
            return promedio;
        }
    }
}
