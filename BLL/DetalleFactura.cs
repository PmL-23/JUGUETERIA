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
		private int _Cantidad;
        private Producto _Producto = new Producto();
        private Factura _Factura = new Factura();

        #region Props
        public Factura Factura
        {
            get { return _Factura; }
            set { _Factura = value; }
        }

        public Producto Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }

        public int Cantidad
		{
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}
        #endregion

        public bool InsertarDetallesFactura(List<DetalleFactura> ListaDetalles)
        {
            DAL.DetalleFactura detFactura = new DAL.DetalleFactura();

            foreach (DetalleFactura item in ListaDetalles)
            {
                if (detFactura.InsertarDetallesFactura(int.Parse(item.Factura.IDFactura), item.Producto.IDProducto, item.Producto.Precioventa, item.Cantidad) == false)
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
                if (detFactura.DecrementarStockPosventa(item.Cantidad, item.Producto.IDProducto) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
