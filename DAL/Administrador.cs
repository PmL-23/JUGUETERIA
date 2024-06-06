using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Administrador
    {
        public DataTable ListarEmpleados()
        {
            Conexion objConexion = new Conexion();

            return objConexion.LeerPorComando("SELECT [USUARIOS].[_Nombre] AS Nombre, [USUARIOS].[_Apellido] AS Apellido,[USUARIOS].[_DNI] AS DNI,[USUARIOS].[_NombreUsuario] AS NombreDeUsuario,[EMPLEADOS].[_Rol] AS Rol,[EMPLEADOS].[_Sueldo] AS Sueldo,[EMPLEADOS].[_Habilitado] AS Estado FROM [BDDJ].[dbo].[USUARIOS] JOIN [BDDJ].[dbo].[EMPLEADOS] ON [USUARIOS]._NombreUsuario = [EMPLEADOS].[_IDEmpleado];");
        }

        public bool ActualizarDatosUsuario(string rolPrevio, string nombreUsuario, string Rol, string Estado, decimal Sueldo)
        {
            Conexion actualizarDatosDeEmpleado = new Conexion();

            string sueldoToString = Sueldo.ToString(CultureInfo.InvariantCulture);
            int filasAfectadas = actualizarDatosDeEmpleado.EscribirPorComando("UPDATE [BDDJ].[dbo].[EMPLEADOS] SET [_Rol] = '" + Rol + "', [_Habilitado] = '" + Estado + "', [_Sueldo] = " + sueldoToString + " WHERE [EMPLEADOS].[_IDEmpleado] = '" + nombreUsuario + "';");

            if (filasAfectadas > 0)
            {
                Conexion verificarExistenciaIdEnTabla = new Conexion();
                DataTable rowsAfectados = new DataTable();
                int flagRolIndefinido = 0;

                if (Rol != "Indefinido")
                {
                    rowsAfectados = verificarExistenciaIdEnTabla.LeerPorComando("SELECT * FROM [BDDJ].[dbo].[" + Rol.ToUpper() + "] WHERE [_ID" + Rol + "] = '" + nombreUsuario + "';");
                }
                else 
                { 
                    flagRolIndefinido++;
                }

                if (rowsAfectados.Rows.Count == 0 || flagRolIndefinido > 0)
                {
                    Conexion agregarIdEnTablaCorrespondiente = new Conexion();

                    if (Rol == "Vendedor")
                    {
                        agregarIdEnTablaCorrespondiente.EscribirPorComando("INSERT into [BDDJ].[dbo].[" + Rol.ToUpper() + "] ([_ID" + Rol + "], [_CantidadVentas]) values ('" + nombreUsuario + "', 0)");
                    }
                    else
                    {
                        if (Rol != "Indefinido")
                        {
                            agregarIdEnTablaCorrespondiente.EscribirPorComando("INSERT into [BDDJ].[dbo].[" + Rol.ToUpper() + "] ([_ID" + Rol + "]) values ('" + nombreUsuario + "')");
                        }
                    }

                    if (rolPrevio != "Indefinido")
                    {
                        Conexion quitarIdDeTablaPrevia = new Conexion();
                        quitarIdDeTablaPrevia.EscribirPorComando("DELETE FROM [BDDJ].[dbo].["+ rolPrevio.ToUpper() + "] WHERE [_ID" + rolPrevio + "] = '"+nombreUsuario+"';");
                    }
                }

                return true;
            }

            return false;
        }

        public DataTable TraerListaVendedores()
        {
            Conexion objConexion = new Conexion();
            return objConexion.LeerPorComando("SELECT [_Nombre], [_Apellido], [_IDEmpleado], [_Sueldo], [_Habilitado], [_CantidadVentas] FROM USUARIOS u JOIN EMPLEADOS e ON u._NombreUsuario = _IDEmpleado join VENDEDOR v on e._IDEmpleado= _IDVendedor order by [_CantidadVentas]");

        }


    }
}
