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

            try
            {
                //Traigo de la BD la lista de facturas del cliente seleccinado
                BLL.Vendedor vendedor = new BLL.Vendedor();

                List<BLL.Factura> listaFacturas = vendedor.TraerListaFacturas(_IDCliente);
                dgvFacturasCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvFacturasCliente.Rows.Clear();

                foreach (BLL.Factura factura in listaFacturas)
                {
                    //Sumo cada fila a la grilla de la interfaz
                    dgvFacturasCliente.Rows.Add(this._IDVendedor, this._IDCliente, factura.IDFactura, factura.FechaEmision, "$ " + factura.Total);
                }
                dgvFacturasCliente.Columns["TotalFactura"].DefaultCellStyle.Format = "0.00";

                lblIDClienteDinamico.Text = this._IDCliente;
            }
            catch (MyExceptions ExcPersonalizada) //Atrapo las excepciones personalizadas
            {
                MessageBox.Show(ExcPersonalizada.Mensaje);
            }
            catch (Exception ex) //Atrapo excepciones generales
            {
                MessageBox.Show("Ocurrió la siguiente Exception: " + ex.Message);
            }

            if(dgvFacturasCliente.Rows.Count == 0)
            {
                MessageBox.Show("El Cliente con ID: "+ _IDCliente + " NO tiene facturas asociadas a su cuenta.");
                AbrirFormEnPanelCERRAR(() => new HistorialCliente(_IDVendedor));
            }

        }

        private void FacturasCliente_Load(object sender, EventArgs e)
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
            catch (Exception )
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
        private void btnVolver_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanelCERRAR(() => new HistorialCliente(_IDVendedor));
        }

        private void btnVerDetalleFactura_Click(object sender, EventArgs e)
        {
            try {
                //La fila seleccionada la guardo en una variable para poder obtener los datos de los campos de la misma
                DataGridViewRow filaseleccionada = dgvFacturasCliente.SelectedRows[0];

                BLL.Vendedor vendedor = new BLL.Vendedor();

                //Traigo de la BD los detalles de la factura seleccionada
                List<DetalleFactura> detallesFacturas = vendedor.TraerDetallesFactura(filaseleccionada.Cells["IDFactura"].Value.ToString());

                //Imprimo por pantalla los detalles de la factura mostrada
                string facturaString = "----DETALLE DE FACTURA----\n\n";
                decimal subtotalFactura = 0;
                decimal totalFactura = 0;

                facturaString += ("ID del vendedor: " + this._IDVendedor + "\n");
                facturaString += ("ID del cliente: " + this._IDCliente + "\n\n");
                facturaString += ("Fecha y hora: " + filaseleccionada.Cells["FechaEmisionFactura"].Value.ToString() + "\n\n");

                facturaString += "----PRODUCTOS INCLUIDOS----\n\n";

                foreach (DetalleFactura item in detallesFacturas)
                {
                    facturaString += (item.Producto.IDProducto + " x " + item.Cantidad.ToString() + " = $" + (decimal.Parse(item.Cantidad.ToString()) * item.Producto.Precioventa) + ".\n");

                    subtotalFactura += decimal.Parse(item.Cantidad.ToString()) * item.Producto.Precioventa;
                    totalFactura += (decimal.Parse(item.Cantidad.ToString()) * 1.21M) * item.Producto.Precioventa;
                }

                facturaString += "\nSUBTOTAL: $" + subtotalFactura;
                facturaString += "\nTOTAL (+IVA): $" + totalFactura.ToString("F2");

                //Muestro el string con todos los datos en un MessageBox
                MessageBox.Show(facturaString, "", MessageBoxButtons.OK);
            }
            catch (MyExceptions ExcPersonalizada) //Atrapo las excepciones personalizadas
            {
                MessageBox.Show(ExcPersonalizada.Mensaje);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("no hay ninguna factura seleccionada");
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIDClienteDinamico_Click(object sender, EventArgs e) { }

        private void dgvFacturasCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
