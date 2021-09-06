using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2021_EjerciciosDeRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int nro_registro = 644;
            string contador = "";

            do
            {
                numero = numero + 1;
                if (numero % 3 == 0)
                {
                    if (numero % 5 == 0)
                    {
                        contador = contador + numero + " - FooBar" + "\n";
                    }
                    else
                    {
                        contador = contador + numero + " - Foo" + "\n";
                    }
                }
                else
                {
                    contador = contador + numero + "\n";
                }

                
            }
            while (numero < nro_registro);

            Console.WriteLine(contador);
            Console.ReadKey(); 
        }
    }
}
