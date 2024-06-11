using BLL;
using BLL.Exceptions;
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
            //Modifico el comportamiento de la seleccion de filas de la grilla
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _IDVendedor = IDVendedor;

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            try
            {
                if (tboxIDCliente.Text == "") {
                    MessageBox.Show("Debe ingresar una IDCLiente a buscar");
                }
                else {
                    Vendedor vendedor = new Vendedor();
                    bool resultado = vendedor.VerSiExisteCliente(tboxIDCliente.Text);
                    if (resultado== false)
                    {
                        MessageBox.Show("El Cliente con ID "+ tboxIDCliente.Text +" NO existe.");
                    }
                    if (resultado == true)
                    {
                        AbrirFormEnPanelCERRAR(() => new FacturasCliente(_IDVendedor, tboxIDCliente.Text));
                    }

                }
            }
            catch (MyExceptions ExcPersonalizada) //Atrapo las excepciones personalizadas
            {
                MessageBox.Show(ExcPersonalizada.Mensaje);
            }
            catch (Exception ex) //Atrapo excepciones generales
            {
                MessageBox.Show("Ocurrió la siguiente Exception: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelCERRAR( () => new IVENDEDOR(_IDVendedor));
        }

        private void btnVerFacturasCliente_Click(object sender, EventArgs e)
        {

            if (indice != -1)
            {
                //Obtengo de la fila seleccionada el ID del cliente
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
            try
            {
                //Traigo de la BD la lista de cliente ordenada por cantidad de compras
                BLL.Cliente cliente = new BLL.Cliente();

                List<BLL.Cliente> listaClientes = cliente.ListarClientes().OrderByDescending(v => v.CantidadCompras).ToList();

                dgv_clientes.Rows.Clear();

                foreach (BLL.Cliente item in listaClientes)
                {
                    //Agrego cada fila a la grilla de la interfaz
                    dgv_clientes.Rows.Add(item.IDCliente, item.Nombre, item.Apellido, item.CantidadCompras, item.DNI);
                }
            }
            catch (MyExceptions ExcPersonalizada) //Atrapo las excepciones personalizadas
            {
                MessageBox.Show(ExcPersonalizada.Mensaje);
            }
            catch (Exception ex) //Atrapo excepciones generales
            {
                MessageBox.Show("Ocurrió la siguiente Exception: " + ex.Message);
            }
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cambio el index de la fila seleccionada
            indice = e.RowIndex;
        }
    }
}
