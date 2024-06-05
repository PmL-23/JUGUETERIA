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

        private void AbrirFormEnPanelCERRAR<MiForm>(Func<MiForm> formFactory) where MiForm : Form
        {
            var existingForm = panel1.Controls.OfType<MiForm>().FirstOrDefault();
            if (existingForm != null)
            {
                panel1.Controls.Remove(existingForm);
                existingForm.Close();
                existingForm.Dispose();
            }
            // Cierra y elimina todos los controles en paneltodo
            CloseAndRemoveAllControls(panel1);

            Form formulario = formFactory();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formulario);
            panel1.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        // Método auxiliar para cerrar y eliminar todos los controles en un panel
        private void CloseAndRemoveAllControls(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Form form)
                {
                    form.Close();
                }
            }
            panel.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelCERRAR(() => new CrearCliente(this.IDVendedor));
        }


        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelCERRAR(() => new NuevaVenta(this.IDVendedor));
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelCERRAR(() => new ILogIn());
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
            AbrirFormEnPanelCERRAR(() => new HistorialCliente(IDVendedor));
        }

        private void dgv_historial_vend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
