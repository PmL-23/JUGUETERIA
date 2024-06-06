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

        private int _CantidadVentas;

        public int CantidadVentas
        {
            get { return _CantidadVentas; }
            set { _CantidadVentas = value; }
        }

        public bool RegistrarCliente(string idCliente, string nombre, string apellido, long dni, long cantidadCompras)
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
                FacturaALista.Vendedor.NombreUsuario = row["_IDVendedorFactura"].ToString();
                FacturaALista.Cliente._IDCliente = row["_IDClienteFactura"].ToString();
                FacturaALista.IDFactura = row["_IDFactura"].ToString();
                FacturaALista.FechaEmision = row["_FechaEmision"].ToString();
                FacturaALista.Total = Convert.ToDecimal(row["_Total"]);
                ListaFactura.Add(FacturaALista);
            }
            return ListaFactura;
        }

        public List<DetalleFactura> TraerDetallesFactura(string idFactura) { 
            
            List<DetalleFactura> listaDetalles = new List<DetalleFactura>();

            DAL.Vendedor vend = new DAL.Vendedor();

            DataTable dataTable = vend.TraerDetallesFactura(idFactura);

            foreach (DataRow row in dataTable.Rows)
            {
                DetalleFactura detFactura = new DetalleFactura();

                detFactura.Factura.IDFactura = row["_IDFactura"].ToString();
                detFactura.Producto.IDProducto = row["_IDProducto"].ToString();
                detFactura.Producto.Precioventa = decimal.Parse(row["_PrecioUnitario"].ToString());
                detFactura.Cantidad = int.Parse(row["_Cantidad"].ToString());

                listaDetalles.Add(detFactura);
            }

            return listaDetalles;
        }

        public bool AumentarCantVentas(string idVendedor) {
            DAL.Vendedor vendedor = new DAL.Vendedor();

            return vendedor.AumentarCantVentas(idVendedor);
        }

        public bool GenerarFactura(string idVendedor, string idCliente, string date, decimal total)
        {
            DAL.Vendedor vend = new DAL.Vendedor();

            if (vend.GenerarFactura(idVendedor, idCliente, date, total) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Factura> VerHistorialVendedor(string idVendedor) {

            List<Factura> ListaFactura = new List<Factura>();

            DAL.Vendedor vendedor = new DAL.Vendedor();

            DataTable vendedorbd = vendedor.VerHistorialVendedor(idVendedor);

            foreach (DataRow row in vendedorbd.Rows)
            {
                Factura FacturaALista = new Factura();
                FacturaALista.Vendedor.NombreUsuario = row["_IDVendedorFactura"].ToString();
                FacturaALista.Cliente._IDCliente = row["_IDClienteFactura"].ToString();
                FacturaALista.IDFactura = row["_IDFactura"].ToString();
                FacturaALista.FechaEmision = row["_FechaEmision"].ToString();
                FacturaALista.Total = Convert.ToDecimal(row["_Total"]);
                ListaFactura.Add(FacturaALista);
            }

            return ListaFactura;
        }

        public Vendedor()
        {

        }
    }
}
