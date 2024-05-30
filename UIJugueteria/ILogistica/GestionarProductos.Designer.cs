namespace UIJugueteria
{
    partial class GestionarProductos
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
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.tboxIDProducto = new System.Windows.Forms.TextBox();
            this.PanelParaProducto = new System.Windows.Forms.Panel();
            this.btnAmpliar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtgvVerProductos = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.PanelParaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.Location = new System.Drawing.Point(43, 5);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(87, 18);
            this.lblIDProducto.TabIndex = 0;
            this.lblIDProducto.Text = "ID Producto";
            this.lblIDProducto.Click += new System.EventHandler(this.lblIDProducto_Click);
            // 
            // tboxIDProducto
            // 
            this.tboxIDProducto.Location = new System.Drawing.Point(149, 3);
            this.tboxIDProducto.Name = "tboxIDProducto";
            this.tboxIDProducto.Size = new System.Drawing.Size(203, 20);
            this.tboxIDProducto.TabIndex = 1;
            this.tboxIDProducto.TextChanged += new System.EventHandler(this.tboxIDProducto_TextChanged);
            // 
            // PanelParaProducto
            // 
            this.PanelParaProducto.Controls.Add(this.btnAmpliar);
            this.PanelParaProducto.Controls.Add(this.btnEliminar);
            this.PanelParaProducto.Controls.Add(this.btnEditar);
            this.PanelParaProducto.Controls.Add(this.dtgvVerProductos);
            this.PanelParaProducto.Location = new System.Drawing.Point(0, 26);
            this.PanelParaProducto.Name = "PanelParaProducto";
            this.PanelParaProducto.Size = new System.Drawing.Size(599, 340);
            this.PanelParaProducto.TabIndex = 2;
            this.PanelParaProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelParaProducto_Paint);
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.Location = new System.Drawing.Point(501, 117);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(95, 25);
            this.btnAmpliar.TabIndex = 6;
            this.btnAmpliar.Text = "Ampliar";
            this.btnAmpliar.UseVisualStyleBackColor = true;
            this.btnAmpliar.Click += new System.EventHandler(this.btnAmpliar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(501, 179);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 25);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(501, 148);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 25);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtgvVerProductos
            // 
            this.dtgvVerProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvVerProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvVerProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVerProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.CostoProducto,
            this.PrecioProducto,
            this.StockProducto});
            this.dtgvVerProductos.Location = new System.Drawing.Point(3, 6);
            this.dtgvVerProductos.Name = "dtgvVerProductos";
            this.dtgvVerProductos.ReadOnly = true;
            this.dtgvVerProductos.RowHeadersVisible = false;
            this.dtgvVerProductos.Size = new System.Drawing.Size(492, 337);
            this.dtgvVerProductos.TabIndex = 0;
            this.dtgvVerProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerProductos_CellClick);
            this.dtgvVerProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerProductos_CellContentClick);
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
            this.NombreProducto.Width = 120;
            // 
            // CostoProducto
            // 
            this.CostoProducto.HeaderText = "Costo";
            this.CostoProducto.Name = "CostoProducto";
            this.CostoProducto.ReadOnly = true;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "PrecioVenta";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            // 
            // StockProducto
            // 
            this.StockProducto.HeaderText = "Stock";
            this.StockProducto.Name = "StockProducto";
            this.StockProducto.ReadOnly = true;
            this.StockProducto.Width = 60;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(402, 0);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(133, 23);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.PanelParaProducto);
            this.Controls.Add(this.tboxIDProducto);
            this.Controls.Add(this.lblIDProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProducto";
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.PanelParaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.TextBox tboxIDProducto;
        private System.Windows.Forms.Panel PanelParaProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView dtgvVerProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAmpliar;
    }
}