using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Logistica
    {


        #region Metodos Principales
        public bool CargarProducto(string IDCreadorusuario, string NombreProducto, string IDProducto, decimal Costo, string FechaCreacion, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida)
        { 
            Conexion objConexion = new Conexion();
            string costoString = Costo.ToString(CultureInfo.InvariantCulture);
            string precioString = PrecioVenta.ToString(CultureInfo.InvariantCulture);

            string sqlCommand = "insert PRODUCTO([_IDCreadorProducto], [_NombreProducto], [_IDProducto], [_Costo], [_FechaCreacion], [_Precio], [_CantidadEnStock], [_CantidadMinimaPermitida]) values('"+IDCreadorusuario+"', '"+NombreProducto+"', '"+IDProducto+"', "+ costoString + ", '"+FechaCreacion+"', "+precioString+", "+CantidadStock+", "+CantidadMinimaPermitida+")";


            int filasAfectadas = objConexion.EscribirPorComando(sqlCommand);

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }




        public bool EditarProducto(string NombreProducto, decimal Costo, decimal Precio, int CantidadEnStock, int CantidadMinimaPermitida, string IDProducto)
        {
            Conexion objConexion = new Conexion();

            // Convertir los valores decimales a string con el formato de punto decimal
            string costoString = Costo.ToString(CultureInfo.InvariantCulture);
            string precioString = Precio.ToString(CultureInfo.InvariantCulture);

            // Construir la cadena SQL usando los valores con punto decimal
            string sqlCommand = "UPDATE PRODUCTO SET " +
                                "[_NombreProducto] = '" + NombreProducto + "', " +
                                "[_Costo] = " + costoString + ", " +
                                "[_Precio] = " + precioString + ", " +
                                "[_CantidadEnStock] = " + CantidadEnStock + ", " +
                                "[_CantidadMinimaPermitida] = " + CantidadMinimaPermitida + " " +
                                "WHERE _IDProducto = '" + IDProducto + "'";

            int filasAfectadas = objConexion.EscribirPorComando(sqlCommand);

            if (filasAfectadas > 0)
            {
                return true;
            }
            return false;
        }


        public bool EliminarProducto(string IDProducto)
        {
            Conexion objConexion = new Conexion();
            try
            {
                int filasAfectadas = objConexion.EscribirPorComando("delete PRODUCTO where [_IDProducto] = '" + IDProducto + "'");


                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ControlarStock(string nombreproducto, int stockdisponible, int stockminimoideal, string IDProducto)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("UPDATE PRODUCTO SET [_NombreProducto] ='"+nombreproducto+ "', [_CantidadEnStock] ="+stockdisponible+ ", [_CantidadMinimaPermitida]= "+stockminimoideal+"where _IDProducto= '"+IDProducto+"'");

            if (filasAfectadas > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable VerAlertarBajoStock() 
        {
            Conexion objConexion = new Conexion();
            return objConexion.LeerPorComando("SELECT [_IDCreadorProducto],[_NombreProducto],[_IDProducto],[_Costo],[_FechaCreacion],[_Precio],[_CantidadEnStock],[_CantidadMinimaPermitida] from [BDDJ].[dbo].[PRODUCTO] where _CantidadEnstock < _CantidadMinimaPermitida");
        }

        #endregion


        #region Metodos Auxiliares
        public bool VerSiExisteProducto(string IDProducto)
        {
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorComando("SELECT [_IDProducto] FROM [BDDJ].[dbo].[PRODUCTO] WHERE [_IDProducto] is not null");
            foreach (DataRow fila in dt.Rows)
            {
                if (fila["_IDProducto"].ToString() == IDProducto)
                {
                    return true;
                }
            }
            return false;
        }


        public DataTable TraerUnProducto(string idproducto)
        {
            Conexion objConexion = new Conexion();
            return objConexion.LeerPorComando("SELECT [_IDCreadorProducto],[_NombreProducto],[_IDProducto],[_Costo],[_FechaCreacion],[_Precio],[_CantidadEnStock],[_CantidadMinimaPermitida] FROM [BDDJ].[dbo].[PRODUCTO] WHERE [_IDProducto]= '" + idproducto + "' ");
        }

        public DataTable TraerListaProductos()
        {
            Conexion objConexion = new Conexion();
            return objConexion.LeerPorComando("SELECT [_IDCreadorProducto],[_NombreProducto],[_IDProducto],[_Costo],[_FechaCreacion],[_Precio],[_CantidadEnStock],[_CantidadMinimaPermitida] FROM [BDDJ].[dbo].[PRODUCTO] WHERE [_IDProducto] is not null ");
        }


        #endregion

    }
}
