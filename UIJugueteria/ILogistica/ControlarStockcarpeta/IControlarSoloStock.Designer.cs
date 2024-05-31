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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelParaProducto = new System.Windows.Forms.Panel();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.tboxIDProducto = new System.Windows.Forms.TextBox();
            this.btnEditarStock = new System.Windows.Forms.Button();
            this.dtgvVerProductos = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimoIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelParaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelParaProducto
            // 
            this.PanelParaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelParaProducto.Controls.Add(this.btnBuscarProducto);
            this.PanelParaProducto.Controls.Add(this.lblIDProducto);
            this.PanelParaProducto.Controls.Add(this.tboxIDProducto);
            this.PanelParaProducto.Controls.Add(this.btnEditarStock);
            this.PanelParaProducto.Controls.Add(this.dtgvVerProductos);
            this.PanelParaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelParaProducto.Location = new System.Drawing.Point(0, 0);
            this.PanelParaProducto.Name = "PanelParaProducto";
            this.PanelParaProducto.Size = new System.Drawing.Size(599, 365);
            this.PanelParaProducto.TabIndex = 6;
            this.PanelParaProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelParaProducto_Paint);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProducto.Location = new System.Drawing.Point(402, 2);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(133, 20);
            this.btnBuscarProducto.TabIndex = 10;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click_1);
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIDProducto.Location = new System.Drawing.Point(43, 4);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(87, 18);
            this.lblIDProducto.TabIndex = 8;
            this.lblIDProducto.Text = "ID Producto";
            // 
            // tboxIDProducto
            // 
            this.tboxIDProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tboxIDProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxIDProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.tboxIDProducto.Location = new System.Drawing.Point(161, 3);
            this.tboxIDProducto.Name = "tboxIDProducto";
            this.tboxIDProducto.Size = new System.Drawing.Size(203, 20);
            this.tboxIDProducto.TabIndex = 9;
            this.tboxIDProducto.TextChanged += new System.EventHandler(this.tboxIDProducto_TextChanged_1);
            // 
            // btnEditarStock
            // 
            this.btnEditarStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnEditarStock.FlatAppearance.BorderSize = 0;
            this.btnEditarStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarStock.Location = new System.Drawing.Point(509, 141);
            this.btnEditarStock.Name = "btnEditarStock";
            this.btnEditarStock.Size = new System.Drawing.Size(87, 38);
            this.btnEditarStock.TabIndex = 4;
            this.btnEditarStock.Text = "Editar Stock";
            this.btnEditarStock.UseVisualStyleBackColor = false;
            this.btnEditarStock.Click += new System.EventHandler(this.btnEditarStock_Click);
            // 
            // dtgvVerProductos
            // 
            this.dtgvVerProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dtgvVerProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvVerProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dtgvVerProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvVerProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvVerProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVerProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvVerProductos.ColumnHeadersHeight = 19;
            this.dtgvVerProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvVerProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.FechaCreacionProducto,
            this.StockMinimoIdeal,
            this.StockProducto});
            this.dtgvVerProductos.EnableHeadersVisualStyles = false;
            this.dtgvVerProductos.GridColor = System.Drawing.Color.Black;
            this.dtgvVerProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvVerProductos.Location = new System.Drawing.Point(3, 32);
            this.dtgvVerProductos.Name = "dtgvVerProductos";
            this.dtgvVerProductos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVerProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvVerProductos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dtgvVerProductos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvVerProductos.Size = new System.Drawing.Size(500, 330);
            this.dtgvVerProductos.TabIndex = 0;
            this.dtgvVerProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerProductos_CellClick_1);
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
            // StockMinimoIdeal
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockMinimoIdeal.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockMinimoIdeal.HeaderText = "Stock Minimo Ideal";
            this.StockMinimoIdeal.Name = "StockMinimoIdeal";
            this.StockMinimoIdeal.ReadOnly = true;
            this.StockMinimoIdeal.Width = 110;
            // 
            // StockProducto
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockProducto.DefaultCellStyle = dataGridViewCellStyle4;
            this.StockProducto.HeaderText = "Stock";
            this.StockProducto.Name = "StockProducto";
            this.StockProducto.ReadOnly = true;
            this.StockProducto.Width = 80;
            // 
            // IControlarSoloStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.PanelParaProducto);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IControlarSoloStock";
            this.Text = "ControlarSoloStock";
            this.Load += new System.EventHandler(this.ControlarSoloStock_Load);
            this.PanelParaProducto.ResumeLayout(false);
            this.PanelParaProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelParaProducto;
        private System.Windows.Forms.Button btnEditarStock;
        private System.Windows.Forms.DataGridView dtgvVerProductos;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.TextBox tboxIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimoIdeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProducto;
    }
}