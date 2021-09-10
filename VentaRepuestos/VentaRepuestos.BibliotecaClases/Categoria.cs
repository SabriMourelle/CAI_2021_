using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.BibliotecaClases
{
    public class Categoria
    {
        private int _codigocat;
        private string _nombrecat;
        private string _categoria;

        //Habrá 3 categorías: moto, auto, camión

        public Categoria(string categoria, int codigoCat, string nombreCat)
        {
            _categoria = categoria;
            _codigocat = codigoCat;
            _nombrecat = nombreCat;
        }
    }
}
