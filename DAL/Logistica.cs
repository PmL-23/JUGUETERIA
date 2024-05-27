using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Logistica
    {
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

        //CREAR CLASE PRODUCTO.
        public bool CargarNuevoProducto(string IDCreadorusuario, string NombreProducto, string IDProducto, float Costo, string FechaCreacion, float PrecioVenta, int CantidadStock, int CantidadMinimaPermitida)
        { 
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("insert PRODUCTO([_IDCreadorProducto],[_NombreProducto],[_IDProducto],[_Costo],[_FechaCreacion],[_Precio],[_CantidadEnStock],[_CantidadMinimaPermitida]) values ('"+IDCreadorusuario+"','"+NombreProducto+"','"+IDProducto+"', "+Costo+" ,'"+FechaCreacion+"', "+PrecioVenta+" , "+CantidadStock+" , "+CantidadMinimaPermitida+" )");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }
        public bool ModificarProducto(string NombreProducto, string IDProducto, float Costo, float PrecioVenta, int CantidadStock, int CantidadMinimaPermitida)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("UPDATE PRODUCTO SET _NombreProducto = '"+NombreProducto+"', _Costo="+Costo+", _Precio="+PrecioVenta+", _CantidadStock="+CantidadStock+ " _CantidadMinimaPermitida= "+CantidadMinimaPermitida+" WHERE _IDProducto= '"+IDProducto+"')");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }

        public bool AumentarStock(string IDProducto, int CantidadStockAAumentar)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("UPDATE PRODUCTO SET _CantidadEnStock= (_CantidadEnStock +" + CantidadStockAAumentar + ") WHERE _IDProducto= '" + IDProducto + "')");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }

        public DataTable VerAlertarBajoStock() //pedir ayuda a patricio para haecr esto, ya que el hizo algo muy parecido.
        {
            Conexion objConexion = new Conexion(); //(fila de abajo) creo que deberia ser otro tipo de declaracion
            return objConexion.LeerPorComando("SELECT [_NombreProducto], [_IDProducto], [_Costo], [_Precio], [_CantidadEnStock], [_CantidadMinimaPermitida] from [BDDJ].[dbo].[PRODUCTO] where _CantidadEnstock<_CantidadMinimaPermitida");
        }

       
    }
}
