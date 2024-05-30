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
                                                                                //METODOS PRINCIPALES

        public bool CargarProducto(string IDCreadorusuario, string NombreProducto, string IDProducto, float Costo, string FechaCreacion, float PrecioVenta, int CantidadStock, int CantidadMinimaPermitida)
        { 
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("insert PRODUCTO([_IDCreadorProducto],[_NombreProducto],[_IDProducto],[_Costo],[_FechaCreacion],[_Precio],[_CantidadEnStock],[_CantidadMinimaPermitida]) values ('"+IDCreadorusuario+"','"+NombreProducto+"','"+IDProducto+"', "+Costo+" ,'"+FechaCreacion+"', "+PrecioVenta+" , "+CantidadStock+" , "+CantidadMinimaPermitida+" )");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }

        public bool EditarProducto(string NombreProducto, float Costo, float Precio, int CantidadEnStock, int CantidadMinimaPermitida, string IDProducto)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("UPDATE PRODUCTO SET [_NombreProducto] = '"+NombreProducto+"', [_Costo]= "+ Costo + ", [_Precio]="+ Precio + ", [_CantidadEnStock]="+ CantidadEnStock + ", [_CantidadMinimaPermitida]="+ CantidadMinimaPermitida + " where _IDProducto= '"+IDProducto+"'");

            if (filasAfectadas > 0)
            {
                return true;
            }
            return false;
        }

        public bool EliminarProducto(string IDProducto)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("delete PRODUCTO where [_IDProducto] = '"+IDProducto+"'");

            if (filasAfectadas > 0)
            {
                return true;
            }
            return false;
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





        public DataTable VerAlertarBajoStock() //pedir ayuda a patricio para haecr esto, ya que el hizo algo muy parecido.
                                            {
                                                Conexion objConexion = new Conexion(); //(fila de abajo) creo que deberia ser otro tipo de declaracion
                                                return objConexion.LeerPorComando("SELECT [_NombreProducto], [_IDProducto], [_Costo], [_Precio], [_CantidadEnStock], [_CantidadMinimaPermitida] from [BDDJ].[dbo].[PRODUCTO] where _CantidadEnstock < _CantidadMinimaPermitida");
                                            }

                                                                        //METODOS AUXILIARES


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

    }
}
