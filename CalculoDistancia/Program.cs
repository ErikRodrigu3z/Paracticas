using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDistancia
{
    class Program
    {
        static void Main(string[] args)
        {

            var res = getDistanceFromLatLonInKm(28.613014, -106.076659, 28.6130437, -106.0766086);

            Console.WriteLine(res);
            Console.ReadKey();

        }

        private static double getDistanceFromLatLonInKm(double lat1 , double lon1 , double lat2 , double lon2 )
        {
            var R = 6371; // Radius of the earth in km
            var dLat = deg2rad(lat2 - lat1);  // deg2rad below
            var dLon = deg2rad(lon2 - lon1);
            var a =
              Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
              Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) *
              Math.Sin(dLon / 2) * Math.Sin(dLon / 2)
              ;
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c; // Distance in km
            return d;
        }


        private static double deg2rad(double deg)
        {
            var res = deg * (Math.PI / 180);
            return res;
        }
    }
}
