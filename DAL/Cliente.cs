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

        public bool EliminarCliente(string IDCliente)//Este método se utiliza para elimina un ID de Cliente seleccionado
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("delete CLIENTES where [_IDCliente] = '" + IDCliente + "'");
            //Se elimina de la base de datos el ID de Cliente seleccionado
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
