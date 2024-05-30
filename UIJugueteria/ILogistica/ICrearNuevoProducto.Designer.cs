namespace UIJugueteria
{
    partial class ICrearNuevoProducto
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
            this.lblNombreDeProducto = new System.Windows.Forms.Label();
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblPrecioDeVenta = new System.Windows.Forms.Label();
            this.lblStockMnimo = new System.Windows.Forms.Label();
            this.tboxNombreProducto = new System.Windows.Forms.TextBox();
            this.tboxIDProducto = new System.Windows.Forms.TextBox();
            this.tboxCostoProducto = new System.Windows.Forms.TextBox();
            this.tboxPrecioVentaProducto = new System.Windows.Forms.TextBox();
            this.tboxStockMinimoProducto = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tboxStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreDeProducto
            // 
            this.lblNombreDeProducto.AutoSize = true;
            this.lblNombreDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeProducto.Location = new System.Drawing.Point(106, 68);
            this.lblNombreDeProducto.Name = "lblNombreDeProducto";
            this.lblNombreDeProducto.Size = new System.Drawing.Size(154, 20);
            this.lblNombreDeProducto.TabIndex = 1;
            this.lblNombreDeProducto.Text = "Nombre de producto";
            this.lblNombreDeProducto.Click += new System.EventHandler(this.lblNombreDeProducto_Click);
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.Location = new System.Drawing.Point(106, 107);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(115, 20);
            this.lblIDProducto.TabIndex = 2;
            this.lblIDProducto.Text = "ID de producto";
            this.lblIDProducto.Click += new System.EventHandler(this.lblIDProducto_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(106, 144);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(51, 20);
            this.lblCosto.TabIndex = 3;
            this.lblCosto.Text = "Costo";
            this.lblCosto.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // lblPrecioDeVenta
            // 
            this.lblPrecioDeVenta.AutoSize = true;
            this.lblPrecioDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDeVenta.Location = new System.Drawing.Point(106, 181);
            this.lblPrecioDeVenta.Name = "lblPrecioDeVenta";
            this.lblPrecioDeVenta.Size = new System.Drawing.Size(122, 20);
            this.lblPrecioDeVenta.TabIndex = 4;
            this.lblPrecioDeVenta.Text = "Precio de Venta";
            this.lblPrecioDeVenta.Click += new System.EventHandler(this.lblPrecioDeVenta_Click);
            // 
            // lblStockMnimo
            // 
            this.lblStockMnimo.AutoSize = true;
            this.lblStockMnimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMnimo.Location = new System.Drawing.Point(106, 246);
            this.lblStockMnimo.Name = "lblStockMnimo";
            this.lblStockMnimo.Size = new System.Drawing.Size(143, 20);
            this.lblStockMnimo.TabIndex = 6;
            this.lblStockMnimo.Text = "Stock Minimo Ideal";
            this.lblStockMnimo.Click += new System.EventHandler(this.lblStockMnimo_Click);
            // 
            // tboxNombreProducto
            // 
            this.tboxNombreProducto.Location = new System.Drawing.Point(266, 68);
            this.tboxNombreProducto.Name = "tboxNombreProducto";
            this.tboxNombreProducto.Size = new System.Drawing.Size(251, 20);
            this.tboxNombreProducto.TabIndex = 7;
            this.tboxNombreProducto.TextChanged += new System.EventHandler(this.tboxNombreProdcuto_TextChanged);
            // 
            // tboxIDProducto
            // 
            this.tboxIDProducto.Location = new System.Drawing.Point(266, 107);
            this.tboxIDProducto.Name = "tboxIDProducto";
            this.tboxIDProducto.Size = new System.Drawing.Size(251, 20);
            this.tboxIDProducto.TabIndex = 8;
            this.tboxIDProducto.TextChanged += new System.EventHandler(this.tboxIDProducto_TextChanged);
            // 
            // tboxCostoProducto
            // 
            this.tboxCostoProducto.Location = new System.Drawing.Point(266, 144);
            this.tboxCostoProducto.Name = "tboxCostoProducto";
            this.tboxCostoProducto.Size = new System.Drawing.Size(110, 20);
            this.tboxCostoProducto.TabIndex = 9;
            this.tboxCostoProducto.TextChanged += new System.EventHandler(this.tboxCostoProducto_TextChanged);
            // 
            // tboxPrecioVentaProducto
            // 
            this.tboxPrecioVentaProducto.Location = new System.Drawing.Point(266, 181);
            this.tboxPrecioVentaProducto.Name = "tboxPrecioVentaProducto";
            this.tboxPrecioVentaProducto.Size = new System.Drawing.Size(110, 20);
            this.tboxPrecioVentaProducto.TabIndex = 10;
            this.tboxPrecioVentaProducto.TextChanged += new System.EventHandler(this.tboxPrecioVentaProducto_TextChanged);
            // 
            // tboxStockMinimoProducto
            // 
            this.tboxStockMinimoProducto.Location = new System.Drawing.Point(266, 246);
            this.tboxStockMinimoProducto.Name = "tboxStockMinimoProducto";
            this.tboxStockMinimoProducto.Size = new System.Drawing.Size(81, 20);
            this.tboxStockMinimoProducto.TabIndex = 11;
            this.tboxStockMinimoProducto.TextChanged += new System.EventHandler(this.tboxStockMinimoProducto_TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(303, 282);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(136, 40);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tboxStock
            // 
            this.tboxStock.Location = new System.Drawing.Point(266, 215);
            this.tboxStock.Name = "tboxStock";
            this.tboxStock.Size = new System.Drawing.Size(81, 20);
            this.tboxStock.TabIndex = 14;
            this.tboxStock.TextChanged += new System.EventHandler(this.tboxStock_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stock";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ICrearNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.tboxStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tboxStockMinimoProducto);
            this.Controls.Add(this.tboxPrecioVentaProducto);
            this.Controls.Add(this.tboxCostoProducto);
            this.Controls.Add(this.tboxIDProducto);
            this.Controls.Add(this.tboxNombreProducto);
            this.Controls.Add(this.lblStockMnimo);
            this.Controls.Add(this.lblPrecioDeVenta);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblIDProducto);
            this.Controls.Add(this.lblNombreDeProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ICrearNuevoProducto";
            this.Text = "CrearNuevoProducto";
            this.Load += new System.EventHandler(this.CrearNuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreDeProducto;
        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblPrecioDeVenta;
        private System.Windows.Forms.Label lblStockMnimo;
        private System.Windows.Forms.TextBox tboxNombreProducto;
        private System.Windows.Forms.TextBox tboxIDProducto;
        private System.Windows.Forms.TextBox tboxCostoProducto;
        private System.Windows.Forms.TextBox tboxPrecioVentaProducto;
        private System.Windows.Forms.TextBox tboxStockMinimoProducto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox tboxStock;
        private System.Windows.Forms.Label label1;
    }
}