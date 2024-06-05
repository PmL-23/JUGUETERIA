using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIJugueteria.ILogistica
{
    public partial class IVerAlertaStock : Form
    {
        

        public IVerAlertaStock()
        {
            InitializeComponent();
            
            BLL.Logistica logistica = new BLL.Logistica();


            List<BLL.Producto> listaProductos = logistica.VerAlertarBajoStock();

            int contador = listaProductos.Count;
            lblCantidadProductos.Text = contador.ToString();

            dtgvVerProductos.Rows.Clear();

            foreach (BLL.Producto producto in listaProductos)
            {
                // Agregar una nueva fila al DataGridView y asignar los valores de las celdas
                dtgvVerProductos.Rows.Add(producto.IDCreadorProducto, producto.IDProducto, producto.NombreProducto, producto.FechaDeCreacion, producto.CantidadMinimaPermitida, producto.CantidadEnStock);
            
            }
            dtgvVerProductos.CellFormatting += dtgvVerProductos_CellFormatting;


        }

        private void IVerAlertaStock_Load(object sender, EventArgs e) {
        }

        private void dtgvVerProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvVerProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvVerProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si es la columna que deseas cambiar (por ejemplo, la columna "CantidadEnStock")
            if (dtgvVerProductos.Columns[e.ColumnIndex].Name == "StockProducto")
            {
                // Cambia el color de fondo y el color de la fuente
                //e.CellStyle.BackColor = Color.FromArgb(255, 128, 128);
                e.CellStyle.BackColor = Color.Firebrick;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, 10);
            }
            if (dtgvVerProductos.Columns[e.ColumnIndex].Name == "StockMinimoIdeal")
            {
                // Cambia el color de fondo y el color de la fuente
                //e.CellStyle.BackColor = Color.FromArgb(255, 128, 128);
                e.CellStyle.BackColor = Color.DarkGreen;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, 10);
            }
        }

        private void lblCantidadProductos_Click(object sender, EventArgs e) { }

    }
}
