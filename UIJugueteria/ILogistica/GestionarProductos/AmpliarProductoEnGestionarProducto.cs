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
using UIJugueteria.ILogistica.ControlarStock;

namespace UIJugueteria
{
    public partial class AmpliarProductoEnGestionarProducto : Form
    {

        BLL.Producto ProductoEnForm = new BLL.Producto();
        BLL.Logistica logistica = new BLL.Logistica();

        public AmpliarProductoEnGestionarProducto(string _IDProducto)
        {
            InitializeComponent();
            try 
            { 
                ProductoEnForm = logistica.TraerUnProducto(_IDProducto);

                lblIDEmpleadoCreadorProducto.Text = ProductoEnForm.IDCreadorProducto.ToString();
                lblFechaCreacionProducto.Text =ProductoEnForm.FechaDeCreacion.ToString();
                lblIDProductoDinamico.Text = ProductoEnForm.IDProducto.ToString();
                lblNombreProducto.Text = ProductoEnForm.NombreProducto.ToString();
                lblCostoProducto.Text = ProductoEnForm.Costo.ToString();
                lblPrecioVentaProducto.Text = ProductoEnForm.Precioventa.ToString();
                lblStock.Text = ProductoEnForm.CantidadEnStock.ToString();
                lblStockMinimoIdeal.Text = ProductoEnForm.CantidadMinimaPermitida.ToString();
            
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

        private void AmpliarProductoEnGestionarProducto_Load(object sender, EventArgs e) { }

        private void lblIIDEmpleadorCreador_Click(object sender, EventArgs e) { }
        private void lblFechaCreacion_Click(object sender, EventArgs e) { }
        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void lblCosto_Click(object sender, EventArgs e) { }
        private void lblPrecioVenta_Click(object sender, EventArgs e) { }
        private void lblStockDisponible_Click(object sender, EventArgs e) { }
        private void lblStockMinimo_Click(object sender, EventArgs e) { }
        private void lblNombreProductoEstatico_Click(object sender, EventArgs e) { }


        private void lblIDEmpleadoCreadorProducto_Click(object sender, EventArgs e) { }
        private void lblFechaCreacionProducto_Click_1(object sender, EventArgs e) { }
        private void lblIDProductoDinamico_Click(object sender, EventArgs e) { }
        private void lblNombreProducto_Click(object sender, EventArgs e) { }
        private void lblCostoProducto_Click(object sender, EventArgs e) { }
        private void lblPrecioVentaProducto_Click(object sender, EventArgs e) { }
        private void lblStock_Click(object sender, EventArgs e) { }
        private void lblStockMinimoIdeal_Click(object sender, EventArgs e) { }

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



        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (tboxIDProducto.Text == "")
            {
                MessageBox.Show("Ingrese una IDProducto a buscar.");
            }
            else
            {
                try
                {
                    BLL.Logistica log = new BLL.Logistica();                          //Instanciamos un objeto de la BLL, para asi usar sus metodos.
                    bool VerSiExiste = log.VerSiExisteProducto(tboxIDProducto.Text);            //Guardamos en VerSiExiste lo que devuelve el metedo. 

                    if (VerSiExiste)        //Si el producto existe, lo mostramos y permimos editarlo.
                    {
                        AbrirFormEnPanel(() => new AmpliarProductoEnGestionarProducto(tboxIDProducto.Text));
                    }
                    else
                    {                           //Si el producto NO existe, mostramos un mensaje.
                        MessageBox.Show("El producto con ID: '" + tboxIDProducto.Text + "' NO en la Base de Datos", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new IGestionarProductos());
        }
    }
}
