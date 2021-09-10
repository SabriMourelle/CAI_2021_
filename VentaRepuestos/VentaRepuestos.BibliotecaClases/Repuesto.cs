using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.BibliotecaClases
{
    public class Repuesto
    {
        //atributos 

        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private string _categoria;
    

    public Repuesto (int codigo,string nombre,double precio,int stock, string categoria)
    {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = categoria;
          
          

    }

    }
}
