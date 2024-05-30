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
        
        public bool AgregarCliente(string idCliente, string nombre, string apellido, string dni,int cantidadCompras)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("UPDATE [BDDJ].[dbo].[CLIENTES] SET [_IDCliente] = '" + idCliente + "', [_Nombre] = '" + nombre + "', [_Apellido] = '" + apellido + "', [_DNI] = '" + dni + "', [_CantidadCompras] = '" + cantidadCompras + "';");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }
        
    }
}