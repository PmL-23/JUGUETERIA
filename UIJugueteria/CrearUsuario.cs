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
    public partial class CrearUsuario : Form
    {
        public int xClick, yClick;
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

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



        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (tboxNombre.Text == "" || tboxApellido.Text == "" || tboxDNI.Text == "" || tboxUsuarioCrear.Text == "" || tboxContraseñaCrear.Text == "" || tboxContraseñaConfirmacion.Text == "")
            {
                MessageBox.Show("\tHay campos incompletos, debe completarlos todos.\t");
            }
            else
            {
                BLL.Empleado comprobando = new BLL.Empleado();

                string TNombreUsuario = tboxUsuarioCrear.Text;
                if (comprobando.VerSiExisteNombreUsuario(TNombreUsuario) == false)
                {

                    string TNombre = tboxNombre.Text;
                    string TApellido = tboxApellido.Text;
                    string TextoDNI = tboxDNI.Text;
                    int TDNI;
                        if (int.TryParse(TextoDNI, out TDNI)) {
                        string TContraseña = tboxContraseñaCrear.Text;
                        string TConstraseñaConfirmacion = tboxContraseñaConfirmacion.Text;


                        BLL.Empleado empleado = new BLL.Empleado();

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


                        }
                        else
                        {
                            MessageBox.Show("\tError al crear el usuario.\t");
                        }


                    }
                        else{
                            MessageBox.Show("El formato del DNI es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    

                }

                else if (comprobando.VerSiExisteNombreUsuario(tboxUsuarioCrear.Text) == true)
                {
                    MessageBox.Show("El Nombre de Usuario ya se encuentra Registrado en la Base de Datos");
                }
            }


        }
        private void CerrarSesion(object Formulario)
        {

            PancelCentral.Controls.Clear();

            Form FH = Formulario as Form;
            FH.WindowState = FormWindowState.Maximized;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;

            this.Controls.Add(FH);
            FH.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CerrarSesion(new NOSE());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
