using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIJugueteria
{
    public partial class CrearUsuario : Form
    {

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }


        private void lblNombre_Click(object sender, EventArgs e) { }
        private void lblApellido_Click(object sender, EventArgs e) { }
        private void lblDNI_Click(object sender, EventArgs e) { }
        private void lblNombreCUrear_Click(object sender, EventArgs e) { }
        private void lblContraseñaCrear_Click(object sender, EventArgs e) { }
        private void lblContraseñaConfirmacion_Click(object sender, EventArgs e) { }


        private void tboxNombre_TextChanged_1(object sender, EventArgs e) { }
        private void tboxApellido_TextChanged_1(object sender, EventArgs e) { }
        private void tboxDNI_TextChanged(object sender, EventArgs e) { }
        private void tboxUsuarioCrear_TextChanged(object sender, EventArgs e) { }
        private void tboxContraseñaCrear_TextChanged(object sender, EventArgs e) { }
        private void tboxContraseñaConfirmacion_TextChanged(object sender, EventArgs e) { }

        private void AbrirFormEnPanel<MiForm>(Func<MiForm> formFactory) where MiForm : Form
        {
            Form formulario = PancelCentral.Controls.OfType<MiForm>().FirstOrDefault();

            // Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = formFactory();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PancelCentral.Controls.Add(formulario);
                PancelCentral.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            // Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //verifico que los campos no estén vacíos
            if (tboxNombre.Text == "" || tboxApellido.Text == "" || tboxDNI.Text == "" || tboxUsuarioCrear.Text == "" || tboxContraseñaCrear.Text == "" || tboxContraseñaConfirmacion.Text == "")
            {
                MessageBox.Show("\tHay campos incompletos, debe completarlos todos.\t");
            }
            else
            {
                try
                {
                    BLL.Empleado comprobando = new BLL.Empleado();

                    string TNombreUsuario = tboxUsuarioCrear.Text;

                    if (TNombreUsuario == "Logistica" || TNombreUsuario == "Vendedor" || TNombreUsuario == "Administrador") throw new MyExceptions("La ID " + TNombreUsuario + " es reservada, por favor intente devuelta con otra ID");

                    //Llamo a un método que verifica si el usuario ingresado ya está registrado en el sistema
                    if (comprobando.VerSiExisteNombreUsuario(TNombreUsuario) == false)
                    {

                        string TNombre = tboxNombre.Text;
                        string TApellido = tboxApellido.Text;
                        string TextoDNI = tboxDNI.Text;
                        int TDNI;

                        if (int.TryParse(TextoDNI, out TDNI))
                        {

                            string TContraseña = tboxContraseñaCrear.Text;
                            string TConstraseñaConfirmacion = tboxContraseñaConfirmacion.Text;



                            BLL.Empleado empleado = new BLL.Empleado();

                            //Finalmente llamo al método que registra el nuevo empleado en el sistema
                            bool registro = empleado.Registrarse(TNombre, TApellido, TDNI, TNombreUsuario, TContraseña, TConstraseñaConfirmacion);
                            if (registro == true)
                            {
                                MessageBox.Show("\tUsuario creado exitosamente Exitosamente.\t");
                                tboxNombre.Text = "";
                                tboxApellido.Text = "";
                                tboxDNI.Text = "";
                                tboxUsuarioCrear.Text = "";
                                tboxContraseñaCrear.Text = "";
                                tboxContraseñaConfirmacion.Text = "";
                                AbrirFormEnPanel(() => new ILogIn());

                            }
                            else
                            {
                                MessageBox.Show("\tError al crear el usuario.\t");
                            }


                        }
                        else
                        {
                            MessageBox.Show("El formato del DNI es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    else if (comprobando.VerSiExisteNombreUsuario(tboxUsuarioCrear.Text) == true)
                    {
                        MessageBox.Show("El Nombre de Usuario ya se encuentra Registrado en la Base de Datos");
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
        
        }


        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new ILogIn());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
