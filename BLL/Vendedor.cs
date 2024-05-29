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

        public Vendedor()
        {

        }
    }
}
