using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "a,e,i,o,u, ";
            cadena = cadena.TrimEnd(' ');
            cadena = cadena.TrimEnd(',');

            Console.WriteLine(cadena);
            Console.ReadLine();

        }
    }
}
