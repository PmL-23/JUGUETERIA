using DAL;
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

        public Administrador()
        {

        }

        #region Metodos Principales

        public List<Empleado> ListarEmpleados()
        {
            List<Empleado> listaDeEmpleados = new List<Empleado>();

            DAL.Administrador empleadosDAL = new DAL.Administrador();

            DataTable empleadosBD = empleadosDAL.ListarEmpleados();

            foreach (DataRow row in empleadosBD.Rows)
            {
                Empleado empleado = new Empleado();

                empleado.Habilitado = row["Estado"].ToString();
                empleado.Sueldo = decimal.Parse(row["Sueldo"].ToString());
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

        public bool ActualizarDatosUsuario(string rolPrevio, string nombreUsuario, string Rol, string Estado, decimal Sueldo)
        {

            DAL.Administrador admin = new DAL.Administrador();

            if (admin.ActualizarDatosUsuario(rolPrevio, nombreUsuario, Rol, Estado, Sueldo))
            {
                return true;
            }

            return false;
        }


        public List<Vendedor> TraerListaVendedores()
        {

            List<Vendedor> ListaVendedores = new List<Vendedor>();
            DAL.Administrador vendedor = new DAL.Administrador();

            DataTable vendedorbd = vendedor.TraerListaVendedores();

            foreach (DataRow row in vendedorbd.Rows)
            {
                Vendedor VendedorALista = new Vendedor();
                
                VendedorALista.Nombre = row["_Nombre"].ToString();
                VendedorALista.Apellido = row["_Apellido"].ToString();
                VendedorALista.IDEmpleado = row["_IDEmpleado"].ToString();
                VendedorALista.Sueldo = Convert.ToDecimal(row["_Sueldo"]);
                VendedorALista.Habilitado = row["_Habilitado"].ToString();
                VendedorALista.CantidadVentas= Convert.ToInt32(row["_CantidadVentas"]);
                ListaVendedores.Add(VendedorALista);
            }
            return ListaVendedores;
        }

        #endregion
    }
}
