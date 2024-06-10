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

        BLL.Producto ProductoEnForm = new BLL.Producto();   //objetos globales que usaremos mas adelante
        BLL.Logistica logistica = new BLL.Logistica();
        public EditarProductoEnGestionarProducto(string _IDProducto)
        {
            InitializeComponent();
            try
            { //hacemos todo dentro de un try para controlar una posible excepcion
                ProductoEnForm = logistica.TraerUnProducto(_IDProducto);//guardamos en la variable global el producto que nos trae
                                                                        //el metodo TraerUnProducto
                lblIDEmpleadoCreadorProducto.Text = ProductoEnForm.IDCreadorProducto.ToString();//insertamos en los labels y textbox
                lblFechaCreacionProducto.Text =ProductoEnForm.FechaDeCreacion.ToString();//correspondientes datos traidos de la BDD
                idproducto.Text = ProductoEnForm.IDProducto.ToString();                 // asociados a esa IDProducto

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

                                    //metodo para abrir formularios en un panel.
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
                try     //hacemos todo dentro de un try para controlar una posible excepcion
                {
                    if (tboxCosto.Text == ProductoEnForm.Costo.ToString() &&
        tboxPrecioVenta.Text == ProductoEnForm.Precioventa.ToString() &&
        tboxStockDisponible.Text == ProductoEnForm.CantidadEnStock.ToString() &&
        tboxStockMinimoIdeal.Text == ProductoEnForm.CantidadMinimaPermitida.ToString() &&
        tboxNombreProducto.Text == ProductoEnForm.NombreProducto.ToString())
                    {
                        MessageBox.Show("\tDebe cambiar al menos 1 campo\t"); // el usuario NO modificó los campos
                    }
                    else
                    {
                        //guardamos en variables los campos que ingreso el usuario.
                        //los campos en los que el Usuario puede equivocarlos los tramos con el decimal.TryParse o
                        //int.TryParse, si podemos seguimos, y si no se lanza una mensaje y se pedimos que los ingrese devuelta,
                        //esto se hace 5 veces.
                        string costoProductoTexto = tboxCosto.Text.Replace(',', '.'); //se usa para que siempre se guarde con , y no con . 
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
                                                //si pasa todas la validaciones, mandamos a la BLL y esperamos resultado.
                                                bool resultado = logistica.EditarProducto(
                                                    tboxNombreProducto.Text,
                                                    _CostoProducto,
                                                    _PrecioVenta,
                                                    _StockDisponible,
                                                    _StockMinimoIdeal,
                                                    idproducto.Text
                                                );
                                                //Con el metodo EditarProducto ya mandamos a la BLL los datos para que la DAL los mande a la BDD, y esperamos a
                                                //ver que retorna 
                                                if (resultado)
                                                {
                                                    MessageBox.Show("Producto modificado con éxito");
                                                    AbrirFormEnPanel(() => new IGestionarProductos());
                                                }
                                                else
                                                {
                                                    MessageBox.Show("El producto NO se pudo editar");
                                                }
                                            }
                                            else        //mensajes de error de formato
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
            try     //hacemos todo dentro de un try para controlar una posible excepcion
            {
                bool resultado = logistica.EliminarProducto(idproducto.Text);
                //guardamos en resultado lo que nos devuelve EliminarProducto.
                if (resultado) {
                    MessageBox.Show("El Producto con ID: " + idproducto.Text + " a sido eliminado de la Base de Datos.");
                    AbrirFormEnPanel(() => new IGestionarProductos());
                }
                else
                {       // si resultado no es true, es porque el producto esta asociado a un DetalleFactura, por lo que NO se puede eliminar.
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
            try     //hacemos todo dentro de un try para controlar una posible excepcion
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new IGestionarProductos());//si presiona el boton abrimos ese formulario y le pasamos
                                                              //el parametro necesario
        }

        private void ProductoEnBuscarProducto_Load(object sender, EventArgs e) { }  //eventos en los que no agregamos codigo

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

        private void tboxStockDisponible_TextChanged_1(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void lblCosto_Click_1(object sender, EventArgs e) { }
        private void lblStockDisponible_Click_1(object sender, EventArgs e) { }
        private void lblStockMinimo_Click_1(object sender, EventArgs e) { }

        private void tboxPrecioVenta_TextChanged_1(object sender, EventArgs e) { }
        private void tboxCosto_TextChanged_1(object sender, EventArgs e) { }

    }
}
