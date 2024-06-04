using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleFactura
    {
        public bool InsertarDetallesFactura(int idFactura, string idProducto, decimal precioUnitario, int cantidad) { 

            Conexion objConexion = new Conexion();

            string precioUnitarioString = precioUnitario.ToString(CultureInfo.InvariantCulture);

            int filasAfectadas = objConexion.EscribirPorComando("INSERT INTO [BDDJ].[dbo].[DETALLE_FACTURA] ([_IDFactura], [_IDProducto], [_PrecioUnitario], [_Cantidad]) VALUES ("+idFactura+", '"+idProducto+"', "+precioUnitarioString+", "+cantidad+");");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }

        public bool DecrementarStockPosventa(int cantComprada, string productID)
        {

            Conexion objConexion = new Conexion();

            int filasAfectadas = objConexion.EscribirPorComando("UPDATE [BDDJ].[dbo].[PRODUCTO] SET _CantidadEnStock = _CantidadEnStock - "+cantComprada+" WHERE _IDProducto = '"+productID+"';");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;

        }
    }
}
