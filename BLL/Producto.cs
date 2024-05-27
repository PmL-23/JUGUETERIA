using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class Producto
    {
		private string _NombreProducto;

		public string NombreProducto
		{
			get { return _NombreProducto; }
			set { _NombreProducto = value; }
		}

		private string _IDProducto;

		public string IDProducto
		{
			get { return _IDProducto; }
			set { _IDProducto = value; }
		}

		private float _Costo;

		public float Costo
		{
			get { return _Costo; }
			set { _Costo = value; }
		}
		private string _FechaDeCreacion;

		public string  FechaDeCreacion
		{
			get { return _FechaDeCreacion; }
			set { _FechaDeCreacion = value; }
		}
        private float _PrecioVenta;

        public float Precioventa
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }

        private int _CantidadEnStock;

		public int CantidadEnStock
		{
			get { return _CantidadEnStock; }
			set { _CantidadEnStock = value; }
		}

		private int _CantidadMinimaPermitida;

		public int CantidadMinimaPermitida
		{
			get { return _CantidadMinimaPermitida; }
			set { _CantidadMinimaPermitida = value; }
		}
		private string _IDCreadorProducto;

		public string IDCreadorProducto
		{
			get { return _IDCreadorProducto; }
			set { _IDCreadorProducto = value; }
		}

		public Producto(string nombreproducto, string idproducto, float costo, string fechadecreacion, float precioventa, int cantidadenstock, int cantidadminimapermitida, string idcreadorproducto)
		{
			this.NombreProducto = nombreproducto;
			this.IDProducto = idproducto;	
			this.Costo = costo;
			this.FechaDeCreacion = fechadecreacion;
			this.Precioventa = precioventa;
			this.CantidadEnStock=cantidadenstock;
			this.CantidadMinimaPermitida=cantidadminimapermitida;
			this.IDCreadorProducto=idcreadorproducto;
		}

		public Producto() {
		}


    }
}
