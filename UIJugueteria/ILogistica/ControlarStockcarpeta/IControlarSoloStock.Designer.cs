namespace UIJugueteria.ILogistica
{
    partial class IControlarSoloStock
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
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.PanelParaProducto = new System.Windows.Forms.Panel();
            this.btnEditarStock = new System.Windows.Forms.Button();
            this.dtgvVerProductos = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimoIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tboxIDProducto = new System.Windows.Forms.TextBox();
            this.PanelParaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(402, -1);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(133, 23);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.Location = new System.Drawing.Point(43, 4);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(87, 18);
            this.lblIDProducto.TabIndex = 4;
            this.lblIDProducto.Text = "ID Producto";
            this.lblIDProducto.Click += new System.EventHandler(this.lblIDProducto_Click);
            // 
            // PanelParaProducto
            // 
            this.PanelParaProducto.Controls.Add(this.btnEditarStock);
            this.PanelParaProducto.Controls.Add(this.dtgvVerProductos);
            this.PanelParaProducto.Location = new System.Drawing.Point(0, 25);
            this.PanelParaProducto.Name = "PanelParaProducto";
            this.PanelParaProducto.Size = new System.Drawing.Size(599, 340);
            this.PanelParaProducto.TabIndex = 6;
            this.PanelParaProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelParaProducto_Paint);
            // 
            // btnEditarStock
            // 
            this.btnEditarStock.Location = new System.Drawing.Point(509, 141);
            this.btnEditarStock.Name = "btnEditarStock";
            this.btnEditarStock.Size = new System.Drawing.Size(87, 38);
            this.btnEditarStock.TabIndex = 4;
            this.btnEditarStock.Text = "Editar Stock";
            this.btnEditarStock.UseVisualStyleBackColor = true;
            this.btnEditarStock.Click += new System.EventHandler(this.btnEditarStock_Click);
            // 
            // dtgvVerProductos
            // 
            this.dtgvVerProductos.AllowUserToAddRows = false;
            this.dtgvVerProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvVerProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvVerProductos.ColumnHeadersHeight = 20;
            this.dtgvVerProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvVerProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.FechaCreacionProducto,
            this.StockProducto,
            this.StockMinimoIdeal});
            this.dtgvVerProductos.Location = new System.Drawing.Point(3, 6);
            this.dtgvVerProductos.Name = "dtgvVerProductos";
            this.dtgvVerProductos.ReadOnly = true;
            this.dtgvVerProductos.RowHeadersVisible = false;
            this.dtgvVerProductos.Size = new System.Drawing.Size(500, 330);
            this.dtgvVerProductos.TabIndex = 0;
            this.dtgvVerProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerProductos_CellContentClick);
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "ID";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Width = 80;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 120;
            // 
            // FechaCreacionProducto
            // 
            this.FechaCreacionProducto.HeaderText = "Fecha Creacion";
            this.FechaCreacionProducto.Name = "FechaCreacionProducto";
            this.FechaCreacionProducto.ReadOnly = true;
            this.FechaCreacionProducto.Width = 110;
            // 
            // StockProducto
            // 
            this.StockProducto.HeaderText = "Stock";
            this.StockProducto.Name = "StockProducto";
            this.StockProducto.ReadOnly = true;
            this.StockProducto.Width = 80;
            // 
            // StockMinimoIdeal
            // 
            this.StockMinimoIdeal.HeaderText = "Stock Minimo Ideal";
            this.StockMinimoIdeal.Name = "StockMinimoIdeal";
            this.StockMinimoIdeal.ReadOnly = true;
            this.StockMinimoIdeal.Width = 110;
            // 
            // tboxIDProducto
            // 
            this.tboxIDProducto.Location = new System.Drawing.Point(149, 2);
            this.tboxIDProducto.Name = "tboxIDProducto";
            this.tboxIDProducto.Size = new System.Drawing.Size(203, 20);
            this.tboxIDProducto.TabIndex = 5;
            this.tboxIDProducto.TextChanged += new System.EventHandler(this.tboxIDProducto_TextChanged);
            // 
            // ControlarSoloStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.lblIDProducto);
            this.Controls.Add(this.PanelParaProducto);
            this.Controls.Add(this.tboxIDProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlarSoloStock";
            this.Text = "ControlarSoloStock";
            this.Load += new System.EventHandler(this.ControlarSoloStock_Load);
            this.PanelParaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.Panel PanelParaProducto;
        private System.Windows.Forms.Button btnEditarStock;
        private System.Windows.Forms.DataGridView dtgvVerProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimoIdeal;
        private System.Windows.Forms.TextBox tboxIDProducto;
    }
}