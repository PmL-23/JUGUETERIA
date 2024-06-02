using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIJugueteria.IVendedor;

namespace UIJugueteria
{
    public partial class IVENDEDOR : Form
    {
        string IDVendedor;

        public IVENDEDOR(string nombreUsuario)
        {
            InitializeComponent();
            grillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //label1.Text = "¡Bienvenido " + nombreUsuario
            //label1.Text = "VENTAS";
            IDVendedor = nombreUsuario;
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
            AbrirFormEnPanel(new CrearCliente(this.IDVendedor));
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new NuevaVenta(this.IDVendedor));
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            CerrarSesion(new NOSE());
        }


        private void IVENDEDOR_Load(object sender, EventArgs e)
        {
            BLL.Cliente cliente = new BLL.Cliente();
            grillaClientes.DataSource = cliente.ListarClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FacturasCliente());
        }
    }
}
