using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Factura
    {
        public DataTable TraerIDFactura() { 
            Conexion conexion = new Conexion();

            DataTable dt = conexion.LeerPorComando("SELECT [FACTURA]._IDFactura FROM [BDDJ].[dbo].[FACTURA] ORDER BY FACTURA._IDFactura ASC;");

            return dt;
        }


        public bool EliminarFactura()//Este método elimina la última factura ingresada 
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("DELETE FROM FACTURA WHERE [_IDFACTURA] = (SELECT MAX([_IDFACTURA]) FROM FACTURA)");
            //Se crea una consulta en la base de datos, que elimina el ultimo registro de FACTURA
            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
