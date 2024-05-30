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
    public partial class IVENDEDOR : Form
    {
        public IVENDEDOR()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(Form formulario)
        {
            // Eliminar todos los controles existentes del panel
            panel1.Controls.Clear();

            // Añadir el nuevo formulario al panel
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formulario);
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrearCliente());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CerrarSesion(new NOSE());
            MessageBox.Show("\tSesion Cerrada\t");
        }

        private void CerrarSesion(object Formulario)
        {

            //PanelCentral.Controls.Clear();
            //PanelLateral.Controls.Clear();

            Form FH = Formulario as Form;
            FH.WindowState = FormWindowState.Maximized;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;

            this.Controls.Add(FH);
            FH.Show();
        }
    }
}
