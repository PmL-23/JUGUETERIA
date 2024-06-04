using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Factura
    {
		private string _IDFactura;
		private string _FechaEmision;
		private decimal _Total;
		private string _IDVendedor;
		private string _IDCliente;
		private List<DetalleFactura> _ListaDetalles = new List<DetalleFactura>();

		#region Props
		public string IDFactura
		{
			get { return _IDFactura; }
			set { _IDFactura = value; }
		}


		public List<DetalleFactura> ListaDetalles
		{
			get { return _ListaDetalles; }
			set { _ListaDetalles = value; }
		}


		public string IDCliente
		{
			get { return _IDCliente; }
			set { _IDCliente = value; }
		}


		public string IDVendedor
		{
			get { return _IDVendedor; }
			set { _IDVendedor = value; }
		}

		public decimal Total
		{
			get { return _Total; }
			set { _Total = value; }
		}

		public string FechaEmision
		{
			get { return _FechaEmision; }
			set { _FechaEmision = value; }
		}

		#endregion

		public decimal CalcularTotal() {

			this.Total = 0;

            foreach (DetalleFactura item in this.ListaDetalles)
            {
				this.Total += item.PrecioUnitario * item.Cantidad;
            }

            return this.Total;
		}

		public void AgregarProductos(string idProducto, int cantidad, decimal precioUnitario) { 

			DetalleFactura detalle = new DetalleFactura();
			detalle.IDProducto = idProducto;
			detalle.Cantidad = cantidad;
			detalle.PrecioUnitario = precioUnitario;

			this.ListaDetalles.Add(detalle);
		}

		public void SacarProductos(int index) {

			this.ListaDetalles.Remove(this.ListaDetalles[index]);

        }

		public void SetIDFacturaADetalleFactura() {
			DAL.Factura factura = new DAL.Factura();
			
			DataTable datatable = factura.TraerIDFactura();

			int UltimoIDFactura = 0;

            foreach (DataRow fila in datatable.Rows)
            {
				UltimoIDFactura = int.Parse(fila[0].ToString());
            }

            foreach (DetalleFactura item in this.ListaDetalles)
            {
				item.IDFactura = UltimoIDFactura;
            }
		}
		public Factura()
		{

		}
    }
}
