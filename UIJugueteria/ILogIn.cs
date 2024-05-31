using BLL;
using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
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
            formulario.FormBorderStyle = FormBorderStyle.None; // Opcional, si quieres que no tenga borde
            formulario.Dock = DockStyle.None; // Cambia a None para permitir el movimiento
            formulario.Location = new Point(0, 0); // Inicializa la posición del formulario hijo
            PanelMain.Controls.Add(formulario);
            formulario.Show();
        }






        private void btnIniciarSesion_Click(object sender, EventArgs e)
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
                        MessageBox.Show("\tInicio Sesión Exitosamente\t\n\tBienvenido " + _NombreUsuario);

                        tboxIniciarUsuario.Text = "";
                        tboxIniciarContraseña.Text = "";
                        PanelMain.Controls.Clear();

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

                        AbrirFormEnPanel(new IVENDEDOR(_NombreUsuario));
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

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrearUsuario());
        }
        
        private void label1_Click(object sender, EventArgs e) { }

        public int xClick, yClick;

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick= e.X; yClick= e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X);
                this.Top = this.Top + (e.Y);
            }
        }
        


    } 
}
