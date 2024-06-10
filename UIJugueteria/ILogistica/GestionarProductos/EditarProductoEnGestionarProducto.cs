using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIJugueteria
{
    public partial class EditarProductoEnGestionarProducto : Form
    {

        BLL.Producto ProductoEnForm = new BLL.Producto();
        BLL.Logistica logistica = new BLL.Logistica();
        public EditarProductoEnGestionarProducto(string _IDProducto)
        {
            InitializeComponent();

            try { 
                ProductoEnForm = logistica.TraerUnProducto(_IDProducto);

            
                lblIDEmpleadoCreadorProducto.Text = ProductoEnForm.IDCreadorProducto.ToString();
                lblFechaCreacionProducto.Text =ProductoEnForm.FechaDeCreacion.ToString();
                idproducto.Text = ProductoEnForm.IDProducto.ToString();

                tboxNombreProducto.Text = ProductoEnForm.NombreProducto.ToString();
                tboxCosto.Text = ProductoEnForm.Costo.ToString();
                tboxPrecioVenta.Text = ProductoEnForm.Precioventa.ToString();
                tboxStockDisponible.Text = ProductoEnForm.CantidadEnStock.ToString();
                tboxStockMinimoIdeal.Text = ProductoEnForm.CantidadMinimaPermitida.ToString();
            
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

        private void ProductoEnBuscarProducto_Load(object sender, EventArgs e) { }

        private void lblIIDEmpleadorCreador_Click(object sender, EventArgs e) { }
        private void lblFechaCreacion_Click(object sender, EventArgs e) { }
        private void lblCosto_Click(object sender, EventArgs e) { }
        private void lblPrecioVenta_Click(object sender, EventArgs e) { }
        private void lblStockDisponible_Click(object sender, EventArgs e) { }
        private void lblStockMinimo_Click(object sender, EventArgs e) { }


        private void tboxCosto_TextChanged(object sender, EventArgs e) { }
        private void tboxPrecioVenta_TextChanged(object sender, EventArgs e) { }
        private void tboxStockDisponible_TextChanged(object sender, EventArgs e) { }
        private void tboxStockMinimoIdeal_TextChanged(object sender, EventArgs e) { }
        private void tboxNombreProducto_TextChanged(object sender, EventArgs e) { }


        private void lblIDEmpleadoCreadorProducto_Click(object sender, EventArgs e) { }
        private void lblFechaCreacionProducto_Click(object sender, EventArgs e) { }
        private void idproducto_Click(object sender, EventArgs e) { }
        private void lblNombreProductoEstatico_Click(object sender, EventArgs e) { }

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


        private void btnConfirmarCambios_Click_1(object sender, EventArgs e)
        {
            if (tboxCosto.Text == "" || tboxPrecioVenta.Text == "" || tboxStockDisponible.Text == "" || tboxStockMinimoIdeal.Text == "" || tboxNombreProducto.Text == "")
            {
                MessageBox.Show("\tComplete todos los campos\t");               //el usuario no completo todos los campos
                
            }
            else
            {
                try
                {
                    if (tboxCosto.Text == ProductoEnForm.Costo.ToString() &&
        tboxPrecioVenta.Text == ProductoEnForm.Precioventa.ToString() &&
        tboxStockDisponible.Text == ProductoEnForm.CantidadEnStock.ToString() &&
        tboxStockMinimoIdeal.Text == ProductoEnForm.CantidadMinimaPermitida.ToString() &&
        tboxNombreProducto.Text == ProductoEnForm.NombreProducto.ToString())
                    {
                        MessageBox.Show("\tDebe cambiar al menos 1 campo\t"); // el usuario no modificó los campos
                    }
                    else
                    {
                        string costoProductoTexto = tboxCosto.Text.Replace(',', '.');
                        decimal _CostoProducto;
                        if (decimal.TryParse(costoProductoTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out _CostoProducto))
                        {
                            if (_CostoProducto <= 0)
                            {
                                MessageBox.Show("El Costo debe ser mayor a 0.");

                            }
                            else
                            {
                                string precioventatext = tboxPrecioVenta.Text.Replace(',', '.');
                                decimal _PrecioVenta;
                                if (decimal.TryParse(precioventatext, NumberStyles.Any, CultureInfo.InvariantCulture, out _PrecioVenta))
                                {
                                    if (_PrecioVenta <= 0)
                                    {
                                        MessageBox.Show("El Precio de Venta debe ser mayor a 0.");
                                    }

                                    else
                                    {
                                        string stockdisponibletext = tboxStockDisponible.Text;
                                        int _StockDisponible;
                                        if (int.TryParse(stockdisponibletext, out _StockDisponible))
                                        {
                                            string stockminimoidealtext = tboxStockMinimoIdeal.Text;
                                            int _StockMinimoIdeal;
                                            if (int.TryParse(stockminimoidealtext, out _StockMinimoIdeal))
                                            {
                                                bool resultado = logistica.EditarProducto(
                                                    tboxNombreProducto.Text,
                                                    _CostoProducto,
                                                    _PrecioVenta,
                                                    _StockDisponible,
                                                    _StockMinimoIdeal,
                                                    idproducto.Text
                                                );

                                                if (resultado)
                                                {
                                                    MessageBox.Show("Producto modificado con éxito");
                                                    AbrirFormEnPanel(() => new IGestionarProductos());
                                                }
                                                else
                                                {
                                                    MessageBox.Show("El producto seleccionado no existe en la Base de Datos");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("El formato del Stock Mínimo Ideal del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El formato del Stock Disponible del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El formato del Precio de Venta del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El formato del Costo del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }


        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            try
            {
                //codigo de metodo q primero ve si el producto esta en un detalle factura, si esta NO te deja eliminarlo, te salta un mensaje.
                //si el producto no esta en ningun detalle factura, te deja eliminarlo normal.

                bool resultado = logistica.EliminarProducto(idproducto.Text);

                if (resultado) {
                    MessageBox.Show("El Producto con ID: " + idproducto.Text + " a sido eliminado de la Base de Datos.");
                    AbrirFormEnPanel(() => new IGestionarProductos());
                }
                else
                {

                    MessageBox.Show("El producto con ID  " + idproducto.Text + "se ha usado en una factura, por lo que no se puede eliminar de la Base de Datos.");
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

       
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try 
            { 
                BLL.Logistica log = new BLL.Logistica();                          //Instanciamos un objeto de la BLL, para asi usar sus metodos.
                bool VerSiExiste = log.VerSiExisteProducto(textBox1.Text);            //Guardamos en VerSiExiste lo que devuelve el metedo. 

                if (VerSiExiste)        //Si el producto existe, lo mostramos y permimos editarlo.
                {
                    AbrirFormEnPanel(() => new EditarProductoEnGestionarProducto(textBox1.Text));
                }
                else
                {                           //Si el producto NO existe, mostramos un mensaje.
                    MessageBox.Show("El producto con ID: '" + textBox1.Text + "' NO en la Base de Datos", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void tboxStockDisponible_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCosto_Click_1(object sender, EventArgs e)
        {

        }

        private void lblStockDisponible_Click_1(object sender, EventArgs e)
        {

        }

        private void lblStockMinimo_Click_1(object sender, EventArgs e)
        {

        }

        private void tboxPrecioVenta_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tboxCosto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new IGestionarProductos());
        }





























        //ESTA LIMPIO HASTA ACA, FUNCIONA 10PUNTOS, MOSTRAR LOS ATRIBUTOS QUE SE PUEDEN CAMBIAR EN UN TEXTBOX(DEJAR QUE SE PUEDAN CAMBIAR)
        //VARIOS ATRIBUTOS LOS MOSTRAMOS PERO NO DEJAMOS QUE SE CAMBIEN.
    }
}
