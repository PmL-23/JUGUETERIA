namespace UIJugueteria
{
    partial class NuevaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_confirmar_venta = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtbox_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_idcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cambiar_cant = new System.Windows.Forms.Button();
            this.dgv_productos_factura = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_productos_stock = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quitar
            // 
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btn_quitar.ForeColor = System.Drawing.Color.White;
            this.btn_quitar.Location = new System.Drawing.Point(199, 335);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_quitar.TabIndex = 0;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Enabled = false;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(47, 335);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(716, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_confirmar_venta
            // 
            this.btn_confirmar_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar_venta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btn_confirmar_venta.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar_venta.Location = new System.Drawing.Point(643, 253);
            this.btn_confirmar_venta.Name = "btn_confirmar_venta";
            this.btn_confirmar_venta.Size = new System.Drawing.Size(138, 49);
            this.btn_confirmar_venta.TabIndex = 3;
            this.btn_confirmar_venta.Text = "Confirmar venta";
            this.btn_confirmar_venta.UseVisualStyleBackColor = true;
            this.btn_confirmar_venta.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(638, 187);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(89, 25);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total: $0";
            this.lbl_total.Click += new System.EventHandler(this.lbl_total_Click);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(358, 331);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(97, 25);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtbox_cantidad
            // 
            this.txtbox_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtbox_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_cantidad.Enabled = false;
            this.txtbox_cantidad.ForeColor = System.Drawing.Color.White;
            this.txtbox_cantidad.Location = new System.Drawing.Point(461, 336);
            this.txtbox_cantidad.Name = "txtbox_cantidad";
            this.txtbox_cantidad.Size = new System.Drawing.Size(92, 20);
            this.txtbox_cantidad.TabIndex = 10;
            this.txtbox_cantidad.TextChanged += new System.EventHandler(this.txtbox_cantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista de productos";
            // 
            // txtbox_idcliente
            // 
            this.txtbox_idcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtbox_idcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_idcliente.ForeColor = System.Drawing.Color.White;
            this.txtbox_idcliente.Location = new System.Drawing.Point(650, 134);
            this.txtbox_idcliente.Name = "txtbox_idcliente";
            this.txtbox_idcliente.Size = new System.Drawing.Size(131, 20);
            this.txtbox_idcliente.TabIndex = 15;
            this.txtbox_idcliente.TextChanged += new System.EventHandler(this.txtbox_idcliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(653, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID del cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btn_cambiar_cant);
            this.panel1.Controls.Add(this.dgv_productos_factura);
            this.panel1.Controls.Add(this.dgv_productos_stock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbox_cantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblcantidad);
            this.panel1.Controls.Add(this.txtbox_idcliente);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.btn_confirmar_venta);
            this.panel1.Controls.Add(this.btn_quitar);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 365);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_cambiar_cant
            // 
            this.btn_cambiar_cant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cambiar_cant.Enabled = false;
            this.btn_cambiar_cant.FlatAppearance.BorderSize = 0;
            this.btn_cambiar_cant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiar_cant.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btn_cambiar_cant.ForeColor = System.Drawing.Color.White;
            this.btn_cambiar_cant.Location = new System.Drawing.Point(559, 334);
            this.btn_cambiar_cant.Name = "btn_cambiar_cant";
            this.btn_cambiar_cant.Size = new System.Drawing.Size(57, 21);
            this.btn_cambiar_cant.TabIndex = 20;
            this.btn_cambiar_cant.Text = "cambiar";
            this.btn_cambiar_cant.UseVisualStyleBackColor = true;
            this.btn_cambiar_cant.Click += new System.EventHandler(this.btn_cambiar_cant_Click);
            // 
            // dgv_productos_factura
            // 
            this.dgv_productos_factura.AllowUserToAddRows = false;
            this.dgv_productos_factura.AllowUserToDeleteRows = false;
            this.dgv_productos_factura.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_productos_factura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos_factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos_factura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgv_productos_factura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productos_factura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_productos_factura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos_factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PrecioUnitario,
            this.Cantidad});
            this.dgv_productos_factura.EnableHeadersVisualStyles = false;
            this.dgv_productos_factura.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_productos_factura.Location = new System.Drawing.Point(324, 31);
            this.dgv_productos_factura.MultiSelect = false;
            this.dgv_productos_factura.Name = "dgv_productos_factura";
            this.dgv_productos_factura.ReadOnly = true;
            this.dgv_productos_factura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos_factura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos_factura.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_productos_factura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_productos_factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos_factura.Size = new System.Drawing.Size(308, 271);
            this.dgv_productos_factura.TabIndex = 19;
            this.dgv_productos_factura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_factura_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // dgv_productos_stock
            // 
            this.dgv_productos_stock.AllowUserToAddRows = false;
            this.dgv_productos_stock.AllowUserToDeleteRows = false;
            this.dgv_productos_stock.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_productos_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_productos_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos_stock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgv_productos_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productos_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_productos_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_productos_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.PrecioVenta,
            this.CantidadEnStock});
            this.dgv_productos_stock.EnableHeadersVisualStyles = false;
            this.dgv_productos_stock.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_productos_stock.Location = new System.Drawing.Point(3, 31);
            this.dgv_productos_stock.MultiSelect = false;
            this.dgv_productos_stock.Name = "dgv_productos_stock";
            this.dgv_productos_stock.ReadOnly = true;
            this.dgv_productos_stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_productos_stock.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_productos_stock.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_productos_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos_stock.Size = new System.Drawing.Size(303, 298);
            this.dgv_productos_stock.TabIndex = 18;
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "ID";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // CantidadEnStock
            // 
            this.CantidadEnStock.HeaderText = "EnStock";
            this.CantidadEnStock.Name = "CantidadEnStock";
            this.CantidadEnStock.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(385, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lista de nueva venta";
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(799, 365);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaVenta";
            this.Text = "NuevaVenta";
            this.Load += new System.EventHandler(this.NuevaVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_confirmar_venta;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtbox_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_idcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_productos_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEnStock;
        private System.Windows.Forms.DataGridView dgv_productos_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btn_cambiar_cant;
    }
}