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
    }
}
