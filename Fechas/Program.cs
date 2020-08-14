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
            //Console.WriteLine("Fecha actual");
            //Console.WriteLine(DateTime.Now + "\r\n");
            //Console.WriteLine("Agrega 24 horas");            
            //Console.WriteLine(DateTime.Now.AddHours(23).AddMinutes(59).AddSeconds(59));

            //DateTime date1 = new DateTime(2020, 4, 29, 16, 28, 0); //"4/30/2020 4:26:24 PM"; //DateTime.Now;
            //DateTime date2 = new DateTime(2020, 4, 29, 16, 27, 0); //DateTime.Now.AddHours(23).AddMinutes(59).AddSeconds(59);
            //DateTime date3 = DateTime.UtcNow;


            //if (date1 <= date2)
            //{
            //    Console.WriteLine(date1 + " es menor que " + date2);
            //}
            //else
            //{
            //    Console.WriteLine(date1 +" es mayor que " + date2);

            //}
            
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


// DateTime.Now.ToString("MM/dd/yyyy")     05 / 29 / 2015
// DateTime.Now.ToString("dddd, dd MMMM yyyy")     Friday, 29 May 2015
// DateTime.Now.ToString("dddd, dd MMMM yyyy")     Friday, 29 May 2015 05:50
// DateTime.Now.ToString("dddd, dd MMMM yyyy")     Friday, 29 May 2015 05:50 AM
// DateTime.Now.ToString("dddd, dd MMMM yyyy")     Friday, 29 May 2015 5:50
// DateTime.Now.ToString("dddd, dd MMMM yyyy")     Friday, 29 May 2015 5:50 AM
// DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")    Friday, 29 May 2015 05:50:06
// DateTime.Now.ToString("MM/dd/yyyy HH:mm")   05 / 29 / 2015 05:50
// DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")    05 / 29 / 2015 05:50 AM
// DateTime.Now.ToString("MM/dd/yyyy H:mm")    05 / 29 / 2015 5:50
// DateTime.Now.ToString("MM/dd/yyyy h:mm tt")     05 / 29 / 2015 5:50 AM
// DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")    05 / 29 / 2015 05:50:06
// DateTime.Now.ToString("MMMM dd")    May 29
// DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK")     2015 - 05 - 16T05: 50:06.7199222 - 04:00
// DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’")     Fri, 16 May 2015 05:50:06 GMT
// DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss")  2015 - 05 - 16T05: 50:06
// DateTime.Now.ToString("HH:mm")  05:50
// DateTime.Now.ToString("hh:mm tt")   05:50 AM
// DateTime.Now.ToString("H:mm")   5:50
// DateTime.Now.ToString("h:mm tt")    5:50 AM
// DateTime.Now.ToString("HH:mm:ss")   05:50:06
// DateTime.Now.ToString("yyyy MMMM")  2015 May



            //string sFecha = "10/05/2020 15:10:26";
            //DateTime dateconvert = Convert.ToDateTime(sFecha);
            //Console.WriteLine(dateconvert);
            //TimeSpan CurrentTime = DateTime.Now.TimeOfDay;
            //Console.WriteLine(CurrentTime);
            //Console.WriteLine(Convert.ToDateTime("12:14:30.2084468"));
            //DateTime finalTime = DateTime.Now.AddHours(23).AddMinutes(59).AddSeconds(59);
            //Console.WriteLine(finalTime + " date final");
            //Console.WriteLine(finalTime.TimeOfDay + " TimeSpan");
            //TimeSpan oTS = new TimeSpan(finalTime.Ticks);
            //Console.WriteLine(oTS + " TimeSpan final");

            //Console.WriteLine(DateTime.Now.TimeOfDay + " +24");           

            //Console.WriteLine(DateTime.Now.ToLocalTime());

            Console.ReadLine();
           

        }
    }
}
