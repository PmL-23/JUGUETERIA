using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Administrador : Empleado
    {

        public List<Empleado> ListarEmpleados()
        {
            List<Empleado> listaDeEmpleados = new List<Empleado>();

            DAL.Administrador empleadosDAL = new DAL.Administrador();

            DataTable empleadosBD = empleadosDAL.ListarEmpleados();//no entiendo bien esta parte. Necesito algo asi para la funcion ver productos con alerta de stock.

            foreach (DataRow row in empleadosBD.Rows)
            {
                Empleado empleado = new Empleado();

                empleado.Habilitado = row["Estado"].ToString();
                empleado.Sueldo = int.Parse(row["Sueldo"].ToString());
                empleado.IDEmpleado = row["NombreDeUsuario"].ToString();
                empleado.Rol = row["Rol"].ToString();
                empleado.NombreUsuario = row["NombreDeUsuario"].ToString();
                empleado.Contraseña = "-";
                empleado.DNI = int.Parse(row["DNI"].ToString());
                empleado.Apellido = row["Apellido"].ToString();
                empleado.Nombre = row["Nombre"].ToString();

                listaDeEmpleados.Add(empleado);
            }

            return listaDeEmpleados;
        }

        public bool ActualizarDatosUsuario(string nombreUsuario, string Rol, string Estado, int Sueldo)
        {

            DAL.Administrador admin = new DAL.Administrador();

            if (admin.ActualizarDatosUsuario(nombreUsuario, Rol, Estado, Sueldo))
            {
                return true;
            }

            return false;
        }


        public Administrador()
        {

        }
    }
}
