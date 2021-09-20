using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.BibliotecaClases
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;
        
        public Lata ()
        {

        }
        
            public Lata(string nombre, string sabor, double precio, double volumen, int cantidad)
        {
          
            _nombre = nombre;
            _sabor = sabor;
            _precio = precio;
            _volumen = volumen;
            _cantidad = cantidad;

            
        }

        public string lastLata { get { return _codigo; } }

    }
}
