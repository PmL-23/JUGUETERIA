using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class Cliente
    {
        private string _idCliente;

        public string _IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        private string _cantidadCompras;

        public string _CantidadCompras
        {
            get { return _cantidadCompras; }
            set { _cantidadCompras = value; }
        }

        private string _nombre;

        public string _Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string _Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public Cliente()
        {
        }
    }
}
