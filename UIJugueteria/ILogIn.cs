using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UIJugueteria
{


    public partial class NOSE : Form
    {

        public NOSE()
        {
            InitializeComponent();

        }
        private void btnCancela_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e) { }// lbl para iniciar sesion
        private void lblContraseña_Click(object sender, EventArgs e) { }// 

        private void tboxUsuario_TextChanged(object sender, EventArgs e) { } // tbox para iniciar sesion.
        private void tboxContraseña_TextChanged(object sender, EventArgs e) { }//

        private void AbrirFormEnPanel(Form formulario)
        {
            // Eliminar todos los controles existentes del panel
            PanelMain.Controls.Clear();

            // Añadir el nuevo formulario al panel
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(formulario);
            formulario.Show();
        }




        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string _NombreUsuario = tboxIniciarUsuario.Text;
            string _Contraseña = tboxIniciarContraseña.Text;
            BLL.Empleado emp = new BLL.Empleado();

            if (emp.IniciarSesion(_NombreUsuario, _Contraseña) == true)
            {
                //Con el método VerificarRol chequeo los datos de la cuenta para redireccionar al usuario
                string _RolTemp = emp.VerificarRol(_NombreUsuario);

                //Si el empleado se encuentra habilitado por el administrador puede iniciar sesion normalmente
                if (_RolTemp=="Logistica") {
                    MessageBox.Show("\tInicio Sesión Exitosamente\t\n\tBienvenido " + _NombreUsuario);
                    tboxIniciarUsuario.Text = "";
                    tboxIniciarContraseña.Text = "";

                    AbrirFormEnPanel(new ILOGISTICA(_NombreUsuario));
                }
                if (_RolTemp == "Administrador")
                {
                    MessageBox.Show("\tInicio Sesión Exitosamente\t\n\tBienvenido " + _NombreUsuario);
                    tboxIniciarUsuario.Text = "";
                    tboxIniciarContraseña.Text = "";

                    AbrirFormEnPanel(new IADMINISTRADOR());
                }
                if (_RolTemp == "Vendedor")
                {
                    MessageBox.Show("\tInicio Sesión Exitosamente\t\n\tBienvenido " + _NombreUsuario);
                    tboxIniciarUsuario.Text = "";
                    tboxIniciarContraseña.Text = "";

                    AbrirFormEnPanel(new IVENDEDOR());
                }

                //Si el empleado NO se encuentra habilitado o con un rol definido se le notifica lo ocurrido
                if (_RolTemp == "Deshabilitado")
                {
                    MessageBox.Show("Su cuenta debe ser habilitada por el administrador para poder iniciar sesion..");
                }
                if (_RolTemp == "Indefinido")
                {
                    MessageBox.Show("Su cuenta debe tener un rol asignado por el administrador para poder iniciar sesion..");
                }
                if (_RolTemp == "")
                {
                    MessageBox.Show("Error al verificar el rol de usuario..");
                }
            }
            else
            {
                MessageBox.Show("\t Usuario y/o Contraseña incorrecto.\t");
            }
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrearUsuario());
        }
    } 
}
