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
		private List<DetalleFactura> _ListaDetalles = new List<DetalleFactura>();
		private Cliente _Cliente = new Cliente();
		private Vendedor _Vendedor = new Vendedor();

		#region Props
		public Cliente Cliente
		{
			get { return _Cliente; }
			set { _Cliente = value; }
		}

		public Vendedor Vendedor
		{
			get { return _Vendedor; }
			set { _Vendedor = value; }
		}

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

		public Factura()
		{

		}
        #region Métodos Principales

		public decimal CalcularTotal() {

			this.Total = 0;

            foreach (DetalleFactura item in this.ListaDetalles)
            {
				this.Total += (item.Producto.Precioventa * 1.21M) * item.Cantidad;
            }

            return this.Total;
		}

		public void AgregarProductos(string idProducto, int cantidad, decimal precioUnitario) { 

			DetalleFactura detalle = new DetalleFactura();
			detalle.Producto.IDProducto = idProducto;
			detalle.Cantidad = cantidad;
			detalle.Producto.Precioventa = precioUnitario;

			this.ListaDetalles.Add(detalle);
		}

		public void SacarProductos(int index) {

			this.ListaDetalles.Remove(this.ListaDetalles[index]);

        }

        #endregion

        #region Métodos Auxiliares

        public decimal CalcularSubtotal() {

            this.Total = 0;

            foreach (DetalleFactura item in this.ListaDetalles)
            {
                this.Total += item.Producto.Precioventa * item.Cantidad;
            }

            return this.Total;
        }

		public void SetIDFacturaADetalleFactura() {
			DAL.Factura factura = new DAL.Factura();
			
			DataTable datatable = factura.TraerIDFactura();

			string UltimoIDFactura = "";

            foreach (DataRow fila in datatable.Rows)
            {
				UltimoIDFactura = fila[0].ToString();
            }

            foreach (DetalleFactura item in this.ListaDetalles)
            {
				item.Factura.IDFactura = UltimoIDFactura;
            }
		}

        public bool EliminarFactura()//Este método elimina la última factura ingresada
        {
            DAL.Factura unaFactura = new DAL.Factura();

            if (unaFactura.EliminarFactura())
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
