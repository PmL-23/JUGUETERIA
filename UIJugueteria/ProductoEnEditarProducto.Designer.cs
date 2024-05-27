namespace UIJugueteria
{
    partial class ProductoEnEditarProducto
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
            this.lblIIDEmpleadorCreador = new System.Windows.Forms.Label();
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.tboxCosto = new System.Windows.Forms.TextBox();
            this.tboxPrecioVenta = new System.Windows.Forms.TextBox();
            this.tboxStockDisponible = new System.Windows.Forms.TextBox();
            this.tboxStockMinimoIdeal = new System.Windows.Forms.TextBox();
            this.lblIDEmpleadoCreadorProducto = new System.Windows.Forms.Label();
            this.lblFechaCreacionProducto = new System.Windows.Forms.Label();
            this.idproducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIIDEmpleadorCreador
            // 
            this.lblIIDEmpleadorCreador.AutoSize = true;
            this.lblIIDEmpleadorCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIIDEmpleadorCreador.Location = new System.Drawing.Point(30, 47);
            this.lblIIDEmpleadorCreador.Name = "lblIIDEmpleadorCreador";
            this.lblIIDEmpleadorCreador.Size = new System.Drawing.Size(249, 20);
            this.lblIIDEmpleadorCreador.TabIndex = 0;
            this.lblIIDEmpleadorCreador.Text = "IDEmpleado Creador de Producto";
            this.lblIIDEmpleadorCreador.Click += new System.EventHandler(this.lblIIDEmpleadorCreador_Click);
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.Location = new System.Drawing.Point(30, 109);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(90, 20);
            this.lblIDProducto.TabIndex = 1;
            this.lblIDProducto.Text = "IDProducto";
            this.lblIDProducto.Click += new System.EventHandler(this.lblIDProducto_Click);
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(30, 77);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(202, 20);
            this.lblFechaCreacion.TabIndex = 2;
            this.lblFechaCreacion.Text = "Fecha Cracion de Producto";
            this.lblFechaCreacion.Click += new System.EventHandler(this.lblFechaCreacion_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(30, 138);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(51, 20);
            this.lblCosto.TabIndex = 3;
            this.lblCosto.Text = "Costo";
            this.lblCosto.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(30, 168);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.lblPrecioVenta.TabIndex = 4;
            this.lblPrecioVenta.Text = "Precio Venta";
            this.lblPrecioVenta.Click += new System.EventHandler(this.lblPrecioVenta_Click);
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDisponible.Location = new System.Drawing.Point(30, 198);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(128, 20);
            this.lblStockDisponible.TabIndex = 5;
            this.lblStockDisponible.Text = "Stock Disponible";
            this.lblStockDisponible.Click += new System.EventHandler(this.lblStockDisponible_Click);
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo.Location = new System.Drawing.Point(30, 228);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(143, 20);
            this.lblStockMinimo.TabIndex = 6;
            this.lblStockMinimo.Text = "Stock Minimo Ideal";
            this.lblStockMinimo.Click += new System.EventHandler(this.lblStockMinimo_Click);
            // 
            // tboxCosto
            // 
            this.tboxCosto.Location = new System.Drawing.Point(294, 138);
            this.tboxCosto.Name = "tboxCosto";
            this.tboxCosto.Size = new System.Drawing.Size(163, 20);
            this.tboxCosto.TabIndex = 7;
            this.tboxCosto.TextChanged += new System.EventHandler(this.tboxCosto_TextChanged);
            // 
            // tboxPrecioVenta
            // 
            this.tboxPrecioVenta.Location = new System.Drawing.Point(294, 168);
            this.tboxPrecioVenta.Name = "tboxPrecioVenta";
            this.tboxPrecioVenta.Size = new System.Drawing.Size(163, 20);
            this.tboxPrecioVenta.TabIndex = 8;
            this.tboxPrecioVenta.TextChanged += new System.EventHandler(this.tboxPrecioVenta_TextChanged);
            // 
            // tboxStockDisponible
            // 
            this.tboxStockDisponible.Location = new System.Drawing.Point(294, 198);
            this.tboxStockDisponible.Name = "tboxStockDisponible";
            this.tboxStockDisponible.Size = new System.Drawing.Size(64, 20);
            this.tboxStockDisponible.TabIndex = 9;
            this.tboxStockDisponible.TextChanged += new System.EventHandler(this.tboxStockDisponible_TextChanged);
            // 
            // tboxStockMinimoIdeal
            // 
            this.tboxStockMinimoIdeal.Location = new System.Drawing.Point(294, 228);
            this.tboxStockMinimoIdeal.Name = "tboxStockMinimoIdeal";
            this.tboxStockMinimoIdeal.Size = new System.Drawing.Size(64, 20);
            this.tboxStockMinimoIdeal.TabIndex = 11;
            this.tboxStockMinimoIdeal.TextChanged += new System.EventHandler(this.tboxStockMinimoIdeal_TextChanged);
            // 
            // lblIDEmpleadoCreadorProducto
            // 
            this.lblIDEmpleadoCreadorProducto.AutoSize = true;
            this.lblIDEmpleadoCreadorProducto.Location = new System.Drawing.Point(291, 52);
            this.lblIDEmpleadoCreadorProducto.Name = "lblIDEmpleadoCreadorProducto";
            this.lblIDEmpleadoCreadorProducto.Size = new System.Drawing.Size(35, 13);
            this.lblIDEmpleadoCreadorProducto.TabIndex = 12;
            this.lblIDEmpleadoCreadorProducto.Text = "label1";
            this.lblIDEmpleadoCreadorProducto.Click += new System.EventHandler(this.lblIDEmpleadoCreadorProducto_Click);
            // 
            // lblFechaCreacionProducto
            // 
            this.lblFechaCreacionProducto.AutoSize = true;
            this.lblFechaCreacionProducto.Location = new System.Drawing.Point(291, 82);
            this.lblFechaCreacionProducto.Name = "lblFechaCreacionProducto";
            this.lblFechaCreacionProducto.Size = new System.Drawing.Size(35, 13);
            this.lblFechaCreacionProducto.TabIndex = 13;
            this.lblFechaCreacionProducto.Text = "label1";
            this.lblFechaCreacionProducto.Click += new System.EventHandler(this.lblFechaCreacionProducto_Click);
            // 
            // idproducto
            // 
            this.idproducto.AutoSize = true;
            this.idproducto.Location = new System.Drawing.Point(291, 114);
            this.idproducto.Name = "idproducto";
            this.idproducto.Size = new System.Drawing.Size(35, 13);
            this.idproducto.TabIndex = 14;
            this.idproducto.Text = "label1";
            this.idproducto.Click += new System.EventHandler(this.idproducto_Click);
            // 
            // ProductoEnEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 328);
            this.Controls.Add(this.idproducto);
            this.Controls.Add(this.lblFechaCreacionProducto);
            this.Controls.Add(this.lblIDEmpleadoCreadorProducto);
            this.Controls.Add(this.tboxStockMinimoIdeal);
            this.Controls.Add(this.tboxStockDisponible);
            this.Controls.Add(this.tboxPrecioVenta);
            this.Controls.Add(this.tboxCosto);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.lblStockDisponible);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblIDProducto);
            this.Controls.Add(this.lblIIDEmpleadorCreador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductoEnEditarProducto";
            this.Text = "ProductoEnBuscarProducto";
            this.Load += new System.EventHandler(this.ProductoEnBuscarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIIDEmpleadorCreador;
        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox tboxCosto;
        private System.Windows.Forms.TextBox tboxPrecioVenta;
        private System.Windows.Forms.TextBox tboxStockDisponible;
        private System.Windows.Forms.TextBox tboxStockMinimoIdeal;
        private System.Windows.Forms.Label lblIDEmpleadoCreadorProducto;
        private System.Windows.Forms.Label lblFechaCreacionProducto;
        private System.Windows.Forms.Label idproducto;
    }
}