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
    public partial class CrearNuevoProducto : Form
    {
        private string _NombreUsuario;
        public CrearNuevoProducto(string _NombreUsuario)
        {
            InitializeComponent();

            this._NombreUsuario = _NombreUsuario;


        }

        private void CrearNuevoProducto_Load(object sender, EventArgs e) { }

        private void lblNombreDeProducto_Click(object sender, EventArgs e) { }
        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void lblCosto_Click(object sender, EventArgs e) { }
        private void lblPrecioDeVenta_Click(object sender, EventArgs e) { }
        private void lblStockMnimo_Click(object sender, EventArgs e) { }



        private void tboxNombreProdcuto_TextChanged(object sender, EventArgs e) { }
        private void tboxIDProducto_TextChanged(object sender, EventArgs e) { }
        private void tboxCostoProducto_TextChanged(object sender, EventArgs e) { }
        private void tboxPrecioVentaProducto_TextChanged(object sender, EventArgs e) { }
        private void tboxStockMinimoProducto_TextChanged(object sender, EventArgs e) { }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (tboxNombreProducto.Text==""||tboxIDProducto.Text==""||tboxCostoProducto.Text==""||tboxPrecioVentaProducto.Text==""||tboxStockMinimoProducto.Text=="") {
                MessageBox.Show("\tComplete todos los campos\t");
            }

            else {

                string _NombreProducto = tboxNombreProducto.Text;
                string _IDProducto = tboxIDProducto.Text;

                string costoProductoTexto = tboxCostoProducto.Text;
                float _CostoProducto;
                if (float.TryParse(costoProductoTexto, out _CostoProducto)) { }

                else {
                    MessageBox.Show("El formato del Costo del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string precioProductoTexto = tboxPrecioVentaProducto.Text;
                float _VentaProducto;
                if (float.TryParse(precioProductoTexto, out _VentaProducto)) { }

                else
                {
                    MessageBox.Show("El formato del Precio de Venta del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string stockMinimoProductoTexto = tboxStockMinimoProducto.Text;
                int _StockMinimoProducto;
                if (int.TryParse(stockMinimoProductoTexto, out _StockMinimoProducto)) { }

                else
                {
                    MessageBox.Show("El formato de la Cantidad Minima del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int _StockDefault = 0;
                BLL.Logistica log = new BLL.Logistica(); ///FALTA SACAR TIEMPO PARA METER EN LA FECHA DE CREACION
                string fecha = "2024-03-05 00:00:00.000";

                bool VerSiExiste = log.VerSiExisteProducto(_IDProducto);

                if (VerSiExiste) {

                    MessageBox.Show("El producto con ID: '" + _IDProducto + "' ya existe en la Base de Datos");
                }

                else
                {

                    bool resultado = log.CargarNuevoProducto(_NombreUsuario, _NombreProducto, _IDProducto, _CostoProducto, fecha, _VentaProducto, _StockDefault, _StockMinimoProducto);
                    if (resultado)
                    {
                        MessageBox.Show("El producto se cargó correctamente.");
                        tboxNombreProducto.Text = "";
                        tboxIDProducto.Text = "";
                        tboxCostoProducto.Text = "";
                        tboxPrecioVentaProducto.Text = "";
                        tboxStockMinimoProducto.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al cargar el producto.");
                    }

                }
            }






        }

        //insert




    }
}
