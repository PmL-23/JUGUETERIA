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
        public FacturasCliente()
        {
            InitializeComponent();
            //_IDCliente = idcliente;string idcliente
            BLL.Vendedor vendedor = new BLL.Vendedor();

            List<BLL.Factura> listaFacturas = vendedor.TraerListaFacturas();

            dgvFacturasCliente.Rows.Clear();

            foreach (BLL.Factura factura in listaFacturas)//hasta aca hice,falta pasarle el id de cliente a la funcion traerlistafacturas 
            {
                // Agregar una nueva fila al DataGridView y asignar los valores de las celdas

                dgvFacturasCliente.Rows.Add(factura.IDVendedor, factura.IDCliente,factura.IDFactura, factura.FechaEmision, "$ " + factura.Total);
            }
            dgvFacturasCliente.Columns["TotalFactura"].DefaultCellStyle.Format = "0.00";

            MessageBox.Show("entro");
        }

        private void FacturasCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
