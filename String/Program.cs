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
            //quite el espacio y la ,
            cadena = cadena.TrimEnd(' ').TrimEnd(',');
           

            Console.WriteLine(cadena);
            Console.ReadLine();

        }
    }
}
