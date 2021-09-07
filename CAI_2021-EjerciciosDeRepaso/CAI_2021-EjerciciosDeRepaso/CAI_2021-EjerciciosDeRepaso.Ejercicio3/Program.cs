using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2021_EjerciciosDeRepaso.Ejercicio3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string palabra = "";
            string inverso = "";
            string caracter;
            int i;
           
                Console.WriteLine("Ingrese una palabra");
                palabra = Convert.ToString(Console.ReadLine());
                i = palabra.Length;
                 for (int x=i-1; x >= 0; x--) 
                {
                    caracter = palabra.Substring(x, 1);
                    inverso = inverso + caracter;
                }
                 if(palabra==inverso)
                {
                    Console.WriteLine("Es palindrome");
                }
                 else
                {
                    Console.WriteLine(palabra + " no es palindrome");
                }
               
                
            Console.ReadKey();

        }
    }
}
