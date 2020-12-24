using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero = "01";

            DateTime date1 = Convert.ToDateTime("14-12-2020");
            DateTime date2 = Convert.ToDateTime("15-12-2020");
            DateTime date3 = Convert.ToDateTime("16-12-2020");
            DateTime date4= Convert.ToDateTime("17-12-2020");
            DateTime date5 = Convert.ToDateTime("18-12-2020");
            DateTime date6 = Convert.ToDateTime("19-12-2020");
            DateTime date7 = Convert.ToDateTime("20-12-2020");

            Console.Write(date1.DayOfWeek);
            Console.Write(date2.DayOfWeek);
            Console.Write(date3.DayOfWeek);
            Console.Write(date4.DayOfWeek);
            Console.Write(date5.DayOfWeek);
            Console.Write(date6.DayOfWeek);
            Console.Write(date7.DayOfWeek);
            Console.ReadKey();



            //int cont = 1;
            //for (int i = 1; i < 11; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("par = " + (i / 2) );
            //    }
            //    else
            //    {
            //        Console.WriteLine("no par = " + (i / 2));
            //    }
               
            //}

            //Console.ReadKey();


        }
    }
}
