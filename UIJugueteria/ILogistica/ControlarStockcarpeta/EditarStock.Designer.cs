namespace UIJugueteria.ILogistica.ControlarStock
{
    partial class EditarStock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProductoEstatico = new System.Windows.Forms.Label();
            this.btnConfirmarCambios = new System.Windows.Forms.Button();
            this.idproducto = new System.Windows.Forms.Label();
            this.lblFechaCreacionProducto = new System.Windows.Forms.Label();
            this.lblIDEmpleadoCreadorProducto = new System.Windows.Forms.Label();
            this.tboxStockMinimoIdeal = new System.Windows.Forms.TextBox();
            this.tboxStockDisponible = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.lblIIDEmpleadorCreador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tboxNombreProducto);
            this.panel1.Controls.Add(this.lblNombreProductoEstatico);
            this.panel1.Controls.Add(this.btnConfirmarCambios);
            this.panel1.Controls.Add(this.idproducto);
            this.panel1.Controls.Add(this.lblFechaCreacionProducto);
            this.panel1.Controls.Add(this.lblIDEmpleadoCreadorProducto);
            this.panel1.Controls.Add(this.tboxStockMinimoIdeal);
            this.panel1.Controls.Add(this.tboxStockDisponible);
            this.panel1.Controls.Add(this.lblStockMinimo);
            this.panel1.Controls.Add(this.lblStockDisponible);
            this.panel1.Controls.Add(this.lblPrecioVenta);
            this.panel1.Controls.Add(this.lblCosto);
            this.panel1.Controls.Add(this.lblFechaCreacion);
            this.panel1.Controls.Add(this.lblIDProducto);
            this.panel1.Controls.Add(this.lblIIDEmpleadorCreador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 340);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tboxNombreProducto
            // 
            this.tboxNombreProducto.Location = new System.Drawing.Point(311, 123);
            this.tboxNombreProducto.Name = "tboxNombreProducto";
            this.tboxNombreProducto.Size = new System.Drawing.Size(163, 20);
            this.tboxNombreProducto.TabIndex = 35;
            this.tboxNombreProducto.TextChanged += new System.EventHandler(this.tboxNombreProducto_TextChanged);
            // 
            // lblNombreProductoEstatico
            // 
            this.lblNombreProductoEstatico.AutoSize = true;
            this.lblNombreProductoEstatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProductoEstatico.Location = new System.Drawing.Point(47, 123);
            this.lblNombreProductoEstatico.Name = "lblNombreProductoEstatico";
            this.lblNombreProductoEstatico.Size = new System.Drawing.Size(133, 20);
            this.lblNombreProductoEstatico.TabIndex = 34;
            this.lblNombreProductoEstatico.Text = "Nombre Producto";
            this.lblNombreProductoEstatico.Click += new System.EventHandler(this.lblNombreProductoEstatico_Click);
            // 
            // btnConfirmarCambios
            // 
            this.btnConfirmarCambios.Location = new System.Drawing.Point(330, 284);
            this.btnConfirmarCambios.Name = "btnConfirmarCambios";
            this.btnConfirmarCambios.Size = new System.Drawing.Size(123, 25);
            this.btnConfirmarCambios.TabIndex = 33;
            this.btnConfirmarCambios.Text = "Confirmar Cambios";
            this.btnConfirmarCambios.UseVisualStyleBackColor = true;
            this.btnConfirmarCambios.Click += new System.EventHandler(this.btnConfirmarCambios_Click);
            // 
            // idproducto
            // 
            this.idproducto.AutoSize = true;
            this.idproducto.Location = new System.Drawing.Point(308, 94);
            this.idproducto.Name = "idproducto";
            this.idproducto.Size = new System.Drawing.Size(49, 13);
            this.idproducto.TabIndex = 32;
            this.idproducto.Text = "dinamico";
            this.idproducto.Click += new System.EventHandler(this.idproducto_Click);
            // 
            // lblFechaCreacionProducto
            // 
            this.lblFechaCreacionProducto.AutoSize = true;
            this.lblFechaCreacionProducto.Location = new System.Drawing.Point(308, 62);
            this.lblFechaCreacionProducto.Name = "lblFechaCreacionProducto";
            this.lblFechaCreacionProducto.Size = new System.Drawing.Size(49, 13);
            this.lblFechaCreacionProducto.TabIndex = 31;
            this.lblFechaCreacionProducto.Text = "dinamico";
            this.lblFechaCreacionProducto.Click += new System.EventHandler(this.lblFechaCreacionProducto_Click);
            // 
            // lblIDEmpleadoCreadorProducto
            // 
            this.lblIDEmpleadoCreadorProducto.AutoSize = true;
            this.lblIDEmpleadoCreadorProducto.Location = new System.Drawing.Point(308, 32);
            this.lblIDEmpleadoCreadorProducto.Name = "lblIDEmpleadoCreadorProducto";
            this.lblIDEmpleadoCreadorProducto.Size = new System.Drawing.Size(49, 13);
            this.lblIDEmpleadoCreadorProducto.TabIndex = 30;
            this.lblIDEmpleadoCreadorProducto.Text = "dinamico";
            this.lblIDEmpleadoCreadorProducto.Click += new System.EventHandler(this.lblIDEmpleadoCreadorProducto_Click);
            // 
            // tboxStockMinimoIdeal
            // 
            this.tboxStockMinimoIdeal.Location = new System.Drawing.Point(311, 246);
            this.tboxStockMinimoIdeal.Name = "tboxStockMinimoIdeal";
            this.tboxStockMinimoIdeal.Size = new System.Drawing.Size(64, 20);
            this.tboxStockMinimoIdeal.TabIndex = 29;
            this.tboxStockMinimoIdeal.TextChanged += new System.EventHandler(this.tboxStockMinimoIdeal_TextChanged);
            // 
            // tboxStockDisponible
            // 
            this.tboxStockDisponible.Location = new System.Drawing.Point(311, 216);
            this.tboxStockDisponible.Name = "tboxStockDisponible";
            this.tboxStockDisponible.Size = new System.Drawing.Size(64, 20);
            this.tboxStockDisponible.TabIndex = 28;
            this.tboxStockDisponible.TextChanged += new System.EventHandler(this.tboxStockDisponible_TextChanged);
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo.Location = new System.Drawing.Point(47, 246);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(143, 20);
            this.lblStockMinimo.TabIndex = 25;
            this.lblStockMinimo.Text = "Stock Minimo Ideal";
            this.lblStockMinimo.Click += new System.EventHandler(this.lblStockMinimo_Click);
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDisponible.Location = new System.Drawing.Point(47, 216);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(128, 20);
            this.lblStockDisponible.TabIndex = 24;
            this.lblStockDisponible.Text = "Stock Disponible";
            this.lblStockDisponible.Click += new System.EventHandler(this.lblStockDisponible_Click);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(47, 186);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.lblPrecioVenta.TabIndex = 23;
            this.lblPrecioVenta.Text = "Precio Venta";
            this.lblPrecioVenta.Click += new System.EventHandler(this.lblPrecioVenta_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(47, 156);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(51, 20);
            this.lblCosto.TabIndex = 22;
            this.lblCosto.Text = "Costo";
            this.lblCosto.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(47, 57);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(211, 20);
            this.lblFechaCreacion.TabIndex = 21;
            this.lblFechaCreacion.Text = "Fecha Creacion de Producto";
            this.lblFechaCreacion.Click += new System.EventHandler(this.lblFechaCreacion_Click);
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.Location = new System.Drawing.Point(47, 89);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(90, 20);
            this.lblIDProducto.TabIndex = 20;
            this.lblIDProducto.Text = "IDProducto";
            this.lblIDProducto.Click += new System.EventHandler(this.lblIDProducto_Click);
            // 
            // lblIIDEmpleadorCreador
            // 
            this.lblIIDEmpleadorCreador.AutoSize = true;
            this.lblIIDEmpleadorCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIIDEmpleadorCreador.Location = new System.Drawing.Point(47, 27);
            this.lblIIDEmpleadorCreador.Name = "lblIIDEmpleadorCreador";
            this.lblIIDEmpleadorCreador.Size = new System.Drawing.Size(249, 20);
            this.lblIIDEmpleadorCreador.TabIndex = 19;
            this.lblIIDEmpleadorCreador.Text = "IDEmpleado Creador de Producto";
            this.lblIIDEmpleadorCreador.Click += new System.EventHandler(this.lblIIDEmpleadorCreador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "dinamico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "dinamico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EditarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 340);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarStock";
            this.Text = "EditarStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxNombreProducto;
        private System.Windows.Forms.Label lblNombreProductoEstatico;
        private System.Windows.Forms.Button btnConfirmarCambios;
        private System.Windows.Forms.Label idproducto;
        private System.Windows.Forms.Label lblFechaCreacionProducto;
        private System.Windows.Forms.Label lblIDEmpleadoCreadorProducto;
        private System.Windows.Forms.TextBox tboxStockMinimoIdeal;
        private System.Windows.Forms.TextBox tboxStockDisponible;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.Label lblIIDEmpleadorCreador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}