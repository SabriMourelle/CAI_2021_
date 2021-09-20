using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.BibliotecaClases
{
    public class Expendedora
    {
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;
        private int _cantidad;
        private List<Lata> _latas;

        public Expendedora()
        {

        }

        public bool AgregarLata(Lata lata)
        {
            string nuevoCod = TraerNuevoCodigo();
            Lata lataNueva = new Lata();
            _latas.Add(lataNueva);

            return true;
        }

        private string TraerNuevoCodigo()
            {
            //buscar ultimo cod y sumarle 1


            return "";

            }
        public List<Lata> TraerLata()
        {
            if (_latas.Count == 0)
                return null;
            else
                return _latas;
        }
    }

    
}
