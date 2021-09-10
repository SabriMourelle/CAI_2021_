using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestos.BibliotecaClases;


namespace VentaRepuestos.Consola
{
    class Program
    {
        static bool _consolaActiva = true;
        static CasaRepuestos _nombreComercio;
        //chequear si es así como se agrega ultimo cod utilizado

        int lastCod;

        static Program ()
        {
            _consolaActiva = true;
            _nombreComercio = new CasaRepuestos("El cosito del coso", "Corrientes 1575");
           
        }

        static void DesplegarMenu()
        {
            Console.WriteLine("Por favor, elija una opción;");
            Console.WriteLine("1- Agregar repuesto");
            Console.WriteLine("2- Quitar repuesto");
            Console.WriteLine("3- Modificar precio");
            Console.WriteLine("4- Agregar stock");
            Console.WriteLine("5- Quitar stock");
            Console.WriteLine("6- Traer por categoria");
            Console.WriteLine("S- Salir");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a " + _nombreComercio);

            while (_consolaActiva=true)
            {
                Console.Clear();
                DesplegarMenu();
                string _opcionUsuario = Console.ReadLine();

                switch (_opcionUsuario.ToLower())
                {
                    case "1":
                        //Console.WriteLine("1- Agregar repuesto");
                        break;
                    case "2":
                        //Console.WriteLine("2- Quitar repuesto");
                        break;
                    case "3":
                        //Console.WriteLine("3- Modificar precio");
                        break;
                    case "4":
                        //Console.WriteLine("4- Agregar stock");
                        break;
                    case "5":
                        //Console.WriteLine("5- Quitar stock");
                        break;
                    case "6":
                        //Console.WriteLine("6- Traer por categoria");
                        break;
                    case "s":
                        //Console.WriteLine("S- Salir");
                        _consolaActiva = false;
                        break;
                }
                
            }

        }

        private static void AgregarRepuesto()
        {
            //Agregar repuesto nuevo
        int codigo=AyudaConsola.SolicitarInt();
        string nombre=AyudaConsola.SolicitarString();
        double precio=AyudaConsola.SolicitarDouble();
        int stock=AyudaConsola.SolicitarInt();
        string categoria=AyudaConsola.SolicitarCat();

            Repuesto repuesto = new Repuesto(codigo, nombre, precio, stock,categoria);

            
        }

        

       
    }
}
