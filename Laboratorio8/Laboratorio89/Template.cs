using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio89
{
    internal class Template : iTemplate
    {
        public void ponerVariable(string nombre, string var)
        {
            Console.WriteLine("Método poner variable {nombre} : {valor}");
        }
        public void verHtml(string template)
        {
            Console.WriteLine(template);
        }

    }
}
