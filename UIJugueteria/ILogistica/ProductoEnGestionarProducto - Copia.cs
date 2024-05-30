using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIJugueteria
{
    public partial class ProductoEnEditarProducto : Form
    {

        BLL.Producto ProductoEnForm = new BLL.Producto();
        BLL.Logistica logistica = new BLL.Logistica();
        public ProductoEnEditarProducto(string _IDProducto)
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
        private void lblIDProducto_Click(object sender, EventArgs e) { }
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
        private void lblNombreProductoEstatico_Click(object sender, EventArgs e)
        {
        }





        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            if (tboxCosto.Text == "" || tboxPrecioVenta.Text == "" || tboxStockDisponible.Text == "" || tboxStockMinimoIdeal.Text == "" || tboxNombreProducto.Text == "")
            {
                MessageBox.Show("\tComplete todos los campos\t");               //el usuario no completo todos los campos
            }
            else
            {
                if (tboxCosto.Text == ProductoEnForm.Costo.ToString() && tboxPrecioVenta.Text == ProductoEnForm.Precioventa.ToString() && tboxStockDisponible.Text == ProductoEnForm.CantidadEnStock.ToString() && tboxStockMinimoIdeal.Text == ProductoEnForm.CantidadMinimaPermitida.ToString() && tboxNombreProducto.Text == ProductoEnForm.NombreProducto.ToString())
                {
                    MessageBox.Show("\tDebe cambiar al menos 1 campo\t");               //el usuario no modifico los campos
                }
                else {
                    string costoProductoTexto =  tboxCosto.Text;
                    float _CostoProducto;
                    if (float.TryParse(costoProductoTexto, out _CostoProducto))
                    {
                        string precioventatext = tboxPrecioVenta.Text;
                        float _PrecioVenta;
                        if (float.TryParse(precioventatext, out _PrecioVenta))
                        {
                            string stockdisponibletext = tboxStockDisponible.Text;
                            int _StockDisponible;
                            if (int.TryParse(stockdisponibletext, out _StockDisponible))
                            {
                                string stockminimoidealtext = tboxStockMinimoIdeal.Text;
                                int _StockMinimoIdeal;
                                if (int.TryParse(stockminimoidealtext, out _StockMinimoIdeal))
                                {

                                    bool resultado = logistica.EditarProducto(tboxNombreProducto.Text, _CostoProducto, _PrecioVenta, _StockDisponible, _StockMinimoIdeal, idproducto.Text);

                                    if (resultado) {
                                        MessageBox.Show("Producto modificado con exito");
                                    }

                                    else { }
                                }
                                else
                                {
                                    MessageBox.Show("El formato del Stock Minimo Ideal del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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























        //ESTA LIMPIO HASTA ACA, FUNCIONA 10PUNTOS, MOSTRAR LOS ATRIBUTOS QUE SE PUEDEN CAMBIAR EN UN TEXTBOX(DEJAR QUE SE PUEDAN CAMBIAR)
        //VARIOS ATRIBUTOS LOS MOSTRAMOS PERO NO DEJAMOS QUE SE CAMBIEN.
    }
}
