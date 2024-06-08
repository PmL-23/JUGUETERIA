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

namespace UIJugueteria.ILogistica.ControlarStock
{
    public partial class EditarStock : Form
    {
        BLL.Producto ProductoEnForm = new BLL.Producto();
        BLL.Logistica logistica = new BLL.Logistica();
        
        public EditarStock(string _IDPRODUCTO)
        {
            InitializeComponent();
            try 
            { 
                ProductoEnForm = logistica.TraerUnProducto(_IDPRODUCTO);


                lblIDEmpleadoCreadorProducto.Text = ProductoEnForm.IDCreadorProducto.ToString();
                lblFechaCreacionProducto.Text = ProductoEnForm.FechaDeCreacion.ToString();
                idproducto.Text = ProductoEnForm.IDProducto.ToString();

                tboxNombreProducto.Text = ProductoEnForm.NombreProducto.ToString();

                label1.Text = ProductoEnForm.Costo.ToString();
                label2.Text = ProductoEnForm.Precioventa.ToString();
            
                tboxStockDisponible.Text = ProductoEnForm.CantidadEnStock.ToString();
                tboxStockMinimoIdeal.Text = ProductoEnForm.CantidadMinimaPermitida.ToString();
            
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



    
        private void panel1_Paint(object sender, PaintEventArgs e) { }



        private void lblIIDEmpleadorCreador_Click(object sender, EventArgs e) { }
        private void lblFechaCreacion_Click(object sender, EventArgs e) { }
        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void lblNombreProductoEstatico_Click(object sender, EventArgs e) { }
        private void lblCosto_Click(object sender, EventArgs e) { }
        private void lblPrecioVenta_Click(object sender, EventArgs e) { }
        private void lblStockDisponible_Click(object sender, EventArgs e) { }
        private void lblStockMinimo_Click(object sender, EventArgs e) { }



        private void lblIDEmpleadoCreadorProducto_Click(object sender, EventArgs e) { }
        private void lblFechaCreacionProducto_Click(object sender, EventArgs e) { }
        private void idproducto_Click(object sender, EventArgs e) { }

        private void tboxNombreProducto_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void tboxStockDisponible_TextChanged(object sender, EventArgs e) { }
        private void tboxStockMinimoIdeal_TextChanged(object sender, EventArgs e) { }

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



        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            //funciona para mandar los cambios a la BDD
            if (tboxNombreProducto.Text == "" || tboxStockDisponible.Text == "" || tboxStockMinimoIdeal.Text == "")
            {
                MessageBox.Show("\tComplete todos los campos\t");               //el usuario no completo todos los campos
            }
            else
            {
                try 
                {
                    if (tboxNombreProducto.Text == ProductoEnForm.NombreProducto.ToString() && tboxStockDisponible.Text == ProductoEnForm.CantidadEnStock.ToString() && tboxStockMinimoIdeal.Text == ProductoEnForm.CantidadMinimaPermitida.ToString())
                    {
                        MessageBox.Show("\tDebe cambiar al menos 1 campo\t");               //el usuario no modifico los campos
                    }
                    else
                    {
                        string stockdisponibletext = tboxStockDisponible.Text;
                        int _StockDisponible;
                        if (int.TryParse(stockdisponibletext, out _StockDisponible))
                        {
                            string stockminimoidealtext = tboxStockMinimoIdeal.Text;
                            int _StockMinimoIdeal;
                            if (int.TryParse(stockminimoidealtext, out _StockMinimoIdeal))
                            {
                                //ESTA FUNCIONA
                                bool resultado = logistica.ControlarStock(tboxNombreProducto.Text, _StockDisponible, _StockMinimoIdeal, idproducto.Text);

                                if (resultado)
                                {
                                    MessageBox.Show("Producto modificado con exito");
                                        AbrirFormEnPanel(() => new IControlarSoloStock());
                                }

                                else
                                {
                                    MessageBox.Show("El producto seleccionado no existe en la Base de Datos");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El formato del Stock Minimo Ideal del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else
                        {
                            MessageBox.Show("El formato del Stock Disponible del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                
            {
                MessageBox.Show("Ingrese una IDProducto a buscar.");
            }
            else
            {
                try 
                {
                    BLL.Logistica log = new BLL.Logistica();                          //Instanciamos un objeto de la BLL, para asi usar sus metodos.
                    bool VerSiExiste = log.VerSiExisteProducto(textBox1.Text);            //Guardamos en VerSiExiste lo que devuelve el metedo. 

                    if (VerSiExiste)        //Si el producto existe, lo mostramos y permimos editarlo.
                    {
                        AbrirFormEnPanel(() => new EditarStock(textBox1.Text));
                    }
                    else
                    {                           //Si el producto NO existe, mostramos un mensaje.
                        MessageBox.Show("El producto con ID: '" + textBox1.Text + "' NO en la Base de Datos", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new IControlarSoloStock());
        }


    }
}
