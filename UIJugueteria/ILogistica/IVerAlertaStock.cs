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

namespace UIJugueteria.ILogistica
{
    public partial class IVerAlertaStock : Form
    {
        

        public IVerAlertaStock()
        {
            InitializeComponent();

            try                 //hacemos toda la inicializacion dentro de un try para controlar una posible excepcion.
            {
                BLL.Logistica logistica = new BLL.Logistica();    //Intanciamos BLL.Logistica para usar sus metodos.


                List<BLL.Producto> listaProductos = logistica.VerAlertarBajoStock();
                //poblamos una lista con VerAlertarBajoStock()

                int contador = listaProductos.Count;
                lblCantidadProductos.Text = contador.ToString();   //hacemos un contador para mostrar la cantidad de filas que traimos con
                                                                   //VerAlertarBajoStock

                dtgvVerProductos.Rows.Clear();//limpiamos la grilla para empezar a poblarla.

                foreach (BLL.Producto producto in listaProductos)       //recorremo la lista traida por VerAlertarBajoStock y vamos
                {                                                         //agregando a la grilla.
                    dtgvVerProductos.Rows.Add(producto.IDCreadorProducto, producto.IDProducto, producto.NombreProducto, producto.FechaDeCreacion, producto.CantidadMinimaPermitida, producto.CantidadEnStock);            
                }
                dtgvVerProductos.CellFormatting += dtgvVerProductos_CellFormatting; //agregamos una propiedad estetica a la grilla que
                                                                                    //configuraremos mas adelante
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

        private void dtgvVerProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvVerProductos.Columns[e.ColumnIndex].Name == "StockProducto")//configuramos con un colo especifico la celda de las
            {                                                                     //filas que cumplan con la condicion
            
                // Cambia el color de fondo y el color de la fuente
                //e.CellStyle.BackColor = Color.FromArgb(255, 128, 128);
                e.CellStyle.BackColor = Color.Firebrick;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, 10);
            }
            if (dtgvVerProductos.Columns[e.ColumnIndex].Name == "StockMinimoIdeal")//configuramos con un colo especifico la celda de las
            {                                                                     //filas que cumplan con la condicion
                e.CellStyle.BackColor = Color.DarkGreen;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, 10);
            }
        }

        private void lblCantidadProductos_Click(object sender, EventArgs e) { } //eventos en los que NO agregamos codigo 

        private void IVerAlertaStock_Load(object sender, EventArgs e) { }   

        private void dtgvVerProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void dtgvVerProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

    }
}
