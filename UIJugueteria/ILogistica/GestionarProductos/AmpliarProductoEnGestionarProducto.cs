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
    public partial class AmpliarProductoEnGestionarProducto : Form
    {

        BLL.Producto ProductoEnForm = new BLL.Producto();
        BLL.Logistica logistica = new BLL.Logistica();

        public AmpliarProductoEnGestionarProducto(string _IDProducto)
        {
            InitializeComponent();
       
            ProductoEnForm = logistica.TraerUnProducto(_IDProducto);

            lblIDEmpleadoCreadorProducto.Text = ProductoEnForm.IDCreadorProducto.ToString();
            lblFechaCreacionProducto.Text =ProductoEnForm.FechaDeCreacion.ToString();
            lblIDProductoDinamico.Text = ProductoEnForm.IDProducto.ToString();
            lblNombreProducto.Text = ProductoEnForm.NombreProducto.ToString();
            lblCostoProducto.Text = ProductoEnForm.Costo.ToString();
            lblPrecioVentaProducto.Text = ProductoEnForm.Precioventa.ToString();
            lblStock.Text = ProductoEnForm.CantidadEnStock.ToString();
            lblStockMinimoIdeal.Text = ProductoEnForm.CantidadMinimaPermitida.ToString();
        }

        private void AmpliarProductoEnGestionarProducto_Load(object sender, EventArgs e) { }

        private void lblIIDEmpleadorCreador_Click(object sender, EventArgs e) { }
        private void lblFechaCreacion_Click(object sender, EventArgs e) { }
        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void lblCosto_Click(object sender, EventArgs e) { }
        private void lblPrecioVenta_Click(object sender, EventArgs e) { }
        private void lblStockDisponible_Click(object sender, EventArgs e) { }
        private void lblStockMinimo_Click(object sender, EventArgs e) { }
        private void lblNombreProductoEstatico_Click(object sender, EventArgs e) { }


        private void lblIDEmpleadoCreadorProducto_Click(object sender, EventArgs e) { }
        private void lblFechaCreacionProducto_Click_1(object sender, EventArgs e) { }
        private void lblIDProductoDinamico_Click(object sender, EventArgs e) { }
        private void lblNombreProducto_Click(object sender, EventArgs e) { }
        private void lblCostoProducto_Click(object sender, EventArgs e) { }
        private void lblPrecioVentaProducto_Click(object sender, EventArgs e) { }
        private void lblStock_Click(object sender, EventArgs e) { }
        private void lblStockMinimoIdeal_Click(object sender, EventArgs e) { }

    }
}
