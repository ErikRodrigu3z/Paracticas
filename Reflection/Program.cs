using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Person
            {
                Id = 1,
                Name = "Erik",
                LastName = "Rodriguez",
                PhoneNumber = "123456789"
            };

            foreach (var item in model.GetType().GetProperties())
            {
                Console.WriteLine("Tipo: {0} Nombre: {1} Valor: {2}",item.PropertyType.Name,
                    item.Name, item.GetValue(model));
            }
            Console.ReadKey();
        }


        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string  LastName { get; set; }
            public string PhoneNumber { get; set; }
        }


    }
}
