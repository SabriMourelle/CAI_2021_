using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.BibliotecaClases
{
    public static class Validaciones
    {
        public static string ValidarString(string mensaje)
        {
            string texto_ingresado;
            do
            {
                Console.WriteLine(mensaje);
                texto_ingresado = Console.ReadLine();

                if (string.IsNullOrEmpty(mensaje))
                {
                    Console.WriteLine("Por favor ingrese el dato solicitado");
                }
                
            }
            while (string.IsNullOrEmpty(mensaje));
            return texto_ingresado;
        }
    }
}
