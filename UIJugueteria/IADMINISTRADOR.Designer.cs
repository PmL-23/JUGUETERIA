namespace UIJugueteria
{
    partial class IADMINISTRADOR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabAdminEmpleados = new System.Windows.Forms.TabControl();
            this.tabSeleccionar = new System.Windows.Forms.TabPage();
            this.btnVendoresVentas = new System.Windows.Forms.Button();
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.btn_modif_empleado = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label_nombreusuario = new System.Windows.Forms.Label();
            this.label_dni = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_sueldo = new System.Windows.Forms.TextBox();
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.comboBox_rol = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabVerEmpleados = new System.Windows.Forms.TabPage();
            this.dtgvVendedores = new System.Windows.Forms.DataGridView();
            this.NombreVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HabilitadoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVentasVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAdminEmpleados.SuspendLayout();
            this.tabSeleccionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.tabModificar.SuspendLayout();
            this.tabVerEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVendedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdminEmpleados
            // 
            this.tabAdminEmpleados.Controls.Add(this.tabSeleccionar);
            this.tabAdminEmpleados.Controls.Add(this.tabModificar);
            this.tabAdminEmpleados.Controls.Add(this.tabVerEmpleados);
            this.tabAdminEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdminEmpleados.Location = new System.Drawing.Point(0, 0);
            this.tabAdminEmpleados.Name = "tabAdminEmpleados";
            this.tabAdminEmpleados.SelectedIndex = 0;
            this.tabAdminEmpleados.Size = new System.Drawing.Size(799, 365);
            this.tabAdminEmpleados.TabIndex = 8;
            // 
            // tabSeleccionar
            // 
            this.tabSeleccionar.Controls.Add(this.btnVendoresVentas);
            this.tabSeleccionar.Controls.Add(this.btnCerrarsesion);
            this.tabSeleccionar.Controls.Add(this.btn_modif_empleado);
            this.tabSeleccionar.Controls.Add(this.dataGridViewEmpleados);
            this.tabSeleccionar.Location = new System.Drawing.Point(4, 22);
            this.tabSeleccionar.Name = "tabSeleccionar";
            this.tabSeleccionar.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeleccionar.Size = new System.Drawing.Size(791, 339);
            this.tabSeleccionar.TabIndex = 0;
            this.tabSeleccionar.Text = "Lista de empleados";
            this.tabSeleccionar.UseVisualStyleBackColor = true;
            this.tabSeleccionar.Click += new System.EventHandler(this.tabSeleccionar_Click_1);
            // 
            // btnVendoresVentas
            // 
            this.btnVendoresVentas.BackColor = System.Drawing.SystemColors.Window;
            this.btnVendoresVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVendoresVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendoresVentas.FlatAppearance.BorderSize = 0;
            this.btnVendoresVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendoresVentas.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVendoresVentas.Location = new System.Drawing.Point(695, 85);
            this.btnVendoresVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVendoresVentas.Name = "btnVendoresVentas";
            this.btnVendoresVentas.Size = new System.Drawing.Size(86, 51);
            this.btnVendoresVentas.TabIndex = 10;
            this.btnVendoresVentas.Text = "Listar Vendores ";
            this.btnVendoresVentas.UseVisualStyleBackColor = false;
            this.btnVendoresVentas.Click += new System.EventHandler(this.btnVendoresVentas_Click);
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarsesion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnCerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarsesion.Location = new System.Drawing.Point(692, 304);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(88, 25);
            this.btnCerrarsesion.TabIndex = 9;
            this.btnCerrarsesion.Text = "Cerrar Sesion";
            this.btnCerrarsesion.UseVisualStyleBackColor = false;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            // 
            // btn_modif_empleado
            // 
            this.btn_modif_empleado.BackColor = System.Drawing.Color.White;
            this.btn_modif_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modif_empleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modif_empleado.FlatAppearance.BorderSize = 0;
            this.btn_modif_empleado.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif_empleado.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_modif_empleado.Location = new System.Drawing.Point(695, 26);
            this.btn_modif_empleado.Margin = new System.Windows.Forms.Padding(0);
            this.btn_modif_empleado.Name = "btn_modif_empleado";
            this.btn_modif_empleado.Size = new System.Drawing.Size(86, 44);
            this.btn_modif_empleado.TabIndex = 2;
            this.btn_modif_empleado.Text = "Modificar";
            this.btn_modif_empleado.UseVisualStyleBackColor = false;
            this.btn_modif_empleado.Click += new System.EventHandler(this.btn_modif_empleado_Click_1);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleados.AllowUserToResizeColumns = false;
            this.dataGridViewEmpleados.AllowUserToResizeRows = false;
            this.dataGridViewEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpleados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.NombreUsuario,
            this.Rol,
            this.Sueldo,
            this.Habilitado});
            this.dataGridViewEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewEmpleados.GridColor = System.Drawing.Color.Black;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmpleados.MultiSelect = false;
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewEmpleados.RowHeadersVisible = false;
            this.dataGridViewEmpleados.ShowEditingIcon = false;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(683, 333);
            this.dataGridViewEmpleados.TabIndex = 0;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick_1);
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.button2);
            this.tabModificar.Controls.Add(this.label_nombreusuario);
            this.tabModificar.Controls.Add(this.label_dni);
            this.tabModificar.Controls.Add(this.label_apellido);
            this.tabModificar.Controls.Add(this.label_nombre);
            this.tabModificar.Controls.Add(this.button1);
            this.tabModificar.Controls.Add(this.textBox_sueldo);
            this.tabModificar.Controls.Add(this.comboBox_estado);
            this.tabModificar.Controls.Add(this.comboBox_rol);
            this.tabModificar.Controls.Add(this.label9);
            this.tabModificar.Controls.Add(this.label8);
            this.tabModificar.Controls.Add(this.label6);
            this.tabModificar.Controls.Add(this.label5);
            this.tabModificar.Controls.Add(this.label4);
            this.tabModificar.Controls.Add(this.label7);
            this.tabModificar.Controls.Add(this.label3);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(791, 339);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "Modificacion de empleado";
            this.tabModificar.UseVisualStyleBackColor = true;
            this.tabModificar.Click += new System.EventHandler(this.tabModificar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(680, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_nombreusuario
            // 
            this.label_nombreusuario.AutoSize = true;
            this.label_nombreusuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label_nombreusuario.Location = new System.Drawing.Point(158, 133);
            this.label_nombreusuario.Name = "label_nombreusuario";
            this.label_nombreusuario.Size = new System.Drawing.Size(171, 19);
            this.label_nombreusuario.TabIndex = 17;
            this.label_nombreusuario.Text = "NombreUsuarioEmpleado";
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label_dni.Location = new System.Drawing.Point(68, 94);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(96, 19);
            this.label_dni.TabIndex = 16;
            this.label_dni.Text = "DNIEmpleado";
            this.label_dni.Click += new System.EventHandler(this.label_dni_Click);
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label_apellido.Location = new System.Drawing.Point(87, 57);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(123, 19);
            this.label_apellido.TabIndex = 15;
            this.label_apellido.Text = "ApellidoEmpleado";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label_nombre.Location = new System.Drawing.Point(87, 18);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(122, 19);
            this.label_nombre.TabIndex = 14;
            this.label_nombre.Text = "NombreEmpleado";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(654, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_sueldo
            // 
            this.textBox_sueldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.textBox_sueldo.Location = new System.Drawing.Point(77, 273);
            this.textBox_sueldo.Name = "textBox_sueldo";
            this.textBox_sueldo.Size = new System.Drawing.Size(131, 25);
            this.textBox_sueldo.TabIndex = 12;
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Location = new System.Drawing.Point(76, 227);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(121, 25);
            this.comboBox_estado.TabIndex = 11;
            // 
            // comboBox_rol
            // 
            this.comboBox_rol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.comboBox_rol.FormattingEnabled = true;
            this.comboBox_rol.Location = new System.Drawing.Point(55, 182);
            this.comboBox_rol.Name = "comboBox_rol";
            this.comboBox_rol.Size = new System.Drawing.Size(121, 25);
            this.comboBox_rol.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(15, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sueldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(15, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(15, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre de usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "D.N.I:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // tabVerEmpleados
            // 
            this.tabVerEmpleados.Controls.Add(this.dtgvVendedores);
            this.tabVerEmpleados.Controls.Add(this.btnVolver);
            this.tabVerEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tabVerEmpleados.Name = "tabVerEmpleados";
            this.tabVerEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerEmpleados.Size = new System.Drawing.Size(791, 339);
            this.tabVerEmpleados.TabIndex = 2;
            this.tabVerEmpleados.Text = "Ver Empleados";
            this.tabVerEmpleados.UseVisualStyleBackColor = true;
            this.tabVerEmpleados.Click += new System.EventHandler(this.tabVerEmpleados_Click);
            // 
            // dtgvVendedores
            // 
            this.dtgvVendedores.AllowUserToAddRows = false;
            this.dtgvVendedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvVendedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvVendedores.BackgroundColor = System.Drawing.Color.White;
            this.dtgvVendedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvVendedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvVendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreVendedor,
            this.ApellidoVendedor,
            this.IDVendedor,
            this.HabilitadoVendedor,
            this.SueldoVendedor,
            this.CantidadVentasVendedor});
            this.dtgvVendedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvVendedores.Location = new System.Drawing.Point(3, 3);
            this.dtgvVendedores.Name = "dtgvVendedores";
            this.dtgvVendedores.ReadOnly = true;
            this.dtgvVendedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVendedores.Size = new System.Drawing.Size(683, 333);
            this.dtgvVendedores.TabIndex = 11;
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.HeaderText = "Nombres";
            this.NombreVendedor.Name = "NombreVendedor";
            this.NombreVendedor.ReadOnly = true;
            // 
            // ApellidoVendedor
            // 
            this.ApellidoVendedor.HeaderText = "Apellido";
            this.ApellidoVendedor.Name = "ApellidoVendedor";
            this.ApellidoVendedor.ReadOnly = true;
            // 
            // IDVendedor
            // 
            this.IDVendedor.HeaderText = "ID";
            this.IDVendedor.Name = "IDVendedor";
            this.IDVendedor.ReadOnly = true;
            // 
            // HabilitadoVendedor
            // 
            this.HabilitadoVendedor.HeaderText = "Habilitado";
            this.HabilitadoVendedor.Name = "HabilitadoVendedor";
            this.HabilitadoVendedor.ReadOnly = true;
            // 
            // SueldoVendedor
            // 
            this.SueldoVendedor.HeaderText = "Sueldo";
            this.SueldoVendedor.Name = "SueldoVendedor";
            this.SueldoVendedor.ReadOnly = true;
            // 
            // CantidadVentasVendedor
            // 
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadVentasVendedor.DefaultCellStyle = dataGridViewCellStyle18;
            this.CantidadVentasVendedor.HeaderText = "Ventas";
            this.CantidadVentasVendedor.Name = "CantidadVentasVendedor";
            this.CantidadVentasVendedor.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkRed;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(692, 304);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 25);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabAdminEmpleados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 365);
            this.panel1.TabIndex = 9;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "D.N.I";
            this.DNI.Name = "DNI";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Usuario";
            this.NombreUsuario.Name = "NombreUsuario";
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // Habilitado
            // 
            this.Habilitado.HeaderText = "Estado";
            this.Habilitado.Name = "Habilitado";
            // 
            // IADMINISTRADOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 365);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IADMINISTRADOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IADMINISTRADOR";
            this.Load += new System.EventHandler(this.IADMINISTRADOR_Load);
            this.tabAdminEmpleados.ResumeLayout(false);
            this.tabSeleccionar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabVerEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVendedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabAdminEmpleados;
        private System.Windows.Forms.TabPage tabSeleccionar;
        private System.Windows.Forms.Button btn_modif_empleado;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.Label label_nombreusuario;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_sueldo;
        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.ComboBox comboBox_rol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVendoresVentas;
        private System.Windows.Forms.TabPage tabVerEmpleados;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtgvVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn HabilitadoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVentasVendedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitado;
    }
}