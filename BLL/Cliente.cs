using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
        private string _Nombre;
        private string _Apellido;
        private string _IDCliente;
        private string _CantidadCompras;
        private string _Dni;

        #region Props
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public string IDCliente
        {
            get { return _IDCliente; }
            set { _IDCliente = value; }
        }
        public string CantidadCompras
        {
            get { return _CantidadCompras; }
            set { _CantidadCompras = value; }
        }
        public string DNI
        {
            get { return _Dni; }
            set { _Dni = value; }
        }
        #endregion

        public Cliente()
        {
        }
    }
}
