﻿using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIJugueteria
{
    public partial class ICrearNuevoProducto : Form
    {
        private string _NombreUsuario;
        public ICrearNuevoProducto(string _NombreUsuario)
        {
            InitializeComponent();
            this._NombreUsuario = _NombreUsuario;       //guardamos el nombre de usuario en una variable global.
        }

        private void CrearNuevoProducto_Load(object sender, EventArgs e) { }//eventos que no agregamos codigo

        private void lblNombreDeProducto_Click(object sender, EventArgs e) { }
        private void lblIDProducto_Click(object sender, EventArgs e) { }
        private void lblCosto_Click(object sender, EventArgs e) { }
        private void lblPrecioDeVenta_Click(object sender, EventArgs e) { }
        private void lblStockMnimo_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }


        private void tboxNombreProdcuto_TextChanged(object sender, EventArgs e) { }
        private void tboxIDProducto_TextChanged(object sender, EventArgs e) { }
        private void tboxCostoProducto_TextChanged(object sender, EventArgs e) { }
        private void tboxPrecioVentaProducto_TextChanged(object sender, EventArgs e) { }
        private void tboxStockMinimoProducto_TextChanged(object sender, EventArgs e) { }
        private void tboxStock_TextChanged(object sender, EventArgs e) { }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (tboxNombreProducto.Text==""||tboxIDProducto.Text==""||tboxCostoProducto.Text==""||tboxPrecioVentaProducto.Text==""||tboxStockMinimoProducto.Text=="") {
                MessageBox.Show("\tComplete todos los campos\t");               //el usuario no completo todos los campos
            }
            else {
                    try             //hacemos el codigo en un try para capturar una posible exepcion.
                    {
                        string _NombreProducto = tboxNombreProducto.Text;
                        string _IDProducto = tboxIDProducto.Text;                       //guardamos en variables los campos que ingreso el usuario.
                                                                                        //los campos en los que el Usuario puede equivocarlos los tramos con el decimal.TryParse o
                                                                                        //int.TryParse, si podemos seguimos, y si no se lanza una mensaje y se pedimos que los ingrese devuelta,
                                                                                        //esto se hace 5 veces.
                    if (_IDProducto == "13idPRUEBA") throw new MyExceptions("El ID 13idPRUEBA es un IDProducto reservado para pruebas, intente devuelta con otro IDProducto");
                        string costoProductoTexto = tboxCostoProducto.Text.Replace(',', '.');//se usa para que siempre se guarde con , y no con . 
                        decimal _CostoProducto;
                        if (decimal.TryParse(costoProductoTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out _CostoProducto))
                        {
                            if (_CostoProducto <= 0) {
                                MessageBox.Show("El Costo debe ser mayor a 0.");
                            }
                            else {
                                string precioventatext = tboxPrecioVentaProducto.Text.Replace(',', '.');
                                decimal _PrecioVenta;
                                if (decimal.TryParse(precioventatext, NumberStyles.Any, CultureInfo.InvariantCulture, out _PrecioVenta))
                                {
                                    if (_PrecioVenta <= 0)
                                    {
                                        MessageBox.Show("El Precio de Venta debe ser mayor a 0.");
                                    }
                                    else
                                    {

                                        string StockProductoTexto = tboxStock.Text;
                                        int _StockProducto;
                                        if (int.TryParse(StockProductoTexto, out _StockProducto))
                                        {

                                            string stockMinimoProductoTexto = tboxStockMinimoProducto.Text;
                                            int _StockMinimoProducto;
                                            if (int.TryParse(stockMinimoProductoTexto, out _StockMinimoProducto))
                                            {
                                                BLL.Logistica log = new BLL.Logistica();//Instanciamos un objeto de la BLL, para asi usar sus metodos.

                                                DateTime fechaActual = DateTime.Now;
                                                string fechaFormateada = fechaActual.ToString("yyyy-MM-dd HH:mm:ss.fff"); // Creo y formateo la fecha y hora como una cadena

                                                bool VerSiExiste = log.VerSiExisteProducto(_IDProducto); //Guardamos en VerSiExiste lo que devuelve VerSiExisteProducto
                                                if (VerSiExiste)
                                                {               //error de que existe el producto con esa IDProducto ingresada.
                                                    MessageBox.Show("El producto con ID: '" + _IDProducto + "' ya existe en la Base de Datos", "Producto ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    //si pasa todas la validaciones, mandamos a la BLL y esperamos resultado.
                                                    bool resultado = log.CargarProducto(_NombreUsuario, _NombreProducto, _IDProducto, _CostoProducto, fechaFormateada, _PrecioVenta, _StockProducto, _StockMinimoProducto);
                                                    //Con el metodo CargarProducto ya mandamos a la BLL los datos para que la DAL los mande a la BDD, y esperamos a
                                                    //ver que retorna 
                                                    if (resultado)
                                                    {   //se cargo correctamente, mostramos mensajes y vaciamos los TextBox.
                                                        MessageBox.Show("El producto se cargó correctamente.");
                                                        tboxNombreProducto.Text = "";
                                                        tboxIDProducto.Text = "";
                                                        tboxCostoProducto.Text = "";
                                                        tboxPrecioVentaProducto.Text = "";
                                                        tboxStockMinimoProducto.Text = "";
                                                        tboxStock.Text = "";
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Hubo un error al cargar el producto.");
                                                    }
                                                }
                                            }
                                            else        //vamos cerrando los else de errores de formato.
                                            {
                                                MessageBox.Show("El formato de la Cantidad Minima del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El formato del Stock del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El formato del Precio de Venta del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else {
                            MessageBox.Show("El formato del Costo del producto es incorrecto. Por favor ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    }
}
