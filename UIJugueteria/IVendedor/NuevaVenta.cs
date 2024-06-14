using BLL;
using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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

            //Cambio propiedades de los datagridview para modificar su comportamiento 
            dgv_productos_stock.SelectionChanged += Dgv_productos_stock_SelectionChanged;
            dgv_productos_stock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos_stock.CellClick += Dgv_productos_stock_CellClick;
            dgv_productos_stock.MultiSelect = false;
            dgv_productos_stock.ReadOnly = true;

            //Cambio propiedades de los datagridview para modificar su comportamiento 
            dgv_productos_factura.SelectionChanged += Dgv_productos_factura_SelectionChanged;
            dgv_productos_factura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos_factura.CellClick += Dgv_productos_factura_CellClick;
            dgv_productos_factura.MultiSelect = false;
            dgv_productos_factura.ReadOnly = true;


            //LLAMO A UN MÉTODO QUE ME TRAE LA LISTA ENTERA DE PRODUCTOS
            BLL.Logistica logistica = new BLL.Logistica();

            List<BLL.Producto> listaProductos = logistica.TraerListaProductos();

            dgv_productos_stock.Rows.Clear();
            dgv_productos_factura.Rows.Clear();

            foreach (BLL.Producto producto in listaProductos)
            {
                // Por cada producto agrego una nueva fila al DataGridView y asigno los valores de las celdas
                dgv_productos_stock.Rows.Add(producto.IDProducto, producto.NombreProducto, "$" + producto.Precioventa, producto.CantidadEnStock);
            }

        }

        private void Dgv_productos_factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifico si el clic fue en una celda válida y no en encabezados de alguna columna
            if (e.RowIndex >= 0)
            {
                // Selecciono la fila completa clickeada por el usuario
                dgv_productos_factura.Rows[e.RowIndex].Selected = true;
                btn_quitar.Enabled = true;
                txtbox_cantidad.Enabled = true;
                btn_cambiar_cant.Enabled = true;
                btn_agregar.Enabled = false;
            }
        }

        private void Dgv_productos_factura_SelectionChanged(object sender, EventArgs e)
        {
            // Primero verifico si hay al menos una fila seleccionada
            if (dgv_productos_factura.SelectedRows.Count > 0)
            {
                //Al clickear una fila de la lista cambio el textbox Cantidad al valor correspondiente
                DataGridViewRow filaSeleccionada = dgv_productos_factura.SelectedRows[0];
                txtbox_cantidad.Text = factura.ListaDetalles[filaSeleccionada.Index].Cantidad.ToString();
            }
            else 
            {
                //Si se clickea en la grilla de productos desactivo el botón 'quitar'
                btn_quitar.Enabled = false;   
            }
        }

        private void Dgv_productos_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifico si el clic fue en una celda válida y no en encabezados de alguna columna
            if (e.RowIndex >= 0)
            {
                // Selecciono la fila completa y deshabilito los componentes de interfaz correspondientes
                dgv_productos_stock.Rows[e.RowIndex].Selected = true;
                btn_agregar.Enabled = true;
                btn_quitar.Enabled = false;
                txtbox_cantidad.Enabled = false;
                btn_cambiar_cant.Enabled = false;
            }
        }

        private void Dgv_productos_stock_SelectionChanged(object sender, EventArgs e)
        {
            // Primero verifico si hay al menos una fila seleccionada
            if (dgv_productos_stock.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_productos_stock.SelectedRows[0];

                //Si se trata de una fila ya agregada a la lista no modifico el color
                if (dgv_productos_stock.Rows[filaSeleccionada.Index].DefaultCellStyle.SelectionBackColor != Color.Brown) { 
                    
                    // Cambia el color de la última fila seleccionada
                    dgv_productos_stock.Rows[filaSeleccionada.Index].DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

                    // Cambia el color de la fuente de la última fila seleccionada
                    dgv_productos_stock.Rows[filaSeleccionada.Index].DefaultCellStyle.SelectionForeColor = Color.White;
                }

                // Asigno los valores de la fila a los labels
                txtbox_cantidad.Text = "1";
            }
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creo una variable del tipo fila de grilla para manejar sus datos
            DataGridViewRow filaSeleccionada = dgv_productos_stock.SelectedRows[0];

            try
            {

                //Verifico la cantidad en stock del producto que intento agregar a la lista de nueva venta
                if (filaSeleccionada.Cells["CantidadEnStock"].Value.ToString() == "0") throw new MyExceptions("Este producto se encuentra sin stock..");

                //verifico si el producto ya se encuentra en la lista
                foreach (DetalleFactura item in factura.ListaDetalles)
                {
                    if (item.Producto.IDProducto == filaSeleccionada.Cells["IDProducto"].Value.ToString())
                    {
                        throw new MyExceptions("Este producto ya se encuentra en la lista..");
                    }
                }

                //Agrego la fila seleccionada de la Lista de productos a la Lista de nueva venta
                factura.AgregarProductos(filaSeleccionada.Cells["IDProducto"].Value.ToString(), int.Parse(txtbox_cantidad.Text), decimal.Parse(filaSeleccionada.Cells["PrecioVenta"].Value.ToString().TrimStart('$')));

                // Clono la fila para agregarla al DataGridView Lista de nueva venta
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv_productos_factura);

                newRow.Cells[0].Value = filaSeleccionada.Cells["NombreProducto"].Value;
                newRow.Cells[1].Value = filaSeleccionada.Cells["PrecioVenta"].Value;
                newRow.Cells[2].Value = txtbox_cantidad.Text;

                // Agrega la nueva fila al segundo DataGridView
                dgv_productos_factura.Rows.Add(newRow);

                //Cambia el color de fondo de la fila
                dgv_productos_stock.Rows[filaSeleccionada.Index].DefaultCellStyle.BackColor = Color.Brown;

                // Cambia el color de la fuente de la fila
                dgv_productos_stock.Rows[filaSeleccionada.Index].DefaultCellStyle.ForeColor = Color.Black;

                // Cambia el color de la última fila seleccionada
                dgv_productos_stock.Rows[filaSeleccionada.Index].DefaultCellStyle.SelectionBackColor = Color.Brown;

                // Cambia el color de la fuente de la última fila seleccionada
                dgv_productos_stock.Rows[filaSeleccionada.Index].DefaultCellStyle.SelectionForeColor = Color.Black;

                //Finalmente modifico el total mostrado en la interfaz
                lbl_subtotal.Text = "$" + factura.CalcularSubtotal().ToString("N2", new System.Globalization.CultureInfo("es-ES"));
                lbl_total.Text = "$" + factura.CalcularTotal().ToString("N2", new System.Globalization.CultureInfo("es-ES"));

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

        private void button3_Click(object sender, EventArgs e)
        {
            //Para volver a la interfaz anterior
            AbrirFormEnPanel(() => new IVENDEDOR(IDVendedor));
        }

        private void CerrarSesion(object Formulario)
        {

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
                //Antes de confirmar la venta verifico el cliente está registrado y que la lista de nueva venta no está vacía
                if (string.IsNullOrEmpty(txtbox_idcliente.Text)) throw new MyExceptions("Ingrese un ID de cliente..");
                if (factura.ListaDetalles.Count <= 0) throw new MyExceptions("Debe agregar productos a la factura para continuar..");

                //Obtengo la fecha y hora actual
                DateTime fechaActual = DateTime.Now;

                // Formatear la fecha y hora como una cadena
                string fechaFormateada = fechaActual.ToString("yyyy-MM-dd HH:mm:ss.fff");

                //Formateo el total para recortar los decimales
                decimal total = decimal.Parse(factura.CalcularTotal().ToString("F2"));

                Vendedor vendedor = new Vendedor();

                //Genero la factura y la guardo en la BD
                if (vendedor.GenerarFactura(this.IDVendedor, txtbox_idcliente.Text, fechaFormateada, total))
                {
                    //Obtengo el valor ID de la factura creada para asignarselo al detalle de factura
                    factura.SetIDFacturaADetalleFactura();

                    DetalleFactura detFact = new DetalleFactura();

                    //Inserto los detalles de la factura en la BD
                    if (detFact.InsertarDetallesFactura(factura.ListaDetalles) == true)
                    {
                        //Resto el stock vendido del stock actual del producto
                        if (detFact.DecrementarStockPosventa(factura.ListaDetalles) == true)
                        {
                            //Sumo la venta y la comisión por venta al vendedor
                            if (vendedor.IncrementarYComisionarVenta(this.IDVendedor, decimal.Parse((total * 0.05M).ToString("F2"))) == true)
                            {
                                Cliente cliente = new Cliente();

                                //Sumo la compra al contador del cliente en la BD
                                if (cliente.AumentarCantCompras(txtbox_idcliente.Text) == true)
                                {

                                    //Imprimo la factura y sus datos por pantalla
                                    string facturaString = "----DETALLE DE FACTURA----\n\n";

                                    facturaString += ("ID del vendedor: " + this.IDVendedor + "\n");
                                    facturaString += ("ID del cliente: " + txtbox_idcliente.Text + "\n\n");
                                    facturaString += ("Fecha y hora: " + fechaActual + "\n\n");

                                    facturaString += "----PRODUCTOS INCLUIDOS----\n\n";

                                    foreach (DataGridViewRow item in dgv_productos_factura.Rows)
                                    {
                                        facturaString += (item.Cells["Nombre"].Value.ToString() + " x " + item.Cells["Cantidad"].Value.ToString() + " = $" + (decimal.Parse(item.Cells["Cantidad"].Value.ToString()) * factura.ListaDetalles[item.Index].Producto.Precioventa) + ".\n");
                                    }

                                    facturaString += "\nSUBTOTAL: $" + factura.CalcularSubtotal();
                                    facturaString += "\nTOTAL (+IVA): $" + factura.CalcularTotal().ToString("F2");

                                    MessageBox.Show(facturaString, "Venta realizada con éxito!", MessageBoxButtons.OK);
                                    //Al terminar vuelvo a la interfaz principal del vendedor
                                    AbrirFormEnPanel(() => new IVENDEDOR(IDVendedor));                                    
                                }
                            }
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
            //Obtengo las filas seleccionadas de ambas grillas y las guardo en variables
            DataGridViewRow filaSeleccionadaFactura = dgv_productos_factura.SelectedRows[0];
            DataGridViewRow filaSeleccionadaStock = dgv_productos_stock.SelectedRows[0];

            //Recorro los productos para modificar visualmente la fila seleccionada
            foreach (DataGridViewRow item in dgv_productos_stock.Rows)
            {
                if (item.Cells["IDProducto"].Value.ToString() == factura.ListaDetalles[filaSeleccionadaFactura.Index].Producto.IDProducto)
                {
                    //fijarse si le podes cambiar el color a la fila y lanzar exepcion de que no podes agregarlo devuelta
                    dgv_productos_stock.Rows[item.Index].DefaultCellStyle.BackColor = Color.FromArgb(30,30,30);

                    // Cambia el color de la fuente de la fila
                    dgv_productos_stock.Rows[item.Index].DefaultCellStyle.ForeColor = Color.White;

                    // Cambia el color de la última fila seleccionada
                    dgv_productos_stock.Rows[item.Index].DefaultCellStyle.SelectionBackColor = Color.FromArgb(30,30,30);

                    // Cambia el color de la fuente de la última fila seleccionada
                    dgv_productos_stock.Rows[item.Index].DefaultCellStyle.SelectionForeColor = Color.White;        
                }
            }

            //Quito el producto de la lista de nueva venta
            factura.SacarProductos(filaSeleccionadaFactura.Index);
            dgv_productos_factura.Rows.Remove(filaSeleccionadaFactura);

            //Finalmente modifico el total mostrado en la interfaz
            lbl_subtotal.Text = "$" + factura.CalcularSubtotal().ToString("N2", new System.Globalization.CultureInfo("es-ES"));
            lbl_total.Text = "$" + factura.CalcularTotal().ToString("N2", new System.Globalization.CultureInfo("es-ES"));
        }

        private void txtbox_idcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_productos_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cambiar_cant_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgv_productos_factura.SelectedRows[0];

            try
            {
                //Valido que el textbox cantidad no esté vacío
                if (string.IsNullOrEmpty(txtbox_cantidad.Text))
                {
                    txtbox_cantidad.Text = "1";
                    throw new MyExceptions("No puede dejar el campo Cantidad vacío..");
                }

                //Valido que la cantidad ingresada sólo contenga números

                string cantidadString = txtbox_cantidad.Text;
                int cantidad;

                if (int.TryParse(cantidadString, out cantidad) == false) 
                {
                    txtbox_cantidad.Text = "1";
                    throw new MyExceptions("La cantidad no puede contener letras");
                }

                //Valido que la cantidad a cambiar del producto sea valida (Debe ser mayor a cero)
                if (int.Parse(txtbox_cantidad.Text) <= 0)
                {
                    txtbox_cantidad.Text = "1";
                    throw new MyExceptions("Ingrese una cantidad valida..");
                }

                //Valido que la cantidad ingresada supere el stock actual del producto
                foreach (DataGridViewRow item in dgv_productos_stock.Rows)
                {
                    if (item.Cells["IDProducto"].Value.ToString() == factura.ListaDetalles[filaSeleccionada.Index].Producto.IDProducto)
                    {
                        if (int.Parse(txtbox_cantidad.Text) > int.Parse(item.Cells["CantidadEnStock"].Value.ToString()))
                        {
                            throw new MyExceptions("Este producto no dispone del stock ingresado..");
                        }
                    }
                }

                //Modifica el cambio de cantidad en la lista de objetos DetalleFactura
                factura.ListaDetalles[filaSeleccionada.Index].Cantidad = int.Parse(txtbox_cantidad.Text);

                //Modifico el cambio en la celda seleccionada
                filaSeleccionada.Cells["Cantidad"].Value = txtbox_cantidad.Text;

                //Finalmente modifico el total mostrado en la interfaz
                lbl_subtotal.Text = "$" + factura.CalcularSubtotal();
                lbl_total.Text = "$" + factura.CalcularTotal().ToString("F2");
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

        private void dgv_productos_factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
