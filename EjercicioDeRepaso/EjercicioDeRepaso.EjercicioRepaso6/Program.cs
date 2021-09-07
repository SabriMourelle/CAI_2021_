using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeRepaso.EjercicioRepaso6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
          

            Console.WriteLine("Por favor, ingrese un numero ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese otro numero ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de la formula es: " + ((a + b)* (a - b)));
            Console.ReadKey();
        }

        }
    }

