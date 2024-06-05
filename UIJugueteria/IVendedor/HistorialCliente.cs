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
    public partial class HistorialCliente : Form
    {
        string _IDVendedor;
        private int indice = 0;

        public HistorialCliente( string IDVendedor)
        {
            InitializeComponent();
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _IDVendedor = IDVendedor;

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
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

                MessageBox.Show("Disculpe las molestias, ocurrio un error");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (tboxIDCliente.Text=="") {
                MessageBox.Show("Debe ingresar una IDCLiente a buscar");
            }
            else {
                //if cliente existe y tiene facturas
                
                AbrirFormEnPanel(new FacturasCliente(tboxIDCliente.Text, _IDVendedor));

                //si existe y no tiene facturas otro mensaje.
                //si no existe, mensaje
            }
        }

        private void grillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new IVENDEDOR(_IDVendedor));
        }

        private void btnVerFacturasCliente_Click(object sender, EventArgs e)
        {

            if (indice != -1)
            {
                string IDSeleccionada = (string)dgv_clientes.Rows[indice].Cells["IDCliente"].Value;

                AbrirFormEnPanel(new FacturasCliente(_IDVendedor, IDSeleccionada));
            }
            else
            {
                MessageBox.Show("Seleccione Cliente para ver sus facturas");

            }
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            BLL.Cliente cliente = new BLL.Cliente();

            List<BLL.Cliente> listaClientes = cliente.ListarClientes();

            dgv_clientes.Rows.Clear();

            foreach (BLL.Cliente item in listaClientes)
            {
                dgv_clientes.Rows.Add(item._IDCliente, item._Nombre, item._Apellido, item._CantidadCompras, item._DNI);
            }
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }
    }
}
