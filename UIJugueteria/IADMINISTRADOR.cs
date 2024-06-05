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
    public partial class IADMINISTRADOR : Form
    {
        string RolPrevio;
        public IADMINISTRADOR()
        {
            InitializeComponent();
            btn_modif_empleado.Enabled = false;
            dataGridViewEmpleados.SelectionChanged += DataGridViewEmpleados_SelectionChanged;
            dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmpleados.CellClick += DataGridViewEmpleados_CellClick;
            dataGridViewEmpleados.MultiSelect = false;
            dataGridViewEmpleados.ReadOnly = true;
            tabAdminEmpleados.TabPages.Remove(tabModificar);

            comboBox_rol.Items.Add("Vendedor");
            comboBox_rol.Items.Add("Administrador");
            comboBox_rol.Items.Add("Logistica");
            comboBox_rol.Items.Add("Cliente");
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
                textBox_sueldo.Text = filaSeleccionada.Cells["Sueldo"].Value.ToString();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IADMINISTRADOR_Load(object sender, EventArgs e)
        {
            BLL.Administrador admin = new BLL.Administrador();

            dataGridViewEmpleados.DataSource = admin.ListarEmpleados();
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifico si el clic fue en una celda válida y no en encabezados de columna
            if (e.RowIndex >= 0)
            {
                // Selecciono la fila completa
                dataGridViewEmpleados.Rows[e.RowIndex].Selected = true;
                btn_modif_empleado.Enabled = true;
            }
        }

        private void tabSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btn_modif_empleado_Click_1(object sender, EventArgs e)
        {
            tabAdminEmpleados.TabPages.Remove(tabSeleccionar);
            tabAdminEmpleados.TabPages.Add(tabModificar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Este boton almacena los datos actualizados del usuario seleccionado

            BLL.Administrador admin = new BLL.Administrador();

            if (admin.ActualizarDatosUsuario(this.RolPrevio,label_nombreusuario.Text, comboBox_rol.Text, comboBox_estado.Text, int.Parse(textBox_sueldo.Text)))
            {
                MessageBox.Show("Datos de usuario '" + label_nombreusuario.Text + "' actualizados con exito!.");
            }
            else
            {
                MessageBox.Show("Error al actualizar los datos del usuario '" + label_nombreusuario.Text + "'.");
            }

            tabAdminEmpleados.TabPages.Remove(tabModificar);
            tabAdminEmpleados.TabPages.Add(tabSeleccionar);

            //Una vez actualizados los datos recargo la tabla
            dataGridViewEmpleados.DataSource = admin.ListarEmpleados();
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
    }
}
