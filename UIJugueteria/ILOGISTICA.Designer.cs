namespace UIJugueteria
{
    partial class ILOGISTICA
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
            this.btnCargarNuevoProducto = new System.Windows.Forms.Button();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnLogistica = new System.Windows.Forms.Button();
            this.btnCargarStock = new System.Windows.Forms.Button();
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.btnVerAlertaDeStock = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarNuevoProducto
            // 
            this.btnCargarNuevoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargarNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarNuevoProducto.Location = new System.Drawing.Point(0, 68);
            this.btnCargarNuevoProducto.Name = "btnCargarNuevoProducto";
            this.btnCargarNuevoProducto.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCargarNuevoProducto.Size = new System.Drawing.Size(200, 41);
            this.btnCargarNuevoProducto.TabIndex = 1;
            this.btnCargarNuevoProducto.Text = "Cargar Nuevo Producto";
            this.btnCargarNuevoProducto.UseVisualStyleBackColor = true;
            this.btnCargarNuevoProducto.Click += new System.EventHandler(this.btnCargarNuevoProducto_Click);
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLateral.Controls.Add(this.btnLogistica);
            this.PanelLateral.Controls.Add(this.btnCargarStock);
            this.PanelLateral.Controls.Add(this.btnCerrarsesion);
            this.PanelLateral.Controls.Add(this.btnVerAlertaDeStock);
            this.PanelLateral.Controls.Add(this.btnEditarProducto);
            this.PanelLateral.Controls.Add(this.btnCargarNuevoProducto);
            this.PanelLateral.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(200, 365);
            this.PanelLateral.TabIndex = 2;
            this.PanelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLateral_Paint);
            // 
            // btnLogistica
            // 
            this.btnLogistica.FlatAppearance.BorderSize = 0;
            this.btnLogistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogistica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogistica.Location = new System.Drawing.Point(22, 3);
            this.btnLogistica.Name = "btnLogistica";
            this.btnLogistica.Size = new System.Drawing.Size(154, 50);
            this.btnLogistica.TabIndex = 5;
            this.btnLogistica.Text = "LOGISTICA";
            this.btnLogistica.UseVisualStyleBackColor = true;
            this.btnLogistica.Click += new System.EventHandler(this.btnLogistica_Click);
            // 
            // btnCargarStock
            // 
            this.btnCargarStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargarStock.Cursor = System.Windows.Forms.Cursors.No;
            this.btnCargarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarStock.Location = new System.Drawing.Point(0, 186);
            this.btnCargarStock.Name = "btnCargarStock";
            this.btnCargarStock.Size = new System.Drawing.Size(200, 41);
            this.btnCargarStock.TabIndex = 5;
            this.btnCargarStock.Text = "Cargar Stock";
            this.btnCargarStock.UseVisualStyleBackColor = true;
            this.btnCargarStock.Click += new System.EventHandler(this.btnCargarStock_Click);
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarsesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarsesion.Location = new System.Drawing.Point(40, 330);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(117, 23);
            this.btnCerrarsesion.TabIndex = 4;
            this.btnCerrarsesion.Text = "Cerrar Sesion";
            this.btnCerrarsesion.UseVisualStyleBackColor = true;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            // 
            // btnVerAlertaDeStock
            // 
            this.btnVerAlertaDeStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerAlertaDeStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerAlertaDeStock.Cursor = System.Windows.Forms.Cursors.No;
            this.btnVerAlertaDeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAlertaDeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlertaDeStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerAlertaDeStock.Location = new System.Drawing.Point(0, 246);
            this.btnVerAlertaDeStock.Name = "btnVerAlertaDeStock";
            this.btnVerAlertaDeStock.Size = new System.Drawing.Size(200, 41);
            this.btnVerAlertaDeStock.TabIndex = 3;
            this.btnVerAlertaDeStock.Text = "Ver Alertas de Stock";
            this.btnVerAlertaDeStock.UseVisualStyleBackColor = true;
            this.btnVerAlertaDeStock.Click += new System.EventHandler(this.btnVerAlertaDeStock_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarProducto.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarProducto.Location = new System.Drawing.Point(0, 127);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(200, 41);
            this.btnEditarProducto.TabIndex = 2;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(200, 0);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(599, 365);
            this.PanelCentral.TabIndex = 3;
            this.PanelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentral_Paint);
            // 
            // ILOGISTICA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 365);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ILOGISTICA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ILOGISTICA";
            this.Load += new System.EventHandler(this.ILOGISTICA_Load);
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarNuevoProducto;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnVerAlertaDeStock;
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.Button btnCargarStock;
        private System.Windows.Forms.Button btnLogistica;
    }
}