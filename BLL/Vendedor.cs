using System;
using System.Collections.Generic;
using System.Data;
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

            if (cliente.RegistrarCliente(idCliente, nombre, apellido, dni, cantidadCompras))
            {
                return true;
            }

            return false;
        }

        public List<Factura> TraerListaFacturas(string _IDCliente)
        {
            List<Factura> ListaFactura = new List<Factura>();

            DAL.Vendedor vendedor = new DAL.Vendedor();

            DataTable vendedorbd = vendedor.TraerListaFacturas(_IDCliente);//HACER



            foreach (DataRow row in vendedorbd.Rows)
            {
                Factura FacturaALista = new Factura();
                FacturaALista.IDVendedor = row["_IDVendedorFactura"].ToString();
                FacturaALista.IDCliente = row["_IDClienteFactura"].ToString();
                FacturaALista.IDFactura = row["_IDFactura"].ToString();
                FacturaALista.FechaEmision = row["_FechaEmision"].ToString();
                FacturaALista.Total = Convert.ToDecimal(row["_Total"]);
                ListaFactura.Add(FacturaALista);
            }
            return ListaFactura;
        }

        public bool AumentarCantVentas(string idVendedor) {
            DAL.Vendedor vendedor = new DAL.Vendedor();

            return vendedor.AumentarCantVentas(idVendedor);
        }

        public Vendedor()
        {

        }
    }
}
