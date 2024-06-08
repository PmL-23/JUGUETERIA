using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _idCliente;
        private int _cantidadCompras;
        private int _dni;

        #region Props
        public string IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public int CantidadCompras
        {
            get { return _cantidadCompras; }
            set { _cantidadCompras = value; }
        }

        #endregion

        public Cliente()
        {

        }

        #region Métodos Principales

        public List<Cliente> ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            DAL.Cliente clienteDal = new DAL.Cliente();

            DataTable miTabla = clienteDal.ClienteBase();

            foreach ( DataRow fila in miTabla.Rows)
            {
                Cliente cliente = new Cliente();

                cliente.Nombre = fila["_Nombre"].ToString();
                cliente.Apellido = fila["_Apellido"].ToString();
                cliente.IDCliente= fila["_IDCLiente"].ToString();
                cliente.CantidadCompras =int.Parse(fila["_CantidadCompras"].ToString());
                cliente.DNI = int.Parse( fila["_DNI"].ToString());

                clientes.Add(cliente); 

            }
            
            return clientes;
        }
        #endregion

        #region Métodos Auxiliares
        public bool AumentarCantCompras(string idCliente) {
            DAL.Cliente cliente = new DAL.Cliente();

            return cliente.AumentarCantCompras(idCliente);
        }

        #endregion
    }
}
