using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();


            Console.WriteLine(random.Next());
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(random.Next(6));
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(random.Next(1, 6));
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(random.NextDouble());
            Console.WriteLine("----------------------------------------------------------");
            Byte[] buffer = new Byte[6];
            random.NextBytes(buffer);
            for (int i = 0; i <= buffer.GetUpperBound(0); i++)
                Console.WriteLine("{0}: {1}", i, buffer[i]);
            Console.WriteLine("----------------------------------------------------------");

            int length = 7;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            Console.WriteLine(str_build.ToString());

            Console.WriteLine("----------------------------------------------------------");

            string numberCode = "";

            for (int i = 0; i < 6; i++)
            {
                numberCode = numberCode + random.Next(0,9).ToString();
            }
            Console.WriteLine(numberCode);




            Console.ReadLine();


        }
    }
}
