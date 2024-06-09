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
        private string _Nombre;
        private string _Apellido;
        private string _IDCliente;
        private int _CantidadCompras;
        private int _DNI;

        #region Props
        public string IDCliente
        {
            get { return _IDCliente; }
            set { _IDCliente = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public int DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

        public int CantidadCompras
        {
            get { return _CantidadCompras; }
            set { _CantidadCompras = value; }
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
