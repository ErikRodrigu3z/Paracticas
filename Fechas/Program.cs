using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fecha actual");
            Console.WriteLine(DateTime.Now + "\r\n");
            Console.WriteLine("Agrega 24 horas");            
            Console.WriteLine(DateTime.Now.AddHours(23).AddMinutes(59).AddSeconds(59));

            DateTime date1 = new DateTime(2020, 4, 29, 16, 28, 0); //"4/30/2020 4:26:24 PM"; //DateTime.Now;
            DateTime date2 = new DateTime(2020, 4, 29, 16, 27, 0); //DateTime.Now.AddHours(23).AddMinutes(59).AddSeconds(59);
            DateTime date3 = DateTime.UtcNow;


            if (date1 <= date2)
            {
                Console.WriteLine(date1 + " es menor que " + date2);
            }
            else
            {
                Console.WriteLine(date1 +" es mayor que " + date2);

            }
            
            //Console.WriteLine(Assembly.GetEntryAssembly().FullName);
            //Console.WriteLine(DateTime.Now.ToUniversalTime().ToString("R"));
            //Console.WriteLine(DateTime.Now.ToUniversalTime().ToLocalTime().ToString("R"));
            //Console.WriteLine(date3);
            //Console.WriteLine(DateTime.Now.ToLongDateString());


            //formatos
            DateTime aDate = DateTime.Now;
            Console.WriteLine(aDate.ToString("MM/dd/yyyy"));
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(aDate.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(aDate.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(aDate.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(aDate.ToString("dd/MM/yyyy HH:mm:ss")); //
            Console.WriteLine(aDate.ToString("MMMM dd"));
            Console.WriteLine(aDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            Console.WriteLine(aDate.ToString("ddd, dd MMM yyy HH':'mm':'ss ‘GMT’"));
            Console.WriteLine(aDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            Console.WriteLine(aDate.ToString("HH:mm"));
            Console.WriteLine(aDate.ToString("hh:mm tt"));
            Console.WriteLine(aDate.ToString("H:mm"));
            Console.WriteLine(aDate.ToString("h:mm tt"));
            Console.WriteLine(aDate.ToString("HH:mm:ss"));
            Console.WriteLine(aDate.ToString("yyyy MMMM"));

            string sFecha = "10/05/2020 15:10:26";
            DateTime dateconvert = Convert.ToDateTime(sFecha);
            Console.WriteLine(dateconvert);
            TimeSpan CurrentTime = DateTime.Now.TimeOfDay;
            Console.WriteLine(CurrentTime);
            Console.WriteLine(Convert.ToDateTime("12:14:30.2084468"));
            DateTime finalTime = DateTime.Now.AddHours(23).AddMinutes(59).AddSeconds(59);
            Console.WriteLine(finalTime + " date final");
            Console.WriteLine(finalTime.TimeOfDay + " TimeSpan");
            TimeSpan oTS = new TimeSpan(finalTime.Ticks);
            Console.WriteLine(oTS + " TimeSpan final");

            Console.WriteLine(DateTime.Now.TimeOfDay + " +24");           
            
            Console.WriteLine(DateTime.Now.ToLocalTime());

            Console.ReadLine();
           

        }
    }
}
