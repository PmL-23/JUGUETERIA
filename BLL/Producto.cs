using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
    {
		private string _NombreProducto;
		private string _IDProducto;
		private decimal _Costo;
		private string _FechaDeCreacion;
        private decimal _PrecioVenta;
        private int _CantidadEnStock;
		private int _CantidadMinimaPermitida;
		private string _IDCreadorProducto;

        #region Propiedades

        public string NombreProducto
		{
			get { return _NombreProducto; }
			set { _NombreProducto = value; }
		}


		public string IDProducto
		{
			get { return _IDProducto; }
			set { _IDProducto = value; }
		}


		public decimal Costo
		{
			get { return _Costo; }
			set { _Costo = value; }
		}

		public string  FechaDeCreacion
		{
			get { return _FechaDeCreacion; }
			set { _FechaDeCreacion = value; }
		}

        public decimal Precioventa
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }


		public int CantidadEnStock
		{
			get { return _CantidadEnStock; }
			set { _CantidadEnStock = value; }
		}


		public int CantidadMinimaPermitida
		{
			get { return _CantidadMinimaPermitida; }
			set { _CantidadMinimaPermitida = value; }
		}

		public string IDCreadorProducto
		{
			get { return _IDCreadorProducto; }
			set { _IDCreadorProducto = value; }
		}
        #endregion

		public Producto() 
		{

		}
    }
}
