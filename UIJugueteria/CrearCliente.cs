using BLL;
using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                if (string.IsNullOrEmpty(tboxNombre.Text) || string.IsNullOrEmpty(tboxApellido.Text) || string.IsNullOrEmpty(tboxIDCliente.Text) || string.IsNullOrEmpty(tboxDNI.Text)) throw new MyExceptions("Debe completar todos los campos para continuar..");

                string nombre = tboxNombre.Text;
                string apellido = tboxApellido.Text;
                string idCliente = tboxIDCliente.Text;
                int dni = int.Parse(tboxDNI.Text);
                int cantidadCompras = 0;

                BLL.Vendedor unVendedor = new BLL.Vendedor();


                if (unVendedor.RegistrarCliente(idCliente, nombre, apellido, dni, cantidadCompras) == true)
                {
                    MessageBox.Show("Usuario cliente creado con exito!!");
                }
                else
                {
                    MessageBox.Show("No se pudo crear Nuevo Cliente!!");
                }
            }
            catch (SqlException ex) //Atrapo las excepciones provenientes de la Base de Datos
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Ya existe un cliente con el ID ingresado..");
                }
                else 
                {
                    MessageBox.Show("Error " + ex.Number + ": "+ex.Message+".");
                }
            }
            catch (MyExceptions ExcPersonalizada) //Atrapo las excepciones personalizadas
            {
                MessageBox.Show(ExcPersonalizada.Mensaje);
            }
            catch (Exception ex) //Atrapo excepciones generales
            {
                MessageBox.Show("Ocurrió la siguiente Exception: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CerrarSesion(new NOSE());
            MessageBox.Show("\tSesion Cerrada\t");
        }

       
        private void CerrarSesion(object Formulario)
        {

            //PanelCentral.Controls.Clear();
            //PanelLateral.Controls.Clear();
            panel1.Controls.Clear();

            Form FH = Formulario as Form;
            FH.WindowState = FormWindowState.Maximized;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;

            this.Controls.Add(FH);
            FH.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
