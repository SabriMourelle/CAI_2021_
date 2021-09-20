using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Consola
{
    public class AsistenteConsola
    {
        internal static string PedirString()
        {
            return Console.ReadLine();
        }

        internal static int PedirInt()
        {
           return Convert.ToInt32(Console.ReadLine());
        }
        internal static double PedirDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
