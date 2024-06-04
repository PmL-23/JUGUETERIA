using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente
    {
        public DataTable ClienteBase()
        {
            Conexion conexion = new Conexion();

            return  conexion.LeerPorComando("SELECT * FROM [BDDJ].[dbo].[CLIENTES] ");
        }

        public bool AumentarCantCompras(string idCliente) { 
            Conexion con = new Conexion();

            int filasAfectadas = con.EscribirPorComando("UPDATE [BDDJ].[dbo].[CLIENTES] SET [_CantidadCompras] = [_CantidadCompras] + 1 WHERE _IDCliente = '" + idCliente + "';");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }
    }
}
