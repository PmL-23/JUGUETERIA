using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
        private string _idCliente;

        public string _IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
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

        private string _dni;

        public string _DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }


        private int _cantidadCompras;

        public int _CantidadCompras
        {
            get { return _cantidadCompras; }
            set { _cantidadCompras = value; }
        }

        public Cliente(string idCliente, string nombre, string apellido, string dni, int cantidadCompras)
        {
            this._IDCliente = idCliente;
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._DNI = dni;
            this._CantidadCompras = cantidadCompras;
           
        }
        public Cliente()
        {
        }
    }
}
