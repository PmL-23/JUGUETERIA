using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleFactura
    {
		private int _IDFactura;
		private string _IDProducto;
		private decimal _PrecioUnitario;
		private int _Cantidad;

        #region Props
        public int Cantidad
		{
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}


		public decimal PrecioUnitario
		{
			get { return _PrecioUnitario; }
			set { _PrecioUnitario = value; }
		}


		public string IDProducto
		{
			get { return _IDProducto; }
			set { _IDProducto = value; }
		}


		public int IDFactura
		{
			get { return _IDFactura; }
			set { _IDFactura = value; }
		}
        #endregion

        public bool InsertarDetallesFactura(List<DetalleFactura> ListaDetalles)
        {
            DAL.DetalleFactura detFactura = new DAL.DetalleFactura();

            foreach (DetalleFactura item in ListaDetalles)
            {
                if (detFactura.InsertarDetallesFactura(item.IDFactura, item.IDProducto, item.PrecioUnitario, item.Cantidad) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public bool DecrementarStockPosventa(List<DetalleFactura> ListaDetalles)
        {
            DAL.DetalleFactura detFactura = new DAL.DetalleFactura();

            foreach (DetalleFactura item in ListaDetalles)
            {
                if (detFactura.DecrementarStockPosventa(item.Cantidad, item.IDProducto) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
