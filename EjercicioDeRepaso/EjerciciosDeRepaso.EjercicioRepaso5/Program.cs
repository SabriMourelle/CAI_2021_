using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeRepaso.EjercicioRepaso5
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "";
           
            string inverso = "";
            string caracter;
            int largo = 0;
            int i;
            bool control = false;
            do 
            {
                Console.WriteLine("Ingrese un numero de 5 cifras");
                num = Console.ReadLine();
                largo = num.Length;
                if (largo==5)
                {
                    control = true;
                }
            }
            while (control==false);
            
         
                for (int x = largo - 1; x >= 0; x--)
                {
                    caracter = num.Substring(x, 1);
                    inverso = inverso + caracter;
                }
                Console.WriteLine("El número invertido es: " + inverso);
             
            Console.ReadKey();
        }
    }
}
