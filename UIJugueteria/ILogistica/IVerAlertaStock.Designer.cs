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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dtgvVerProductos.ColumnHeadersHeight = 15;
            this.dtgvVerProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvVerProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCreador,
            this.IDProducto,
            this.NombreProducto,
            this.FechaCreacionProducto,
            this.StockMinimoIdeal,
            this.StockProducto});
            this.dtgvVerProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvVerProductos.EnableHeadersVisualStyles = false;
            this.dtgvVerProductos.GridColor = System.Drawing.Color.Black;
            this.dtgvVerProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvVerProductos.Location = new System.Drawing.Point(0, 0);
            this.dtgvVerProductos.Name = "dtgvVerProductos";
            this.dtgvVerProductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVerProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvVerProductos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dtgvVerProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvVerProductos.Size = new System.Drawing.Size(599, 365);
            this.dtgvVerProductos.TabIndex = 8;
            this.dtgvVerProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerProductos_CellContentClick_1);
            this.dtgvVerProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvVerProductos_CellFormatting);
            // 
            // IDCreador
            // 
            this.IDCreador.HeaderText = "ID E. Creador";
            this.IDCreador.Name = "IDCreador";
            this.IDCreador.ReadOnly = true;
            this.IDCreador.Width = 80;
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
            // 
            // FechaCreacionProducto
            // 
            this.FechaCreacionProducto.HeaderText = "Fecha Creacion";
            this.FechaCreacionProducto.Name = "FechaCreacionProducto";
            this.FechaCreacionProducto.ReadOnly = true;
            this.FechaCreacionProducto.Width = 125;
            // 
            // StockMinimoIdeal
            // 
            this.StockMinimoIdeal.HeaderText = "Stock Minimo Ideal";
            this.StockMinimoIdeal.Name = "StockMinimoIdeal";
            this.StockMinimoIdeal.ReadOnly = true;
            this.StockMinimoIdeal.Width = 105;
            // 
            // StockProducto
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.StockProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockProducto.HeaderText = "Stock";
            this.StockProducto.Name = "StockProducto";
            this.StockProducto.ReadOnly = true;
            this.StockProducto.Width = 105;
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