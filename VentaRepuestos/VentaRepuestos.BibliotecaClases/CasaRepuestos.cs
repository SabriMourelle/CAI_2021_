using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.BibliotecaClases
{
    public class CasaRepuestos
    {
        private string _nombreComercio;
        private string _direccion;
        private List<Repuesto> _repuesto;

        public CasaRepuestos(string nombre, string direccion)
        {
            _nombreComercio= nombre;
            _direccion=direccion;
            _repuesto= new List<Repuesto>();
        }

        public string Nombre
        {
            get
            {
                return _nombreComercio;
            }
            
        }

        private int NuevoCodigo()
        {
          //verificar cual fue el ultimo codigo y sumarle 1
            int _newcodigo= 0;
            return _newcodigo;
        }
}
}
