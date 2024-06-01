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
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_confirmar_venta = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.dgv_productos_stock = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtbox_cantidad = new System.Windows.Forms.TextBox();
            this.dgv_productos_factura = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_idcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_factura)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_quitar
            // 
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btn_quitar.ForeColor = System.Drawing.Color.White;
            this.btn_quitar.Location = new System.Drawing.Point(520, 339);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_quitar.TabIndex = 0;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Enabled = false;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(369, 339);
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
            this.btn_confirmar_venta.Location = new System.Drawing.Point(653, 297);
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
            this.lbl_total.Location = new System.Drawing.Point(638, 260);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(62, 25);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total:";
            // 
            // dgv_productos_stock
            // 
            this.dgv_productos_stock.AllowUserToAddRows = false;
            this.dgv_productos_stock.AllowUserToDeleteRows = false;
            this.dgv_productos_stock.AllowUserToResizeRows = false;
            this.dgv_productos_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.PrecioVenta,
            this.CantidadEnStock});
            this.dgv_productos_stock.Location = new System.Drawing.Point(3, 31);
            this.dgv_productos_stock.MultiSelect = false;
            this.dgv_productos_stock.Name = "dgv_productos_stock";
            this.dgv_productos_stock.RowHeadersVisible = false;
            this.dgv_productos_stock.Size = new System.Drawing.Size(303, 326);
            this.dgv_productos_stock.TabIndex = 7;
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
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(364, 307);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(97, 25);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtbox_cantidad
            // 
            this.txtbox_cantidad.Location = new System.Drawing.Point(467, 310);
            this.txtbox_cantidad.Name = "txtbox_cantidad";
            this.txtbox_cantidad.Size = new System.Drawing.Size(128, 20);
            this.txtbox_cantidad.TabIndex = 10;
            // 
            // dgv_productos_factura
            // 
            this.dgv_productos_factura.AllowUserToAddRows = false;
            this.dgv_productos_factura.AllowUserToDeleteRows = false;
            this.dgv_productos_factura.AllowUserToResizeRows = false;
            this.dgv_productos_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Cantidad});
            this.dgv_productos_factura.Location = new System.Drawing.Point(324, 44);
            this.dgv_productos_factura.Name = "dgv_productos_factura";
            this.dgv_productos_factura.RowHeadersVisible = false;
            this.dgv_productos_factura.Size = new System.Drawing.Size(308, 258);
            this.dgv_productos_factura.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "PrecioUnitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, -22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nueva factura";
            // 
            // txtbox_idcliente
            // 
            this.txtbox_idcliente.Location = new System.Drawing.Point(677, 211);
            this.txtbox_idcliente.Name = "txtbox_idcliente";
            this.txtbox_idcliente.Size = new System.Drawing.Size(100, 20);
            this.txtbox_idcliente.TabIndex = 15;
            this.txtbox_idcliente.TextChanged += new System.EventHandler(this.txtbox_idcliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(679, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_productos_stock);
            this.panel1.Controls.Add(this.txtbox_cantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblcantidad);
            this.panel1.Controls.Add(this.txtbox_idcliente);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.btn_confirmar_venta);
            this.panel1.Controls.Add(this.btn_quitar);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.dgv_productos_factura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 368);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(449, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Factura";
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(799, 368);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaVenta";
            this.Text = "NuevaVenta";
            this.Load += new System.EventHandler(this.NuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_factura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_confirmar_venta;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridView dgv_productos_stock;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtbox_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEnStock;
        private System.Windows.Forms.DataGridView dgv_productos_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_idcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}