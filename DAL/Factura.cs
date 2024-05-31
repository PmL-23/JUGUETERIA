using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Factura
    {
        public bool NuevaFactura(string idVendedorFactura, string idClienteFactura, string date, decimal total)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("INSERT into [BDDJ].[dbo].[FACTURA] ([_IDVendedorFactura], [_IDClienteFactura], [_FechaEmision], [_Total]) values ('" + idVendedorFactura + "', '" + idClienteFactura + "', '" + date + "', " + total + ");");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }

        public DataTable TraerIDFactura() { 
            Conexion conexion = new Conexion();

            DataTable dt = conexion.LeerPorComando("SELECT [FACTURA]._IDFactura FROM [BDDJ].[dbo].[FACTURA] ORDER BY FACTURA._IDFactura ASC;");

            return dt;
        }

    }
}
