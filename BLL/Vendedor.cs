using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class Vendedor
    {
        private string idVendedor;

        public string IdVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }


        private string cantidadVentas;

        public string CantidadVentas
        {
            get { return cantidadVentas; }
            set { cantidadVentas = value; }
        }

        public Vendedor()
        {

        }
    }
}
