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
                dtgvVerProductos.Rows.Add(producto.IDProducto, producto.NombreProducto, "$ " + producto.Costo, "$ " + producto.Precioventa, producto.CantidadEnStock);
            }
            dtgvVerProductos.Columns["CostoProducto"].DefaultCellStyle.Format = "0.00";
            dtgvVerProductos.Columns["PrecioProducto"].DefaultCellStyle.Format = "0.00";

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
        private void RecargarTodo(object Formulario)
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


        private void EditarProducto_Load(object sender, EventArgs e) { }

        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void tboxIDProducto_TextChanged(object sender, EventArgs e) { }



        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BLL.Logistica log = new BLL.Logistica();                          //Instanciamos un objeto de la BLL, para asi usar sus metodos.
            bool VerSiExiste = log.VerSiExisteProducto(tboxIDProducto.Text);            //Guardamos en VerSiExiste lo que devuelve el metedo. 

            if (VerSiExiste)        //Si el producto existe, lo mostramos y permimos editarlo.
            {
                AbrirFormEnPanel(new EditarProductoEnGestionarProducto(tboxIDProducto.Text));
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

            if (indice != -1 )
            { 
                string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indice != -1 )
            {
                string IDSelececionada = (string)dtgvVerProductos.Rows[indice].Cells["IDProducto"].Value;
                AbrirFormEnPanel(new EditarProductoEnGestionarProducto(IDSelececionada));
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

                AbrirFormEnPanel(new AmpliarProductoEnGestionarProducto(IDSelececionada));
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
                    RecargarTodo(new IGestionarProductos());

                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar el producto con ID: " + IDSelececionada);

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
    }
}
