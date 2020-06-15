using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeTaller
{
    class Cliente
    {
        private string _RFC;
        private string _nombre;
        private string _domicilio;
        private int _telefono;
        private string _correo;

        public Cliente(string RFC, string nombre)
        {
            _RFC = RFC;
            _nombre = nombre;
        }

        public string RFC { get { return _RFC; } }
        public string Nombre { get { return _nombre; } }
        public string domicilio
        {
            set { _domicilio = value; }
            get { return _domicilio; }
        }
        public string Correo
        {
            set { _correo = value; }
            get { return _correo; }
        }
        public int Telefono
        {
            set { _telefono = value; }
            get { return _telefono; }
        }
        
        public override string ToString()
        {
            return "RFC:" + _RFC + "Nombre:" + _nombre + "Telefono:" + Telefono;
        }
    }
}
