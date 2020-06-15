using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paracticas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa el primer numero:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero:");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("La sume de: " + a + " + " + b + " = " + c);
            Console.ReadLine();


        }
    }
}
