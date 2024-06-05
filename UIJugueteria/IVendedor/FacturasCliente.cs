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

namespace UIJugueteria.IVendedor
{
    public partial class FacturasCliente : Form
    {
        private string _IDCliente;
        private string _IDVendedor;
        public FacturasCliente(string idvendedor, string idcliente)
        {
            InitializeComponent();
            _IDCliente = idcliente;
            _IDVendedor = idvendedor;
            BLL.Vendedor vendedor = new BLL.Vendedor();

            List<BLL.Factura> listaFacturas = vendedor.TraerListaFacturas(_IDCliente);
            dgvFacturasCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvFacturasCliente.Rows.Clear();

            foreach (BLL.Factura factura in listaFacturas)
            {
                dgvFacturasCliente.Rows.Add(factura.IDVendedor, factura.IDCliente,factura.IDFactura, factura.FechaEmision, "$ " + factura.Total);
            }
            dgvFacturasCliente.Columns["TotalFactura"].DefaultCellStyle.Format = "0.00";

        }

        private void FacturasCliente_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormEnPanelCERRAR<MiForm>(Func<MiForm> formFactory) where MiForm : Form
        {
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
        private void btnVolver_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanelCERRAR(() => new HistorialCliente(_IDVendedor));
        }

        private void btnVerDetalleFactura_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaseleccionada = dgvFacturasCliente.SelectedRows[0];

            BLL.Vendedor vendedor = new BLL.Vendedor();

            List<DetalleFactura> detallesFacturas = vendedor.TraerDetallesFactura(filaseleccionada.Cells["IDFactura"].Value.ToString());

            string facturaString = "----DETALLES DE FACTURA----\n\n";
            decimal totalFactura = 0;

            facturaString += ("ID del vendedor: " + this._IDVendedor + "\n");
            facturaString += ("ID del cliente: " + this._IDCliente + "\n\n");
            facturaString += ("Fecha y hora: " + filaseleccionada.Cells["FechaEmisionFactura"].Value.ToString() + "\n\n");

            facturaString += "----PRODUCTOS INCLUIDOS----\n\n";

            foreach (DetalleFactura item in detallesFacturas)
            {
                facturaString += (item.IDProducto + " x " + item.Cantidad.ToString() + " = $" + (decimal.Parse(item.Cantidad.ToString()) * item.PrecioUnitario) + ".\n");

                totalFactura += decimal.Parse(item.Cantidad.ToString()) * item.PrecioUnitario;
            }

            facturaString += "\nTOTAL: $" + totalFactura;

            MessageBox.Show(facturaString, "", MessageBoxButtons.OK);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelCERRAR(() => new FacturasCliente(_IDVendedor, tboxIDCliente.Text));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
