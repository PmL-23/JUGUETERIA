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
using System.Runtime.InteropServices;
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
            AbrirFormEnPanel(() => new ILogIn());

        }
        private void btnCancela_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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


        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //para mover la aplicacion.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelMovCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    } 
}
