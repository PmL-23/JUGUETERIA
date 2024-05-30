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
    public partial class ICrearNuevoProducto : Form
    {
        private string _NombreUsuario;
        public ICrearNuevoProducto(string _NombreUsuario)
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
                MessageBox.Show("\tComplete todos los campos\t");               //el usuario no completo todos los campos
            }
            else {

                string _NombreProducto = tboxNombreProducto.Text;
                string _IDProducto = tboxIDProducto.Text;                       //guardamos en variables los campos que ingreso el usuario.

                string costoProductoTexto = tboxCostoProducto.Text;
                float _CostoProducto;                                               
                if (float.TryParse(costoProductoTexto, out _CostoProducto)) {           //los campos en los que el Usuario puede equivocarlos los tramos con el float.TryParse,
                                                                                        //si podemos seguimos, y si no se lanza una mensaje y se pedimos que los ingrese devuelta,
                                                                                        //esto se hace 3 veces.
                    string precioProductoTexto = tboxPrecioVentaProducto.Text;
                    float _VentaProducto;
                    if (float.TryParse(precioProductoTexto, out _VentaProducto)) {
                        
                        string stockMinimoProductoTexto = tboxStockMinimoProducto.Text;
                        int _StockMinimoProducto;
                        if (int.TryParse(stockMinimoProductoTexto, out _StockMinimoProducto)) {

                            int _StockDefault = 0;              //MODIFICAR
                            BLL.Logistica log = new BLL.Logistica();                          //Instanciamos un objeto de la BLL, para asi usar sus metodos.

                            string fecha = "2024-03-05 00:00:00.000";//FALTA SACAR TIEMPO PARA METER EN LA FECHA DE CREACION, POR AHORA LO HARCODEAMOS

                            bool VerSiExiste = log.VerSiExisteProducto(_IDProducto);            //Guardamos en VerSiExiste lo que devuelve el metedo. 

                            if (VerSiExiste)
                            {
                                MessageBox.Show("El producto con ID: '" + _IDProducto + "' ya existe en la Base de Datos", "Producto ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {

                                bool resultado = log.CargarProducto(_NombreUsuario, _NombreProducto, _IDProducto, _CostoProducto, fecha, _VentaProducto, _StockDefault, _StockMinimoProducto);
                                                                                                  //Aqui con el metodo CargarProducto ya mandamos a la BLL los datos para que la DAL los mande a la BDD.
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

                        else
                        {
                            MessageBox.Show("El formato de la Cantidad Minima del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("El formato del Precio de Venta del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("El formato del Costo del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }



        }
    }
}
