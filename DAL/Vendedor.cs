using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

        public DataTable VerHistorialVendedor(string idVendedor) {

            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorComando("SELECT * FROM [BDDJ].[dbo].[FACTURA] WHERE [_IDVendedorFactura] = '"+idVendedor+"';");
            
            return dt;
        }

        public bool RegistrarCliente(string idCliente, string nombre, string apellido, long dni, long cantidadCompras)
        {
            Conexion objConexion = new Conexion();
            int filasAfectadas = objConexion.EscribirPorComando("INSERT into [BDDJ].[dbo].[CLIENTES] ([_Nombre], [_Apellido], [_IDCliente], [_CantidadCompras], [_DNI]) values ('"+nombre+"', '"+apellido+"', '"+idCliente+"', "+cantidadCompras+", "+dni+");");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }

        public DataTable TraerListaFacturas(string _IDCliente)
        {
            Conexion objConexion = new Conexion();
            return objConexion.LeerPorComando("SELECT [_IDVendedorFactura],[_IDClienteFactura],[_IDFactura],[_FechaEmision],[_Total] FROM [BDDJ].[dbo].[FACTURA] WHERE [_IDClienteFactura] ='"+ _IDCliente + "' ");
        }

        public DataTable TraerDetallesFactura(string idFactura) { 
            Conexion con = new Conexion();

            return con.LeerPorComando("SELECT * FROM [BDDJ].[dbo].[DETALLE_FACTURA] WHERE _IDFactura = " + idFactura + ";");
        }

        public bool GenerarFactura(string idVendedorFactura, string idClienteFactura, string date, decimal total)
        {
            Conexion objConexion = new Conexion();
            string totalString = total.ToString(CultureInfo.InvariantCulture);

            int filasAfectadas = objConexion.EscribirPorComando("INSERT into [BDDJ].[dbo].[FACTURA] ([_IDVendedorFactura], [_IDClienteFactura], [_FechaEmision], [_Total]) values ('" + idVendedorFactura + "', '" + idClienteFactura + "', '" + date + "', " + totalString + ");");

            if (filasAfectadas > 0)
            {
                return true;
            }

            return false;
        }

        public bool IncrementarYComisionarVenta(string idVendedor, decimal comision)
        {
            Conexion conexion = new Conexion();

            int filasAfectadas = conexion.EscribirPorComando("UPDATE [BDDJ].[dbo].[VENDEDOR] SET [_CantidadVentas] = [_CantidadVentas] + 1 WHERE _IDVendedor = '" + idVendedor + "';");

            if (filasAfectadas > 0)
            {
                string comisionString = comision.ToString(CultureInfo.InvariantCulture);
                filasAfectadas = conexion.EscribirPorComando("UPDATE [BDDJ].[dbo].[EMPLEADOS] SET [_Sueldo] = [_Sueldo] + "+comisionString+" WHERE _IDEmpleado = '"+idVendedor+"';");

                if (filasAfectadas > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}