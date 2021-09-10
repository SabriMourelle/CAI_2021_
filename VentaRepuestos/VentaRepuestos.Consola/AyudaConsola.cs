using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Consola
{
    public class AyudaConsola
    {
        internal static string SolicitarString()
        {
            return Console.ReadLine();
        }

        internal static int SolicitarInt ()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        internal static double SolicitarDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        internal static string SolicitarCat()
        {
            Console.WriteLine("Por favor, seleccione categoría: A- Auto, B-Moto, C-Camión");
            string opcionCat = Console.ReadLine();
            string categoria = "";

            switch (opcionCat.ToLower)
            {
                case "a":
                    categoria = "Auto";
                    break;
                case "b":
                    categoria = "Moto";
                    break;
                case "c":
                    categoria = "Camión";
                    break;
                default:
                    Console.WriteLine("Por favor, seleccione una categoría válida: A- Auto, B-Moto, C-Camión");
                    break;
            }
          
            

            return Convert.ToString(Console.ReadLine());
        }
    }
}
