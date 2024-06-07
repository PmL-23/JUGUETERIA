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
        private void AbrirFormEnPanel<MiForm>(Func<MiForm> formFactory) where MiForm : Form
        {
            // Cerrar y eliminar cualquier instancia existente del formulario
            var existingForm = panel1.Controls.OfType<MiForm>().FirstOrDefault();
            if (existingForm != null)
            {
                panel1.Controls.Remove(existingForm);
                existingForm.Close();
                existingForm.Dispose();
            }

            // Crear una nueva instancia del formulario
            Form formulario = formFactory();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formulario);
            panel1.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void AbrirFormEnPanelCERRAR<MiForm>(Func<MiForm> formFactory) where MiForm : Form
        {
            try
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
            catch (Exception)
            {

                MessageBox.Show("Disculpe las molestias, ocurrio un error, reinicie la aplicacion.");
            }
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (tboxIDCliente.Text=="") {
                MessageBox.Show("Debe ingresar una IDCLiente a buscar");
            }
            else {
                //if cliente existe y tiene facturas

                AbrirFormEnPanelCERRAR(() => new FacturasCliente(_IDVendedor, tboxIDCliente.Text));

                //si existe y no tiene facturas otro mensaje.
                //si no existe, mensaje
            }
        }

        private void grillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelCERRAR( () => new IVENDEDOR(_IDVendedor));
        }

        private void btnVerFacturasCliente_Click(object sender, EventArgs e)
        {

            if (indice != -1)
            {
                string IDSeleccionada = (string)dgv_clientes.Rows[indice].Cells["IDCliente"].Value;

                AbrirFormEnPanelCERRAR( () => new FacturasCliente(_IDVendedor, IDSeleccionada));
            }
            else
            {
                MessageBox.Show("Seleccione Cliente para ver sus facturas");

            }
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            BLL.Cliente cliente = new BLL.Cliente();

            List<BLL.Cliente> listaClientes = cliente.ListarClientes().OrderByDescending(v => v._CantidadCompras).ToList();

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
