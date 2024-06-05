using BLL.Exceptions;
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
    public partial class ILogIn : Form
    {
        public ILogIn()
        {
            InitializeComponent();
        }


        private void lblNombreUsuario_Click(object sender, EventArgs e) { }// lbl para iniciar sesion
        private void lblContraseña_Click(object sender, EventArgs e) { }// 

        private void tboxUsuario_TextChanged(object sender, EventArgs e) { } // tbox para iniciar sesion.
        private void tboxContraseña_TextChanged(object sender, EventArgs e) { }//

        /*private void AbrirFormEnPanel(Form formulario)
        {
            // Eliminar todos los controles existentes del panel
            PanelMain.Controls.Clear();

            // Añadir el nuevo formulario al panel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None; // Opcional, si quieres que no tenga borde
            formulario.Dock = DockStyle.None; // Cambia a None para permitir el movimiento
            formulario.Location = new Point(0, 0); // Inicializa la posición del formulario hijo
            PanelMain.Controls.Add(formulario);
            formulario.Show();
        }*/

        private void AbrirFormEnPanel<MiForm>(Func<MiForm> formFactory) where MiForm : Form
        {
            Form formulario = PanelMain.Controls.OfType<MiForm>().FirstOrDefault();

            // Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = formFactory();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(formulario);
                PanelMain.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            // Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }





        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            string _NombreUsuario = tboxIniciarUsuario.Text;
            string _Contraseña = tboxIniciarContraseña.Text;
            BLL.Empleado emp = new BLL.Empleado();

            try
            {

                if (emp.IniciarSesion(_NombreUsuario, _Contraseña) == true)
                {
                    //Con el método VerificarRol chequeo los datos de la cuenta para redireccionar al usuario
                    string _RolTemp = emp.VerificarRol(_NombreUsuario);

                    //Si el empleado se encuentra habilitado por el administrador puede iniciar sesion normalmente
                    if (_RolTemp == "Logistica")
                    {

                        tboxIniciarUsuario.Text = "";
                        tboxIniciarContraseña.Text = "";
                        PanelMain.Controls.Clear();

                        AbrirFormEnPanel(() => new ILOGISTICA(_NombreUsuario));
                    }
                    if (_RolTemp == "Administrador")
                    {
                        tboxIniciarUsuario.Text = "";
                        tboxIniciarContraseña.Text = "";

                        AbrirFormEnPanel(() => new IADMINISTRADOR());
                    }
                    if (_RolTemp == "Vendedor")
                    {
                        tboxIniciarUsuario.Text = "";
                        tboxIniciarContraseña.Text = "";

                        AbrirFormEnPanel(() => new IVENDEDOR(_NombreUsuario));
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
            catch (MyExceptions ExcPersonalizada) //Atrapo las excepciones personalizadas
            {
                MessageBox.Show(ExcPersonalizada.Mensaje);
            }
            catch (Exception ex) //Atrapo excepciones generales
            {
                MessageBox.Show("Ocurrió la siguiente Exception: " + ex.Message);
            }
        }

        private void btnCrearCuenta_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new CrearUsuario());
        }

        private void PanelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ILogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
