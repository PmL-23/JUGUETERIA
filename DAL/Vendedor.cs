using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Vendedor : Empleado
    {
        public bool VerHistorialCliente(string idCliente)
        {
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorComando("SELECT [_IdCliente] FROM [BDDJ].[dbo].[CLIENTES]");
            foreach (DataRow fila in dt.Rows)
            {
                if (fila["_IdCliente"].ToString() == idCliente)
                {
                    return true;
                }
            }

            return false;
        }

        public bool RegistrarCliente(string idCliente, string nombre, string apellido, int dni, int cantidadCompras)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("INSERT into [BDDJ].[dbo].[CLIENTES] ([_Nombre], [_Apelldo], [_IDCliente], [_CantidadCompras], [_DNI]) values ('"+nombre+"', '"+apellido+"', '"+idCliente+"', "+cantidadCompras+", "+dni+");");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }

    }
}