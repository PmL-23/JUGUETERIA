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
    public partial class EditarProducto : Form
    {
        string _NombreUsuario;
        public EditarProducto(string _NombreUsuario)
        {
            InitializeComponent();
            this._NombreUsuario = _NombreUsuario;
        }

        private void EditarProducto_Load(object sender, EventArgs e) { }

        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void tboxIDProducto_TextChanged(object sender, EventArgs e) { }

        private void AbrirFormEnPanel(object Formulario)
        {
            if (this.PanelParaProducto.Controls.Count > 0) 
            {
                this.PanelParaProducto.Controls.RemoveAt(0);
            }

            Form FH = Formulario as Form;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;
            this.PanelParaProducto.Controls.Add(FH);
            this.PanelParaProducto.Tag = FH;
            FH.Show();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {


            AbrirFormEnPanel(new ProductoEnEditarProducto(tboxIDProducto.Text));
        }

        private void PanelParaProducto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
