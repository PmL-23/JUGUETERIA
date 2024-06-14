namespace UIJugueteria
{
    partial class NOSE
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOSE));
            this.PanelMovCerrar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            this.lblJugueteria = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelMovCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMovCerrar
            // 
            this.PanelMovCerrar.BackColor = System.Drawing.SystemColors.WindowText;
            this.PanelMovCerrar.Controls.Add(this.btnMinimizar);
            this.PanelMovCerrar.Controls.Add(this.btnCerrarAplicacion);
            this.PanelMovCerrar.Controls.Add(this.lblJugueteria);
            this.PanelMovCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMovCerrar.Location = new System.Drawing.Point(0, 0);
            this.PanelMovCerrar.Name = "PanelMovCerrar";
            this.PanelMovCerrar.Size = new System.Drawing.Size(799, 17);
            this.PanelMovCerrar.TabIndex = 20;
            this.PanelMovCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMovCerrar_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(760, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.TabIndex = 23;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.BackColor = System.Drawing.Color.Black;
            this.btnCerrarAplicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarAplicacion.BackgroundImage")));
            this.btnCerrarAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnCerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAplicacion.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(781, 1);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(17, 17);
            this.btnCerrarAplicacion.TabIndex = 4;
            this.btnCerrarAplicacion.UseVisualStyleBackColor = false;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            // 
            // lblJugueteria
            // 
            this.lblJugueteria.AutoSize = true;
            this.lblJugueteria.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblJugueteria.ForeColor = System.Drawing.Color.White;
            this.lblJugueteria.Location = new System.Drawing.Point(3, 1);
            this.lblJugueteria.Name = "lblJugueteria";
            this.lblJugueteria.Size = new System.Drawing.Size(56, 13);
            this.lblJugueteria.TabIndex = 23;
            this.lblJugueteria.Text = "Jugueteria";
            // 
            // PanelMain
            // 
            this.PanelMain.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PanelMain.Location = new System.Drawing.Point(0, 17);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(799, 365);
            this.PanelMain.TabIndex = 19;
            this.PanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMain_Paint);
            // 
            // NOSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 382);
            this.Controls.Add(this.PanelMovCerrar);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NOSE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugueteria";
            this.Load += new System.EventHandler(this.btnCancela_Load);
            this.PanelMovCerrar.ResumeLayout(false);
            this.PanelMovCerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMovCerrar;
        private System.Windows.Forms.Label lblJugueteria;
        private System.Windows.Forms.Button btnCerrarAplicacion;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel PanelMain;
    }
}

