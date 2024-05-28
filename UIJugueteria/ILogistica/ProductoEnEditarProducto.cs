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
        private string _IDProducto;
        public ProductoEnEditarProducto(string _IDProducto)
        {
            InitializeComponent();
            this._IDProducto = _IDProducto;
            idproducto.Text = _IDProducto;

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

        private void lblIDEmpleadoCreadorProducto_Click(object sender, EventArgs e) { }
        private void lblFechaCreacionProducto_Click(object sender, EventArgs e) { }
        private void idproducto_Click(object sender, EventArgs e) { }

















        //ESTA LIMPIO HASTA ACA, FUNCIONA 10PUNTOS, MOSTRAR LOS ATRIBUTOS QUE SE PUEDEN CAMBIAR EN UN TEXTBOX(DEJAR QUE SE PUEDAN CAMBIAR)
        //VARIOS ATRIBUTOS LOS MOSTRAMOS PERO NO DEJAMOS QUE SE CAMBIEN.
    }
}
