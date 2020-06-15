using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Conductor> listConductor = new List<Conductor>();
            listConductor.Add(new Conductor() { IdConductor = 1, Nombre = "Erik", Apellido = "Rodriguez" });
            listConductor.Add(new Conductor() { IdConductor = 2, Nombre = "Antonio", Apellido = "Gallegos" });

            List<Usuario> listUsuario = new List<Usuario>();
            listUsuario.Add(new Usuario() { IdUsuario = 1, Nombre = "Diego", Apellido = "Perez" });
            listUsuario.Add(new Usuario() { IdUsuario = 2, Nombre = "Diana", Apellido = "Ochoa" });
            listUsuario.Add(new Usuario() { IdUsuario = 3, Nombre = "Alejandra", Apellido = "Chaparro" });
            listUsuario.Add(new Usuario() { IdUsuario = 4, Nombre = "Ever", Apellido = "Mendez" });

            List<Viaje> listViaje = new List<Viaje>();
            listViaje.Add(new Viaje() { IdViaje = 1, IdConductor = 1, IdUsuario = 1, Estatus = "Terminado" });
            listViaje.Add(new Viaje() { IdViaje = 2, IdUsuario = 1, Estatus = "En proceso" });
            listViaje.Add(new Viaje() { IdViaje = 3, IdUsuario = 1, Estatus = "En proceso" });
            listViaje.Add(new Viaje() { IdViaje = 4, IdUsuario = 1, Estatus = "En proceso" });

            var travelsDto = new List<ViajeDTO>();
            travelsDto = (
                     from travel in listViaje.DefaultIfEmpty()
                     join user in listUsuario.DefaultIfEmpty() on travel.IdUsuario equals user.IdUsuario
                     join driver in listConductor.DefaultIfEmpty() on travel.IdConductor equals driver.IdConductor into travelDriver
                     from trav in travelDriver.DefaultIfEmpty()

                        
                     select new ViajeDTO
                     {
                         IdVIaje = travel.IdViaje,
                         NombreUsuario = user.Nombre,
                         NombreConductor = trav == null ? "" : trav.Nombre,
                         Estatus = travel.Estatus
                     }
                ).ToList();


            foreach (var item in travelsDto)
            {
                Console.WriteLine("Viaje: " + item.IdVIaje + " - Usuario: " + item.NombreUsuario + " - Conductor: " + item.NombreConductor + " - " + item.Estatus);
            }
            Console.ReadLine();


            //var lstFacturas = new List<Factura>
            //      {
            //        new Factura {IdFactura = 1, Importe = 500 },
            //        new Factura {IdFactura = 2, Importe = 1200 },
            //        new Factura {IdFactura = 3, Importe = 400 },
            //        new Factura {IdFactura = 4, Importe = 3500 }
            //      };

            //var lstDescuentos = new List<FacturaDescuento>
            //        {
            //          new FacturaDescuento {IdFactura = 2, Descuento = 20 },
            //          new FacturaDescuento {IdFactura = 4, Descuento = 100 }
            //        };

            //var lstLeftJoin =
            //  (from fact in lstFacturas
            //   join desc in lstDescuentos on fact.IdFactura equals desc.IdFactura into FactDesc
            //   from fd in FactDesc.DefaultIfEmpty()
            //   select new
            //   {
            //       IdFactura = fact.IdFactura,
            //       ImporteBase = fact.Importe,
            //       ImporteACobrar = (fd == null) ? fact.Importe : fact.Importe - fd.Descuento
            //   }
            //  ).ToList();


            //foreach (var item in lstLeftJoin)
            //{
            //    Console.WriteLine(item.IdFactura + " - " + item.ImporteBase + " - " + item.ImporteACobrar);
            //}
            //Console.ReadLine();

        }

        public class Factura
        {
            public int IdFactura { get; set; }
            public decimal Importe { get; set; } 
        }

        public class FacturaDescuento
        {
            public int IdFactura { get; set; }
            public decimal Descuento { get; set; } 
        }




        public class Conductor
        {
            public int IdConductor { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }

        }

        public class Usuario
        {
            public int IdUsuario { get; set; }
            public string Nombre { get; set; } 
            public string Apellido { get; set; } 
        }

        public class Viaje
        {
            public int IdViaje { get; set; }
            public int IdConductor { get; set; }
            public int IdUsuario { get; set; }
            public string Estatus  { get; set; }

        }

        public class ViajeDTO
        {

            public int IdVIaje { get; set; } 
            public string NombreUsuario { get; set; }
            public string NombreConductor { get; set; }
            public string Estatus { get; set; }

        }

    }
}
