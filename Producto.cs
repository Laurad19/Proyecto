using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeTaller
{
    class Producto
    {
        private string _codigo;
        private string _nombre;
        private string _descripcion;
        private int _cantidad;
        private double _costo;

        public Producto(string codigo, string nombre)
        {
            _codigo = codigo;
            _nombre = nombre;
        }

        public string Codigo { get { return _codigo; } }
        public string Nombre { get { return _nombre; } }
        public string Descripcion 
        { 
            set {_descripcion=value; } 
            get { return _descripcion; }
        }
        public int Cantidad
        {
            set { _cantidad = value; }
            get { return _cantidad; }
        }
        public double Costo
        {
            set { _costo = value; }
            get { return _costo; }
        }
        public double Valormercancia
        {
            get { return _cantidad * _costo; }
        }
        public override string ToString()
        {
            return "Codigo:" + _codigo + "Nombre:" + _nombre + "Valor total:" + Valormercancia;
        }
    }
}


