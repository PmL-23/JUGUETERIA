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
        private void AbrirFormEnPanel(Form formulario)
        {
            try
            {
                // Eliminar todos los controles existentes del panel
                panel1.Controls.Clear();

                // Añadir el nuevo formulario al panel
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panel1.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
            catch {
                MessageBox.Show("Disculpe las molestias, ocurrio un error.");
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            AbrirFormEnPanel(new HistorialCliente(_IDVendedor));
        }

        private void btnVerDetalleFactura_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FacturasCliente(_IDVendedor, tboxIDCliente.Text));
        }
    }
}
