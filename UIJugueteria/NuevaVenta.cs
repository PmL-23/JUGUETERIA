using BLL;
using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIJugueteria
{
    public partial class NuevaVenta : Form
    {
        Factura factura = new Factura();
        string IDVendedor;

        public NuevaVenta(string idVendedor)
        {
            InitializeComponent();
            this.IDVendedor = idVendedor;

            btn_agregar.Enabled = false;
            btn_quitar.Enabled = false;

            //Modifico propiedades de los datagridview para cambiar el comportamiento
            dgv_productos_stock.SelectionChanged += Dgv_productos_stock_SelectionChanged;
            dgv_productos_stock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos_stock.CellClick += Dgv_productos_stock_CellClick;
            dgv_productos_stock.MultiSelect = false;
            dgv_productos_stock.ReadOnly = true;

            dgv_productos_factura.SelectionChanged += Dgv_productos_factura_SelectionChanged;
            dgv_productos_factura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos_factura.CellClick += Dgv_productos_factura_CellClick;
            dgv_productos_factura.MultiSelect = false;
            dgv_productos_factura.ReadOnly = true;

            BLL.Logistica logistica = new BLL.Logistica();

            List<BLL.Producto> listaProductos = logistica.TraerListaProductos();

            dgv_productos_stock.Rows.Clear();
            dgv_productos_factura.Rows.Clear();

            foreach (BLL.Producto producto in listaProductos)
            {
                // Agregar una nueva fila al DataGridView y asignar los valores de las celdas
                dgv_productos_stock.Rows.Add(producto.IDProducto, producto.NombreProducto, "$" + producto.Precioventa, producto.CantidadEnStock);
            }

        }

        private void Dgv_productos_factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifico si el clic fue en una celda válida y no en encabezados de alguna columna
            if (e.RowIndex >= 0)
            {
                // Selecciono la fila completa
                dgv_productos_factura.Rows[e.RowIndex].Selected = true;
                btn_quitar.Enabled = true;
                btn_agregar.Enabled = false;
            }
        }

        private void Dgv_productos_factura_SelectionChanged(object sender, EventArgs e)
        {
            // Primero verifico si hay al menos una fila seleccionada
            if (dgv_productos_factura.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_productos_factura.SelectedRows[0];
            }
            else 
            {
                btn_quitar.Enabled = false;   
            }
        }

        private void Dgv_productos_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifico si el clic fue en una celda válida y no en encabezados de alguna columna
            if (e.RowIndex >= 0)
            {
                // Selecciono la fila completa
                dgv_productos_stock.Rows[e.RowIndex].Selected = true;
                btn_agregar.Enabled = true;
                btn_quitar.Enabled = false;
            }
        }

        private void Dgv_productos_stock_SelectionChanged(object sender, EventArgs e)
        {
            // Primero verifico si hay al menos una fila seleccionada
            if (dgv_productos_stock.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_productos_stock.SelectedRows[0];

                // Asigno los valores de la fila a los labels
                txtbox_cantidad.Text = "1";
            }
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgv_productos_stock.SelectedRows[0];

            try
            {
                if (int.Parse(txtbox_cantidad.Text) <= 0)
                {
                    txtbox_cantidad.Text = "1";
                    throw new MyExceptions("Ingrese una cantidad valida..");
                }

                int cantProd = 0;

                if(cantProd == 0) cantProd += int.Parse(txtbox_cantidad.Text);

                foreach (DetalleFactura item in factura.ListaDetalles)
                {
                    if (item.IDProducto == filaSeleccionada.Cells["IDProducto"].Value.ToString())
                    {

                        if ((cantProd + int.Parse(txtbox_cantidad.Text)) > int.Parse(filaSeleccionada.Cells["CantidadEnStock"].Value.ToString()))
                        {
                            throw new MyExceptions("Limite de stock alcanzado para este producto..");
                        }
                        else 
                        { 
                            cantProd += int.Parse(txtbox_cantidad.Text);
                        }

                    }
                }

                if (cantProd >= int.Parse(filaSeleccionada.Cells["CantidadEnStock"].Value.ToString()))
                {
                    throw new MyExceptions("Limite de stock alcanzado para este producto..");
                }

                if (int.Parse(filaSeleccionada.Cells["CantidadEnStock"].Value.ToString()) >= int.Parse(txtbox_cantidad.Text))
                {
                    factura.AgregarProductos(filaSeleccionada.Cells["IDProducto"].Value.ToString(), int.Parse(txtbox_cantidad.Text), decimal.Parse(filaSeleccionada.Cells["PrecioVenta"].Value.ToString().TrimStart('$')));

                    // Clona la fila para agregarla al segundo DataGridView
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgv_productos_factura);

                    newRow.Cells[0].Value = filaSeleccionada.Cells["NombreProducto"].Value;
                    newRow.Cells[1].Value = filaSeleccionada.Cells["PrecioVenta"].Value;
                    newRow.Cells[2].Value = txtbox_cantidad.Text;

                    // Agrega la nueva fila al segundo DataGridView
                    dgv_productos_factura.Rows.Add(newRow);

                    //Finalmente modifico el total mostrado en la interfaz
                    lbl_total.Text = "Total: $" + factura.CalcularTotal();

                }
                else
                {
                    MessageBox.Show("El producto seleccionado no dispone de la cantidad de stock ingresada..");
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

        private void AbrirFormEnPanel(object Formulario)
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

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new IVENDEDOR(IDVendedor));
        }

        private void CerrarSesion(object Formulario)
        {

            //PanelCentral.Controls.Clear();
            //PanelLateral.Controls.Clear();

            Form FH = Formulario as Form;
            FH.WindowState = FormWindowState.Maximized;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;

            this.Controls.Add(FH);
            FH.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtbox_idcliente.Text)) throw new MyExceptions("Ingrese un ID de cliente..");
                if (factura.ListaDetalles.Count <= 0) throw new MyExceptions("Debe agregar productos a la factura para continuar..");

                DateTime fechaActual = DateTime.Now;
                // Formatear la fecha y hora como una cadena
                string fechaFormateada = fechaActual.ToString("yyyy-MM-dd HH:mm:ss.fff");

                decimal total = factura.CalcularTotal();

                if (factura.GenerarFactura(this.IDVendedor, txtbox_idcliente.Text, fechaFormateada, total))
                {
                    factura.SetIDFacturaADetalleFactura();

                    DetalleFactura detFact = new DetalleFactura();

                    if (detFact.InsertarDetallesFactura(factura.ListaDetalles) == true)
                    {
                        if (detFact.ActualizarStockProductos(factura.ListaDetalles) == true)
                        {
                            MessageBox.Show("Venta realizada con éxito!");
                        }
                        else 
                        {
                            MessageBox.Show("Error al actualizar stock de productos..");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Error al registrar detalles de factura..");
                    }
                }
                else
                {
                    MessageBox.Show("Error al generar la factura..");
                }
            }
            catch (SqlException ex) //Atrapo las excepciones provenientes de la Base de Datos
            {
                if (ex.Number == 547)//Excepcion que controla un cliente no registrado
                {
                    MessageBox.Show("El ID del cliente no se encuentra registrado..");
                }
                else
                {   //Excepciones Sql generales
                    MessageBox.Show("Error " + ex.Number + ": " + ex.Message + ".");
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

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgv_productos_factura.SelectedRows[0];

            factura.SacarProductos(filaSeleccionada.Index);

            dgv_productos_factura.Rows.Remove(filaSeleccionada);

            //Finalmente modifico el total mostrado en la interfaz
            lbl_total.Text = "Total: $" + factura.CalcularTotal();
        }

        private void txtbox_idcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
