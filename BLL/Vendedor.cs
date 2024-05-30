using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vendedor : Empleado
    {

        private string _CantidadVentas;

        public string CantidadVentas
        {
            get { return _CantidadVentas; }
            set { _CantidadVentas = value; }
        }

        public bool RegistrarCliente(string idCliente, string nombre, string apellido, int dni, int cantidadCompras)
        {
            DAL.Vendedor cliente = new DAL.Vendedor();

            if (cliente.AgregarCliente(idCliente ,nombre, apellido, dni, cantidadCompras))
            {
                return true;
            }

            return false;
        }

        public Vendedor()
        {

        }
    }
}
