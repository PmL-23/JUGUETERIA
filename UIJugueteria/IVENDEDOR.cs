using BLL;
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
            dgv_historial_vend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_historial_vend.Rows.Clear();
            this.IDVendedor = nombreUsuario;
            label2.Text = "Historial de ventas de " + this.IDVendedor;
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
            CerrarSesion(new ILogIn());
        }


        private void IVENDEDOR_Load(object sender, EventArgs e)
        {
            BLL.Vendedor vendedor = new BLL.Vendedor();

            List<Factura> facturas = vendedor.VerHistorialVendedor(this.IDVendedor);

            foreach (Factura item in facturas)
            {
                dgv_historial_vend.Rows.Add(item.IDFactura, item.IDCliente, item.FechaEmision, item.Total);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnVerHistorialCliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new HistorialCliente(IDVendedor));
        }
    }
}
