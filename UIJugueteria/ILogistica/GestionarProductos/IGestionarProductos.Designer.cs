namespace UIJugueteria
{
    partial class IGestionarProductos
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
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.btnAmpliar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxIDProducto = new System.Windows.Forms.TextBox();
            this.dtgvVerProductos = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIDProducto.Location = new System.Drawing.Point(43, 4);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(87, 18);
            this.lblIDProducto.TabIndex = 0;
            this.lblIDProducto.Text = "ID Producto";
            this.lblIDProducto.Click += new System.EventHandler(this.lblIDProducto_Click);
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmpliar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAmpliar.Location = new System.Drawing.Point(509, 113);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(87, 22);
            this.btnAmpliar.TabIndex = 6;
            this.btnAmpliar.Text = "Ampliar";
            this.btnAmpliar.UseVisualStyleBackColor = true;
            this.btnAmpliar.Click += new System.EventHandler(this.btnAmpliar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.Location = new System.Drawing.Point(509, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 22);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Location = new System.Drawing.Point(509, 141);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 22);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProducto.Location = new System.Drawing.Point(402, 2);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(133, 20);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.tboxIDProducto);
            this.panel1.Controls.Add(this.dtgvVerProductos);
            this.panel1.Controls.Add(this.btnAmpliar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.lblIDProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 365);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tboxIDProducto
            // 
            this.tboxIDProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tboxIDProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxIDProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.tboxIDProducto.Location = new System.Drawing.Point(161, 3);
            this.tboxIDProducto.Name = "tboxIDProducto";
            this.tboxIDProducto.Size = new System.Drawing.Size(203, 20);
            this.tboxIDProducto.TabIndex = 10;
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
            this.CostoProducto,
            this.PrecioProducto,
            this.StockProducto});
            this.dtgvVerProductos.EnableHeadersVisualStyles = false;
            this.dtgvVerProductos.GridColor = System.Drawing.Color.Black;
            this.dtgvVerProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvVerProductos.Location = new System.Drawing.Point(3, 32);
            this.dtgvVerProductos.Name = "dtgvVerProductos";
            this.dtgvVerProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVerProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvVerProductos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dtgvVerProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvVerProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVerProductos.Size = new System.Drawing.Size(500, 330);
            this.dtgvVerProductos.TabIndex = 7;
            this.dtgvVerProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerProductos_CellClick_1);
            this.dtgvVerProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerProductos_CellContentClick_1);
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
            // CostoProducto
            // 
            this.CostoProducto.HeaderText = "Costo";
            this.CostoProducto.Name = "CostoProducto";
            this.CostoProducto.ReadOnly = true;
            this.CostoProducto.Width = 110;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "PrecioVenta";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            this.PrecioProducto.Width = 110;
            // 
            // StockProducto
            // 
            this.StockProducto.HeaderText = "Stock";
            this.StockProducto.Name = "StockProducto";
            this.StockProducto.ReadOnly = true;
            this.StockProducto.Width = 80;
            // 
            // IGestionarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IGestionarProductos";
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAmpliar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvVerProductos;
        private System.Windows.Forms.TextBox tboxIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProducto;
    }
}