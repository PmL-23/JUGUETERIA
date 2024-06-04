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
    }
}
