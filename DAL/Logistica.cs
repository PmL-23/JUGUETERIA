using System;
using System.CodeDom.Compiler;
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
            Conexion objConexion = new Conexion(); //instanciamops el objeto que nos conectará con la Base de datos 
            string costoString = Costo.ToString(CultureInfo.InvariantCulture);  //debido a cuestios de COMPATIBILIDAD y de FORMATO, pasamos el Costo 
            string precioString = PrecioVenta.ToString(CultureInfo.InvariantCulture);//y el PrecioVenta a string para envialos correctamente BDD. 
            
            //guardamos el INSERT a hacer en la Base de Datos en un string 
            string sqlCommand = "insert PRODUCTO([_IDCreadorProducto], [_NombreProducto], [_IDProducto], [_Costo], [_FechaCreacion], [_Precio], [_CantidadEnStock], [_CantidadMinimaPermitida]) values('"+IDCreadorusuario+"', '"+NombreProducto+"', '"+IDProducto+"', "+ costoString + ", '"+FechaCreacion+"', "+precioString+", "+CantidadStock+", "+CantidadMinimaPermitida+")";
            
            int filasAfectadas = objConexion.EscribirPorComando(sqlCommand); //le damos el string a EscribirPorComandom, el cual hace el INSERT.
                                                                            // y nos devuelve cuantas filas ingreso o modifico.
            if (filasAfectadas > 0)
            {
                return true;    //si modificamos más de una fila, que sera 1, significa que si se ejecuto el INSERT, por lo que devolvemos true
            }
            return false;//si filasAfectadas NO es mayor a 0, significa que no se afectaron filas, por lo que no se hizo el INSERT, y devolvemos false
        }


        public bool EditarProducto(string NombreProducto, decimal Costo, decimal Precio, int CantidadEnStock, int CantidadMinimaPermitida, string IDProducto)
        {
            Conexion objConexion = new Conexion();//instanciamops el objeto que nos conectará con la Base de datos 


            string costoString = Costo.ToString(CultureInfo.InvariantCulture);//debido a cuestios de COMPATIBILIDAD y de FORMATO, pasamos el Costo
            string precioString = Precio.ToString(CultureInfo.InvariantCulture);//y el PrecioVenta a string para envialos correctamente BDD.

            // armamos el UPDATE a hacer en la Base de Datos y lo guardamos en un string
            string sqlCommand = "UPDATE PRODUCTO SET " +                        
                                "[_NombreProducto] = '" + NombreProducto + "', " +
                                "[_Costo] = " + costoString + ", " +
                                "[_Precio] = " + precioString + ", " +
                                "[_CantidadEnStock] = " + CantidadEnStock + ", " +
                                "[_CantidadMinimaPermitida] = " + CantidadMinimaPermitida + " " +
                                "WHERE _IDProducto = '" + IDProducto + "'";

            int filasAfectadas = objConexion.EscribirPorComando(sqlCommand);//le damos el string a EscribirPorComandom, el cual hace el INSERT.
                                                                            // y nos devuelve cuantas filas ingreso o modifico.
            if (filasAfectadas > 0)
            {
                return true;// si modificamos más de una fila, que sera 1, significa que si se ejecuto el UPDATE, por lo que devolvemos true
            }
            return false;//si filasAfectadas NO es mayor a 0, significa que no se afectaron filas, por lo que no se hizo el UPDATE, y devolvemos false
        }


        public bool EliminarProducto(string IDProducto)
        {
            Conexion objConexion = new Conexion();//instanciamops el objeto que nos conectará con la Base de datos 
            try     //usamero un try para intentar eliminar el procto, ya que si se intenta eliminar un producto que esta relacionado 
            {       //con otro tabla de la BDD, se lanzara la exepcion y devolveremos que no se pudo eliminar
                int filasAfectadas = objConexion.EscribirPorComando("delete PRODUCTO where [_IDProducto] = '" + IDProducto + "'");
                //hacemos el DELETE, el EscribirPorComando se encarga de lanzar la exepcion por si no se puede eliminar el producto por una 
                //relacion del producto con otra tabla de la Base de Datos
                        // y nos devuelve cuantas filas ingreso o modifico.
                if (filasAfectadas > 0)
                {
                    return true;// si modificamos más de una fila, que sera 1, significa que si se ejecuto el delete, por lo que devolvemos true
                }
                else
                {
                    return false;//si filasAfectadas NO es mayor a 0, significa que no se afectaron filas, por lo que no se hizo el DELETE, y devolvemos false
                }
            }
            catch
            {
                return false;// atrapamos la exepcion que lanzo EscribirPorComando, y devolvemos falso, ya que significa que no pudo eliminar el producto
            }
        }

        public bool ControlarStock(string nombreproducto, int stockdisponible, int stockminimoideal, string IDProducto)
        {
            Conexion objConexion = new Conexion();//instanciamops el objeto que nos conectará con la Base de datos 
            int filasAfectadas = objConexion.EscribirPorComando("UPDATE PRODUCTO SET [_NombreProducto] ='"+nombreproducto+ "', [_CantidadEnStock] ="+stockdisponible+ ", [_CantidadMinimaPermitida]= "+stockminimoideal+"where _IDProducto= '"+IDProducto+"'");
            //usamos EscribirPorComando para mandale el UPDATE requerido.
            // y nos devuelve cuantas filas ingreso o modifico.
            if (filasAfectadas > 0)
            {
                return true;// si modificamos más de una fila, que sera 1, significa que si se ejecuto el UPDATE, por lo que devolvemos true
            }
            return false;//si filasAfectadas NO es mayor a 0, significa que no se afectaron filas, por lo que no se hizo el DELETE, y devolvemos false
        }

        public DataTable VerAlertarBajoStock() 
        {
            Conexion objConexion = new Conexion();//instanciamops el objeto que nos conectará con la Base de datos
            return objConexion.LeerPorComando("SELECT [_IDCreadorProducto],[_NombreProducto],[_IDProducto],[_Costo],[_FechaCreacion],[_Precio],[_CantidadEnStock],[_CantidadMinimaPermitida] from [BDDJ].[dbo].[PRODUCTO] where _CantidadEnstock < _CantidadMinimaPermitida");
            //Directamente se retorna el select, ya que el LeerPorComando devuelve un DataTable.
        }

        #endregion


        #region Metodos Auxiliares
        public bool VerSiExisteProducto(string IDProducto)
        {
            Conexion objConexion = new Conexion();//instanciamops el objeto que nos conectará con la Base de datos

            DataTable dt = objConexion.LeerPorComando("SELECT [_IDProducto] FROM [BDDJ].[dbo].[PRODUCTO] WHERE [_IDProducto] is not null");
            //guardamos en dt un DataTable de TODOS los productos de la Base de Datos.
            foreach (DataRow fila in dt.Rows)//recorremos el dt.
            {
                if (fila["_IDProducto"].ToString() == IDProducto)       
                {
                    return true;    //si lo que trajimos de la BDD, coincide con el parametro pasado, retornamos true.
                }
            }
            return false;//si nada de lo que trajimos de la BDD coincide con el parametro pasado, retornamos false.
        }


        public DataTable TraerUnProducto(string idproducto)
        {
            Conexion objConexion = new Conexion();//instanciamops el objeto que nos conectará con la Base de datos
            return objConexion.LeerPorComando("SELECT [_IDCreadorProducto],[_NombreProducto],[_IDProducto],[_Costo],[_FechaCreacion],[_Precio],[_CantidadEnStock],[_CantidadMinimaPermitida] FROM [BDDJ].[dbo].[PRODUCTO] WHERE [_IDProducto]= '" + idproducto + "' ");
            //Directamente se retorna el select, ya que el LeerPorComando devuelve un DataTable.
        }

        public DataTable TraerListaProductos()
        {
            Conexion objConexion = new Conexion();//instanciamops el objeto que nos conectará con la Base de datos
            return objConexion.LeerPorComando("SELECT [_IDCreadorProducto],[_NombreProducto],[_IDProducto],[_Costo],[_FechaCreacion],[_Precio],[_CantidadEnStock],[_CantidadMinimaPermitida] FROM [BDDJ].[dbo].[PRODUCTO] WHERE [_IDProducto] is not null ");
            //Directamente se retorna el select, ya que el LeerPorComando devuelve un DataTable.
        }


        #endregion

    }
}
