using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.BibliotecaClases;

namespace Expendedora.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void IngresarLata()
        {
            Console.WriteLine("Ingrese codigo");
            string codigo = AsistenteConsola.PedirString();
            Console.WriteLine("Ingrese nombre");
            string nombre = AsistenteConsola.PedirString();
            Console.WriteLine("Ingrese sabor");
            string sabor = AsistenteConsola.PedirString();
            Console.WriteLine("Ingrese precio");
            double precio = AsistenteConsola.PedirDouble();
            Console.WriteLine("Ingrese volumen");
            double volumen = AsistenteConsola.PedirDouble();
            Console.WriteLine("Ingrese cantidad");
            int cantidad = AsistenteConsola.PedirInt();

            Lata latita = new Lata(nombre, sabor, precio, volumen, cantidad);
         

        }

        private static void ExtraerLata()
        {

        }

        private static void ObtenerBalance()
        {

        }

        private static void MostrarStock()
        {

        }
    }
}
