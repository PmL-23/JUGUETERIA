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
        private int indice = 0;

        public IGestionarProductos()
        {
            InitializeComponent();
            BLL.Logistica logistica = new BLL.Logistica();

            List<BLL.Producto> listaProductos = logistica.TraerListaProductos();

            dtgvVerProductos.Rows.Clear();

            foreach (BLL.Producto producto in listaProductos)
            {
                // Agregar una nueva fila al DataGridView y asignar los valores de las celdas
                int rowIndex = dtgvVerProductos.Rows.Add(producto.IDProducto, producto.NombreProducto, "$ " + producto.Costo, "$ " + producto.Precioventa, producto.CantidadEnStock);

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
            dtgvVerProductos.Columns["CostoProducto"].DefaultCellStyle.Format = "0.00";
           
            dtgvVerProductos.Columns["PrecioProducto"].DefaultCellStyle.Format = "0.00";

        }



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


        private void EditarProducto_Load(object sender, EventArgs e) { }

        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void tboxIDProducto_TextChanged(object sender, EventArgs e) { }



        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BLL.Logistica log = new BLL.Logistica();                          //Instanciamos un objeto de la BLL, para asi usar sus metodos.
            bool VerSiExiste = log.VerSiExisteProducto(tboxIDProducto.Text);            //Guardamos en VerSiExiste lo que devuelve el metedo. 

            if (VerSiExiste)        //Si el producto existe, lo mostramos y permimos editarlo.
            {
                AbrirFormEnPanel(() => new EditarProductoEnGestionarProducto(tboxIDProducto.Text));
            }
            else
            {                           //Si el producto NO existe, mostramos un mensaje.
                MessageBox.Show("El producto con ID: '" + tboxIDProducto.Text + "' NO en la Base de Datos", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PanelParaProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvVerProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvVerProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indice != -1 )
            {
                string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;
                AbrirFormEnPanel(() => new EditarProductoEnGestionarProducto(IDSelececionada));
            }
            else
            {
                MessageBox.Show("Seleccione un producto ");

            }
        }

        private void btnAmpliar_Click(object sender, EventArgs e)
        {
            if (indice != -1 )
            {
                string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;

                AbrirFormEnPanel(() => new AmpliarProductoEnGestionarProducto(IDSelececionada));
            }
            else
            {
                MessageBox.Show("Seleccione un producto ");

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (indice != -1 )
            {
                string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;           //probar maneja cuando no se selecciona ninguna final(solo es cuando no hay productos y se selecciona eliminar o ampliar o editar.)
                BLL.Logistica logistica = new BLL.Logistica();
                bool resultado = logistica.EliminarProducto(IDSelececionada);
                if (resultado)
                {
                    MessageBox.Show("El Producto con ID: " + IDSelececionada + " a sido eliminado de la Base de Datos.");
                    AbrirFormEnPanel(() => new IGestionarProductos());

                }
                else
                {
                    MessageBox.Show("El producto con ID  " + IDSelececionada+"se ha usado en una factura, por lo que no se puede eliminar de la Base de Datos.");

                }

            }

            else
            {
                MessageBox.Show("Seleccione un producto ");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvVerProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvVerProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }
    }
}
