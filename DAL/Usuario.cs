using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario
    {
        public bool IniciarSesion(string nombreUsuario, string contrasenia)
        {
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorComando("SELECT [_Nombre], [_Apellido], [_DNI], [_Contraseña], [_NombreUsuario] FROM [BDDJ].[dbo].[USUARIOS]");
            foreach (DataRow fila in dt.Rows)
            {
                if (fila["_NombreUsuario"].ToString() == nombreUsuario && fila["_Contraseña"].ToString() == contrasenia)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
