using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Empleado
    {
        public bool VerSiExisteNombreUsuario(string _NombreUsuarioParametro)
        {
            Conexion objConexion = new Conexion();
                    //HAY UN PROBLEMA, NO DISCRIMINA POR MAYUSCULA O MINUSCULA, ENTONCES SI SE CREA UN USUARIO CON UN NOMBRE IGUAL A UNO QUE HAY EN LA BD PERO CAMBIANDOLE UNA SOLA LETRA A MAYUSCULA, DA ERROR.
            DataTable dt = objConexion.LeerPorComando("SELECT [_NombreUsuario] FROM [BDDJ].[dbo].[USUARIOS] ");

                        string NombreUsuarioMayusculaParametro = _NombreUsuarioParametro.ToUpper();//la convierto toda a mayuscula
                        string tempMayuscula;

            foreach (DataRow fila in dt.Rows)//         PROBLEMA RESUELTO.
            {
                        tempMayuscula = fila["_NombreUsuario"].ToString();
                        tempMayuscula = tempMayuscula.ToUpper();
                                            //Console.WriteLine("EL PARAMETRO ES "+ NombreUsuarioMayusculaParametro + "\nEl de la BDD es "+ tempMayuscula + "\n\n");
                if (tempMayuscula == NombreUsuarioMayusculaParametro)
                {
                    return true;
                }
            }
            return false;
        }


        public bool Registrarse(string nombre, string apellido, int dni, string nombreUsuario, string contrasenia, string Rol, int Sueldo, string Habilitado)
        {
            Conexion objConexion = new Conexion();//                                                                                                                                                    el dni estaba como caracter
            int filasAfectadas = objConexion.EscribirPorComando("INSERT into [BDDJ].[dbo].[USUARIOS] ([_Nombre], [_Apellido], [_DNI], [_Contraseña], [_NombreUsuario]) values ('" + nombre + "', '" + apellido + "', " + dni + ", '" + contrasenia + "', '" + nombreUsuario + "')");

            if (filasAfectadas > 0) 
            {                                                                                                                                                                                     //el sueldo tambien estaba como caracter
                if ((objConexion.EscribirPorComando("INSERT into [BDDJ].[dbo].[EMPLEADOS] ([_Rol], [_IDEmpleado], [_Sueldo], [_Habilitado]) values ('" + Rol + "', '" + nombreUsuario + "', " + Sueldo + ", '" + Habilitado + "')")) > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public string VerificarRol(string nombreUsuario)
        {
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorComando("SELECT [_Rol] FROM [BDDJ].[dbo].[EMPLEADOS] WHERE [_IDEmpleado] = '" + nombreUsuario + "';");

            foreach (DataRow fila in dt.Rows)
            {
                return fila[0].ToString();
            }
            return "";
        }
    }
}
