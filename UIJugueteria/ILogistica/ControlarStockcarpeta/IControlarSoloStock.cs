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

namespace UIJugueteria.ILogistica
{
    public partial class IControlarSoloStock : Form
    {

        private int indice = 0;
        public IControlarSoloStock()
        {
            InitializeComponent();

            try
            {
                BLL.Logistica logistica = new BLL.Logistica();
            
                List<BLL.Producto> listaProductos = logistica.TraerListaProductos();

                dtgvVerProductos.Rows.Clear();

                foreach (BLL.Producto producto in listaProductos)
                {
                    // Agregar una nueva fila al DataGridView y asignar los valores de las celdas
                    int rowIndex = dtgvVerProductos.Rows.Add(producto.IDProducto, producto.NombreProducto, producto.FechaDeCreacion, producto.CantidadMinimaPermitida, producto.CantidadEnStock);
                    // Agregar una nueva fila al DataGridView y asignar los valores de las celdas


                    // Obtener la fila actual
                    DataGridViewRow row = dtgvVerProductos.Rows[rowIndex];
                    // Cambiar el color de la celda de CantidadEnStock si es menor que CantidadMinimaPermitida
                    if (producto.CantidadEnStock < producto.CantidadMinimaPermitida)
                    {
                        row.Cells["StockProducto"].Style.BackColor = Color.Orange;
                        row.Cells["StockProducto"].Style.ForeColor = Color.Black;
                    }
                    if (producto.CantidadEnStock == 0)
                    {
                        row.Cells["StockProducto"].Style.BackColor = Color.Brown;
                        row.Cells["StockProducto"].Style.ForeColor = Color.Black;
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

        private void PanelParaProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlarSoloStock_Load(object sender, EventArgs e)
        {

        }

        private void lblIDProducto_Click(object sender, EventArgs e) { }

        private void tboxIDProducto_TextChanged(object sender, EventArgs e) { }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (tboxIDProducto.Text == "") {
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
                        AbrirFormEnPanel(new EditarStock(tboxIDProducto.Text));
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

            private void dtgvVerProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void AbrirFormEnPanel(object Formulario)
                                                                        {
                                                                            if (this.PanelParaProducto.Controls.Count > 0)
                                                                            {
                                                                                this.PanelParaProducto.Controls.Clear();
                                                                            }

                                                                            Form FH = Formulario as Form;
                                                                            FH.TopLevel = false;
                                                                            FH.Dock = DockStyle.Fill;
                                                                            this.PanelParaProducto.Controls.Add(FH);
                                                                            this.PanelParaProducto.Tag = FH;
                                                                            FH.Show();
                                                                        }



        private void btnEditarStock_Click(object sender, EventArgs e)
        {
            
            if (indice != -1)
            {
                string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;
                AbrirFormEnPanel(new EditarStock(IDSelececionada));
                tboxIDProducto.Controls.Clear();

                lblIDProducto.Controls.Clear();
                btnBuscarProducto.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Seleccione un producto ");

            }
        }

        private void dtgvVerProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
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
                        AbrirFormEnPanel(new EditarStock(tboxIDProducto.Text));
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




        private void tboxIDProducto_TextChanged_1(object sender, EventArgs e)
        {

        }



    }


}
