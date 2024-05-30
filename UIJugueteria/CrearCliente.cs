using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UIJugueteria
{
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string idCliente = "1";
                string nombre = tboxNombre.Text;
                string apellido = tboxApellido.Text;
                string dni = tboxDNI.Text;
                int cantidadCompras = 2;

                BLL.Vendedor unVendedor = new BLL.Vendedor();

                if (unVendedor.RegistrarCliente(idCliente, nombre, apellido, dni, cantidadCompras) == false)
                {
                    MessageBox.Show("Datos duplicados!!");
                }
                else
                {
                    if (unVendedor.RegistrarCliente(idCliente, nombre, apellido, dni, cantidadCompras) == true)
                    {
                        MessageBox.Show("Usuario cliente creado con exito!!");

                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear Nuevo Cliente!!");
                    }

                }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
