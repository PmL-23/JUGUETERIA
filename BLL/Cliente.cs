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
        private string _idCliente;

        public string _IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        private string _nombre;

        public string _Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string _Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _dni;

        public string _DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }


        private long _cantidadCompras;

        public long _CantidadCompras
        {
            get { return _cantidadCompras; }
            set { _cantidadCompras = value; }
        }

        public Cliente(string idCliente, string nombre, string apellido, string dni, int cantidadCompras)
        {
            this._IDCliente = idCliente;
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._DNI = dni;
            this._CantidadCompras = cantidadCompras;
           
        }

        public List<Cliente> ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            DAL.Cliente clienteDal = new DAL.Cliente();

            DataTable miTabla = clienteDal.ClienteBase();

            foreach ( DataRow fila in miTabla.Rows)
            {
                Cliente cliente = new Cliente();

                cliente._Nombre = fila["_Nombre"].ToString();
                cliente._Apellido = fila["_Apellido"].ToString();
                cliente._IDCliente = fila["_IDCLiente"].ToString();
                cliente._CantidadCompras =(long)fila["_CantidadCompras"];
                cliente._DNI = fila["_DNI"].ToString();

                clientes.Add(cliente); 

            }
            
            return clientes;
        }

        public bool AumentarCantCompras(string idCliente) {
            DAL.Cliente cliente = new DAL.Cliente();

            return cliente.AumentarCantCompras(idCliente);
        }

        public Cliente()
        {
        }
    }
}
