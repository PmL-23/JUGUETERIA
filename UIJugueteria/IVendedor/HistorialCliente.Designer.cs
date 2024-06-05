namespace UIJugueteria
{
    partial class HistorialCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCompras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerFacturasCliente = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.tboxIDCliente = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.dgv_clientes);
            this.panel1.Controls.Add(this.btnVerFacturasCliente);
            this.panel1.Controls.Add(this.panelSuperior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 365);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCliente,
            this.Nombre,
            this.Apellido,
            this.CantidadCompras,
            this.DNI});
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_clientes.Location = new System.Drawing.Point(0, 38);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_clientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_clientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(667, 324);
            this.dgv_clientes.TabIndex = 58;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
            // 
            // IDCliente
            // 
            this.IDCliente.HeaderText = "IDCliente";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // CantidadCompras
            // 
            this.CantidadCompras.HeaderText = "CantidadCompras";
            this.CantidadCompras.Name = "CantidadCompras";
            this.CantidadCompras.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "D.N.I";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // btnVerFacturasCliente
            // 
            this.btnVerFacturasCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFacturasCliente.ForeColor = System.Drawing.Color.White;
            this.btnVerFacturasCliente.Location = new System.Drawing.Point(679, 175);
            this.btnVerFacturasCliente.Name = "btnVerFacturasCliente";
            this.btnVerFacturasCliente.Size = new System.Drawing.Size(111, 44);
            this.btnVerFacturasCliente.TabIndex = 57;
            this.btnVerFacturasCliente.Text = "Ver Facturas Cliente";
            this.btnVerFacturasCliente.UseVisualStyleBackColor = true;
            this.btnVerFacturasCliente.Click += new System.EventHandler(this.btnVerFacturasCliente_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelSuperior.Controls.Add(this.btnBuscarCliente);
            this.panelSuperior.Controls.Add(this.lblIDCliente);
            this.panelSuperior.Controls.Add(this.tboxIDCliente);
            this.panelSuperior.Controls.Add(this.btnVolver);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(799, 37);
            this.panelSuperior.TabIndex = 55;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(501, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(133, 24);
            this.btnBuscarCliente.TabIndex = 49;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.ForeColor = System.Drawing.Color.White;
            this.lblIDCliente.Location = new System.Drawing.Point(142, 5);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(71, 18);
            this.lblIDCliente.TabIndex = 48;
            this.lblIDCliente.Text = "ID Cliente";
            // 
            // tboxIDCliente
            // 
            this.tboxIDCliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tboxIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxIDCliente.ForeColor = System.Drawing.Color.White;
            this.tboxIDCliente.Location = new System.Drawing.Point(260, 4);
            this.tboxIDCliente.Name = "tboxIDCliente";
            this.tboxIDCliente.Size = new System.Drawing.Size(203, 20);
            this.tboxIDCliente.TabIndex = 52;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVolver.Location = new System.Drawing.Point(3, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(30, 23);
            this.btnVolver.TabIndex = 50;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Volver";
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 365);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialCliente";
            this.Text = "HistorialCliente";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox tboxIDCliente;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerFacturasCliente;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
    }
}