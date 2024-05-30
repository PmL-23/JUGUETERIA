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

            BLL.Logistica logistica = new BLL.Logistica();

            List<BLL.Producto> listaProductos = logistica.TraerListaProductos();

            dtgvVerProductos.Rows.Clear();

            foreach (BLL.Producto producto in listaProductos)
            {
                // Agregar una nueva fila al DataGridView y asignar los valores de las celdas
                dtgvVerProductos.Rows.Add(producto.IDProducto, producto.NombreProducto, producto.FechaDeCreacion, producto.CantidadEnStock, producto.CantidadMinimaPermitida);
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
            }
            else
            {
                MessageBox.Show("Seleccione un producto ");

            }
        }

























        //dsa
    }
}
