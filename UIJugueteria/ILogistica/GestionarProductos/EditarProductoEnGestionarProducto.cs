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

        private void AbrirFormEnPanel(object Formulario)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.Clear();
            }

            Form FH = Formulario as Form;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(FH);
            this.panel1.Tag = FH;
            FH.Show();
        }


        private void btnConfirmarCambios_Click_1(object sender, EventArgs e)
        {
            if (tboxCosto.Text == "" || tboxPrecioVenta.Text == "" || tboxStockDisponible.Text == "" || tboxStockMinimoIdeal.Text == "" || tboxNombreProducto.Text == "")
            {
                MessageBox.Show("\tComplete todos los campos\t");               //el usuario no completo todos los campos
                
            }
            else
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
                        string precioventatext = tboxPrecioVenta.Text.Replace(',', '.');
                        decimal _PrecioVenta;
                        if (decimal.TryParse(precioventatext, NumberStyles.Any, CultureInfo.InvariantCulture, out _PrecioVenta))
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
                                        AbrirFormEnPanel(new IGestionarProductos());
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
                        else
                        {
                            MessageBox.Show("El formato del Precio de Venta del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato del Costo del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            



        }
        }


        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            bool resultado = logistica.EliminarProducto(idproducto.Text);

            if (resultado) {
                MessageBox.Show("El Producto con ID: " + idproducto.Text + " a sido eliminado de la Base de Datos.");
                AbrirFormEnPanel(new IGestionarProductos());



            }


            else
            {

                MessageBox.Show("El producto con ID: "+ idproducto.Text+" ya ha sido eliminado de la Base de Datos");
            }
        }

       
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BLL.Logistica log = new BLL.Logistica();                          //Instanciamos un objeto de la BLL, para asi usar sus metodos.
            bool VerSiExiste = log.VerSiExisteProducto(textBox1.Text);            //Guardamos en VerSiExiste lo que devuelve el metedo. 

            if (VerSiExiste)        //Si el producto existe, lo mostramos y permimos editarlo.
            {
                AbrirFormEnPanel(new EditarProductoEnGestionarProducto(textBox1.Text));
            }
            else
            {                           //Si el producto NO existe, mostramos un mensaje.
                MessageBox.Show("El producto con ID: '" + textBox1.Text + "' NO en la Base de Datos", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            AbrirFormEnPanel(new IGestionarProductos());
        }





























        //ESTA LIMPIO HASTA ACA, FUNCIONA 10PUNTOS, MOSTRAR LOS ATRIBUTOS QUE SE PUEDEN CAMBIAR EN UN TEXTBOX(DEJAR QUE SE PUEDAN CAMBIAR)
        //VARIOS ATRIBUTOS LOS MOSTRAMOS PERO NO DEJAMOS QUE SE CAMBIEN.
    }
}
