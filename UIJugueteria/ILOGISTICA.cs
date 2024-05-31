using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIJugueteria.ILogistica;

namespace UIJugueteria
{
    public partial class ILOGISTICA : Form
    {
        private string _NombreUsuario;

        public ILOGISTICA(string _NombreUsuario)
        {
            InitializeComponent();
             this._NombreUsuario = _NombreUsuario;


        }

        private void ILOGISTICA_Load(object sender, EventArgs e) { }

        private void lblLogistic(object sender, EventArgs e) { }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PanelLateral_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AbrirFormEnPanel(Form formulario)
        {
            // Eliminar todos los controles existentes del panel
            PanelCentral.Controls.Clear();

            // Añadir el nuevo formulario al panel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None; // Opcional, si quieres que no tenga borde
            formulario.Dock = DockStyle.None; // Cambia a None para permitir el movimiento
            formulario.Location = new Point(0, 0); // Inicializa la posición del formulario hijo
            PanelCentral.Controls.Add(formulario);
            formulario.Show();
        }


        private void btnCargarNuevoProducto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ICrearNuevoProducto(_NombreUsuario));
            //asdas
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new IGestionarProductos());
        }

        

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            CerrarSesion(new NOSE());
            MessageBox.Show("\tSesion Cerrada\t");
        }

        private void btnCargarStock_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new IControlarSoloStock());
        }

        private void btnVerAlertaDeStock_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new IVerAlertaStock());
        }



        private void CerrarSesion(object Formulario)
        {

            PanelCentral.Controls.Clear();
            PanelLateral.Controls.Clear();

            Form FH = Formulario as Form;
            FH.WindowState = FormWindowState.Maximized;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;
            this.Controls.Add(FH);
            FH.Show();
        }

        private void btnLogistica_Click(object sender, EventArgs e)
        {
            if (this.PanelCentral.Controls.Count > 0)
            {
                this.PanelCentral.Controls.RemoveAt(0);
            }
        }

        

    }
}
