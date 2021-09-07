using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.EjercicioRepaso4
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1, palabra2;
            int largo1, largo2;
            string orden1, orden2;
            string pal1ordenada = "";
            string pal2ordenada="";
            string cartel1="";
            string cartel2 = "";

            Console.WriteLine("Ingrese una palabra");
            palabra1 = Convert.ToString(Console.ReadLine());
            largo1 = palabra1.Length;
            

            Console.WriteLine("Ingrese otra palabra");
            palabra2 = Convert.ToString(Console.ReadLine());
            largo2 = palabra2.Length;

            Console.WriteLine("Las palabras ingresadas son "+ palabra1 +" y " +palabra2);
            Console.WriteLine("Las palabras tienen cantidad de caracteres " + largo1 + " y " + largo2);

            if (largo1 != largo2)
            {
                Console.WriteLine(palabra1 + " y " + palabra2 + " no son un anagrama");
            }
            else
            {
                String[] ordenPalabra1 = new String[largo1];
                for (int i = 0; i < largo1; i++)
                {
                    ordenPalabra1[i] = palabra1.Substring(i, 1);
                    cartel1 = cartel1 + ordenPalabra1[i] + " ";
                    Console.WriteLine(cartel1 + " ");
                }
                String[] ordenPalabra2 = new String[largo2];
                for (int x = 0; x < largo2; x++)
                {
                    ordenPalabra2[x] = palabra2.Substring(x, 1);

                }
                if (ordenPalabra1 == ordenPalabra2)
                {
                    Console.WriteLine("Las palabras ingresadas son un anagrama " + ordenPalabra1 + " " + ordenPalabra2);
                }
            }
            Console.ReadKey();
        }
    }
}
