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

namespace UIJugueteria
{
    public partial class IGestionarProductos : Form
    {
        private int indice = 0;     //usamos esta variable para guarda el numero de fila seleccionado en la grilla

        public IGestionarProductos()
        {
            InitializeComponent();
            try         //hacemos todo dentro de un try para controlar una posible excepcion
            {
                BLL.Logistica logistica = new BLL.Logistica(); //instanciamos un objeto Logistica para usar sus metodos.    

                List<BLL.Producto> listaProductos = logistica.TraerListaProductos();
                //poblamos la lista listaProductos con el metodo TraerListaProductos, el cual nos trae TODOS los productos de la BDD.

                dtgvVerProductos.Rows.Clear(); //limpiamos la grilla para empezar a operar en ella.
                foreach (BLL.Producto producto in listaProductos)       //recorremos la listaProductos e insertamos lo que trajimos de la BDD.
                {
                    string costoString = producto.Costo.ToString("N2", new System.Globalization.CultureInfo("es-ES"));
                    string precioVentaString = producto.Precioventa.ToString("N2", new System.Globalization.CultureInfo("es-ES"));
                    int rowIndex = dtgvVerProductos.Rows.Add(producto.IDProducto, producto.NombreProducto, "$ " + costoString, "$ " + precioVentaString, producto.CantidadEnStock);

                    // Obtener la fila actual
                    DataGridViewRow row = dtgvVerProductos.Rows[rowIndex];
                                                           
                    if (producto.CantidadEnStock < producto.CantidadMinimaPermitida)//personalización estetica.
                    {
                        row.Cells["StockProducto"].Style.BackColor = Color.Orange;
                        row.Cells["StockProducto"].Style.ForeColor = Color.Black;
                    }
                    if (producto.CantidadEnStock == 0)//personalización estetica.
                    {
                        row.Cells["StockProducto"].Style.BackColor = Color.Brown;
                        row.Cells["StockProducto"].Style.ForeColor = Color.Black;
                    }
                }
                dtgvVerProductos.Columns["CostoProducto"].DefaultCellStyle.Format = "0.00"; //para que las filas se muestren con ese formato
                dtgvVerProductos.Columns["PrecioProducto"].DefaultCellStyle.Format = "0.00";
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
                                //Metodo para abrir formularios en un panel.
                        private void AbrirFormEnPanel<MiForm>(Func<MiForm> formFactory) where MiForm : Form
                        {
                            try
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
                            catch (Exception ex)
                            {
                Console.WriteLine(ex.Message);

            }
                        }


        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try         //hacemos todo dentro de un try para controlar una posible excepcion
            {
                if (string.IsNullOrEmpty(tboxIDProducto.Text)) throw new MyExceptions("No ingresó el ID de ningún producto..");

                BLL.Logistica log = new BLL.Logistica();                          //Instanciamos un objeto de la BLL, para asi usar sus metodos.
                bool VerSiExiste = log.VerSiExisteProducto(tboxIDProducto.Text);            //Guardamos en VerSiExiste lo que devuelve el metedo. 

                if (VerSiExiste)        //Si el producto existe, lo mostramos y permimos editarlo.
                {
                    AbrirFormEnPanel(() => new EditarProductoEnGestionarProducto(tboxIDProducto.Text));
                }
                else
                {                           //Si el producto NO existe, mostramos un mensaje.
                    MessageBox.Show("El producto con ID: '" + tboxIDProducto.Text + "' NO existe en la Base de Datos", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void dtgvVerProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;//guardamos en indice la fila seleccionada de la grilla
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvVerProductos.Rows.Count > 0)
            {
                    if (indice != -1 )  //si el indice es -1, selecciono el header.
                {
                    string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;
                    AbrirFormEnPanel(() => new EditarProductoEnGestionarProducto(IDSelececionada));
                }
                else
                {
                    MessageBox.Show("Seleccione un producto ");
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun Producto");
            }
        }

        private void btnAmpliar_Click(object sender, EventArgs e)
        {
            if (dtgvVerProductos.Rows.Count > 0)
            {
                if (indice != -1)//si el indice es -1, selecciono el header.
                {
                    string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;
                    AbrirFormEnPanel(() => new AmpliarProductoEnGestionarProducto(IDSelececionada));
                }
                else
                {
                    MessageBox.Show("Seleccione un producto ");

                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun Producto");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvVerProductos.Rows.Count > 0)
                {
                    if (indice != -1)//si el indice es -1, selecciono el header.
                    {
                        string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;           //probar maneja cuando no se selecciona ninguna final(solo es cuando no hay productos y se selecciona eliminar o ampliar o editar.)
                        BLL.Logistica logistica = new BLL.Logistica();
                        bool resultado = logistica.EliminarProducto(IDSelececionada);
                        if (resultado)
                        {
                            MessageBox.Show("El Producto con ID: " + IDSelececionada + " ha sido eliminado de la Base de Datos.");
                            AbrirFormEnPanel(() => new IGestionarProductos());
                        }
                        else
                        {
                            MessageBox.Show("El producto con ID  " + IDSelececionada + "se ha usado en una factura, por lo que no se puede eliminar de la Base de Datos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un producto ");
                    }
                }
                else
                {
                    MessageBox.Show("No selecciono ningun Producto");
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

        private void dtgvVerProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;    //guardamos en indice la fila seleccionada de la grilla
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void dtgvVerProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        private void PanelParaProducto_Paint(object sender, PaintEventArgs e) { }

        private void dtgvVerProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        
        private void EditarProducto_Load(object sender, EventArgs e) { }

        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void tboxIDProducto_TextChanged(object sender, EventArgs e) { }


    }
}
