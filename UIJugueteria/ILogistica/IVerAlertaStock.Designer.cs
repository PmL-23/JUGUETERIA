namespace UIJugueteria.ILogistica
{
    partial class IVerAlertaStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelParaProducto = new System.Windows.Forms.Panel();
            this.dtgvVerProductos = new System.Windows.Forms.DataGridView();
            this.IDCreador = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.PanelParaProducto.Controls.Add(this.dtgvVerProductos);
            this.PanelParaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelParaProducto.Location = new System.Drawing.Point(0, 0);
            this.PanelParaProducto.Name = "PanelParaProducto";
            this.PanelParaProducto.Size = new System.Drawing.Size(599, 365);
            this.PanelParaProducto.TabIndex = 3;
            // 
            // dtgvVerProductos
            // 
            this.dtgvVerProductos.AllowUserToAddRows = false;
            this.dtgvVerProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvVerProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvVerProductos.ColumnHeadersHeight = 19;
            this.dtgvVerProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvVerProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCreador,
            this.IDProducto,
            this.NombreProducto,
            this.FechaCreacionProducto,
            this.StockMinimoIdeal,
            this.StockProducto});
            this.dtgvVerProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvVerProductos.Location = new System.Drawing.Point(0, 0);
            this.dtgvVerProductos.Name = "dtgvVerProductos";
            this.dtgvVerProductos.ReadOnly = true;
            this.dtgvVerProductos.RowHeadersVisible = false;
            this.dtgvVerProductos.Size = new System.Drawing.Size(599, 365);
            this.dtgvVerProductos.TabIndex = 1;
            this.dtgvVerProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerProductos_CellContentClick);
            // 
            // IDCreador
            // 
            this.IDCreador.HeaderText = "ID E Creador";
            this.IDCreador.Name = "IDCreador";
            this.IDCreador.ReadOnly = true;
            this.IDCreador.Width = 98;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockMinimoIdeal.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockMinimoIdeal.HeaderText = "Stock Minimo Ideal";
            this.StockMinimoIdeal.Name = "StockMinimoIdeal";
            this.StockMinimoIdeal.ReadOnly = true;
            this.StockMinimoIdeal.Width = 110;
            // 
            // StockProducto
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockProducto.DefaultCellStyle = dataGridViewCellStyle6;
            this.StockProducto.HeaderText = "Stock";
            this.StockProducto.Name = "StockProducto";
            this.StockProducto.ReadOnly = true;
            this.StockProducto.Width = 80;
            // 
            // IVerAlertaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.PanelParaProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IVerAlertaStock";
            this.Text = "IVerAlertaStock";
            this.Load += new System.EventHandler(this.IVerAlertaStock_Load);
            this.PanelParaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelParaProducto;
        private System.Windows.Forms.DataGridView dtgvVerProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCreador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimoIdeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProducto;
    }
}