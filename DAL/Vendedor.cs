using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Vendedor
    {
        public bool RegistroCliente(string idCliente)
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
        public bool AgregarCliente(string nombre, string apellido, string dni)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("UPDATE [BDDJ].[dbo].[EMPLEADOS] SET [_Rol] = '" + Rol + "', [_Habilitado] = '" + Estado + "', [_Sueldo] = " + Sueldo + " WHERE [EMPLEADOS].[_IDEmpleado] = '" + nombreUsuario + "';");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }
    }
}
}
