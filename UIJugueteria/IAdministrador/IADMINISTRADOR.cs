﻿using BLL;
using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIJugueteria
{
    public partial class IADMINISTRADOR : Form
    {
        string RolPrevio;
        public IADMINISTRADOR()
        {
            InitializeComponent();
            btn_modif_empleado.Enabled = false;
            
            //Cambio algunas propiedades de las grillas para modificar su comportamiento
            dataGridViewEmpleados.SelectionChanged += DataGridViewEmpleados_SelectionChanged;
            dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmpleados.CellClick += DataGridViewEmpleados_CellClick;
            dataGridViewEmpleados.MultiSelect = false;
            dataGridViewEmpleados.ReadOnly = true;

            //Remuevo las tablas que no son principales de la interfaz
            tabAdminEmpleados.TabPages.Remove(tabModificar);
            tabAdminEmpleados.TabPages.Remove(tabVerEmpleados);

            //Agrego valores a los comboBoxes de la tabla de modificación de empleado
            comboBox_rol.Items.Add("Vendedor");
            comboBox_rol.Items.Add("Administrador");
            comboBox_rol.Items.Add("Logistica");
            comboBox_rol.Items.Add("Indefinido");

            comboBox_estado.Items.Add("Habilitado");
            comboBox_estado.Items.Add("Deshabilitado");
        }

        private void DataGridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifico si el clic fue en una celda válida y no en encabezados de alguna columna
            if (e.RowIndex >= 0)
            {
                // Selecciono la fila completa
                dataGridViewEmpleados.Rows[e.RowIndex].Selected = true;
                btn_modif_empleado.Enabled = true;
            }
        }

        private void DataGridViewEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            // Primero verifico si hay al menos una fila seleccionada
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewEmpleados.SelectedRows[0];

                // Asigno los valores de la fila a los labels
                label_nombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                label_apellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                label_dni.Text = filaSeleccionada.Cells["DNI"].Value.ToString();
                label_nombreusuario.Text = filaSeleccionada.Cells["NombreUsuario"].Value.ToString();
                comboBox_rol.Text = filaSeleccionada.Cells["Rol"].Value.ToString();
                comboBox_estado.Text = filaSeleccionada.Cells["Habilitado"].Value.ToString();
                textBox_sueldo.Text = filaSeleccionada.Cells["sueldo"].Value.ToString().TrimStart('$');
                this.RolPrevio = filaSeleccionada.Cells["Rol"].Value.ToString();
            }
            else
            {
                // Limpio los labels si no hay filas seleccionadas
                label_nombre.Text = "";
                label_apellido.Text = "";
                label_dni.Text = "";
                label_nombreusuario.Text = "";
            }
        }

        private void IADMINISTRADOR_Load(object sender, EventArgs e)
        {
            //Limpio la tabla
            dataGridViewEmpleados.Rows.Clear();

            try
            {
                //Traigo de la BD la lista de empleados 
                BLL.Administrador admin = new BLL.Administrador();

                List<Empleado> empleados = admin.ListarEmpleados();

                foreach (Empleado item in empleados)
                {
                    string sueldoString = item.Sueldo.ToString("N2", new System.Globalization.CultureInfo("es-ES"));
                    //Inserto cada fila de la lista de empleados en la grilla de la interfaz
                    dataGridViewEmpleados.Rows.Add(item.Nombre, item.Apellido, item.DNI, item.NombreUsuario, item.Rol, "$" + sueldoString, item.Habilitado);
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

        private void btn_modif_empleado_Click_1(object sender, EventArgs e)
        {
            //Modifico la visibilidad de las tabs para mostrar la que necesito
            tabAdminEmpleados.TabPages.Remove(tabSeleccionar);
            tabAdminEmpleados.TabPages.Add(tabModificar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Valido que el textbox sueldo no venga vacío
                if (string.IsNullOrEmpty(textBox_sueldo.Text)) throw new MyExceptions("El campo Sueldo no puede estar vacio..");

                //Este boton almacena los datos actualizados del usuario seleccionado

                BLL.Administrador admin = new BLL.Administrador();

                //Formateo el input del sueldo para que contenga el punto
                string Sueldotexto = textBox_sueldo.Text.Replace(',', '.');
                decimal _Sueldo;

                //Valido que el textbox sueldo solo contenga números
                if (decimal.TryParse(Sueldotexto, NumberStyles.Any, CultureInfo.InvariantCulture, out _Sueldo) == false) throw new MyExceptions("El sueldo solo puede contener números..");

                //Valido que el sueldo ingresado no sea negativo
                if (decimal.Parse(textBox_sueldo.Text) < 0) throw new MyExceptions("El campo Sueldo no puede ser negativo..");

                //Actualizo los datos del empleado con los nuevos datos asignados
                if (admin.ActualizarDatosUsuario(this.RolPrevio, label_nombreusuario.Text, comboBox_rol.Text, comboBox_estado.Text, _Sueldo))
                {
                    MessageBox.Show("Datos de usuario '" + label_nombreusuario.Text + "' actualizados con exito!.");

                    //Modifico la visibilidad de las tablas para mostrar la que necesito
                    tabAdminEmpleados.TabPages.Remove(tabModificar);
                    tabAdminEmpleados.TabPages.Add(tabSeleccionar);

                    //Una vez actualizados los datos recargo la tabla
                    dataGridViewEmpleados.Rows.Clear();
                    List<Empleado> empleados = admin.ListarEmpleados();

                    foreach (Empleado item in empleados)
                    {
                        string sueldoString = item.Sueldo.ToString("N2", new System.Globalization.CultureInfo("es-ES"));
                        //Inserto cada fila en la grilla de la interfaz
                        dataGridViewEmpleados.Rows.Add(item.Nombre, item.Apellido, item.DNI, item.NombreUsuario, item.Rol, "$"+sueldoString, item.Habilitado);
                    }
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos del usuario '" + label_nombreusuario.Text + "'.");
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

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new ILogIn());

        }

        private void AbrirFormEnPanel<MiForm>(Func<MiForm> formFactory) where MiForm : Form
        {
            Form formulario = panel1.Controls.OfType<MiForm>().FirstOrDefault();

            // Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = formFactory();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel1.Controls.Add(formulario);
                panel1.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            // Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void label_dni_Click(object sender, EventArgs e)
        {

        }

        private void tabSeleccionar_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabModificar_Click(object sender, EventArgs e)
        {

        }

        private void tabVerEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnVendoresVentas_Click(object sender, EventArgs e)
        {
            tabAdminEmpleados.TabPages.Remove(tabSeleccionar);
            tabAdminEmpleados.TabPages.Add(tabVerEmpleados);
            try
            {
                //Traigo de la BD la lista de vendedores ordenada por cantidad de ventas
                BLL.Administrador admin = new BLL.Administrador();

                List<BLL.Vendedor> listaVendedores = admin.TraerListaVendedores().OrderByDescending(v => v.CantidadVentas).ToList();

                //limpio la grilla
                dtgvVendedores.Rows.Clear();

                foreach (BLL.Vendedor vendedor in listaVendedores)
                {
                    //formateo el string del sueldo para mostrarlo con separación de digitos
                    string sueldoFormateado = vendedor.Sueldo.ToString("N2", new System.Globalization.CultureInfo("es-ES"));

                    int rowIndex = dtgvVendedores.Rows.Add(vendedor.Nombre, vendedor.Apellido, vendedor.IDEmpleado, vendedor.Habilitado, "$ " + sueldoFormateado, vendedor.CantidadVentas);
                
                    // Obtener la fila actual
                    DataGridViewRow row = dtgvVendedores.Rows[rowIndex];

                    if (vendedor.CantidadVentas == 0)
                    {
                        //modifico el color de la fila si se trata de un vendedor con 0 (cero) ventas
                        row.Cells["CantidadVentasVendedor"].Style.BackColor = Color.Brown;
                        row.Cells["CantidadVentasVendedor"].Style.ForeColor = Color.Black;
                    }
                }
                dtgvVendedores.Columns["SueldoVendedor"].DefaultCellStyle.Format = "0.00";

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //modifico la visibilidad de las tabs 
            tabAdminEmpleados.TabPages.Remove(tabVerEmpleados);
            tabAdminEmpleados.TabPages.Add(tabSeleccionar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //modifico la visibilidad de las tabs 
            tabAdminEmpleados.TabPages.Remove(tabModificar);
            tabAdminEmpleados.TabPages.Add(tabSeleccionar);
        }

        private void dtgvVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
