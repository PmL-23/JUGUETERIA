namespace UIJugueteria
{
    partial class IVENDEDOR
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
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btn_listar);
            this.panel1.Controls.Add(this.btn_venta);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.grillaClientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 362);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grillaClientes
            // 
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Location = new System.Drawing.Point(187, 109);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.Size = new System.Drawing.Size(586, 241);
            this.grillaClientes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "CUENTA VENDEDOR";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(623, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cerrar Sesion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(623, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listar Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(623, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(21, 284);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(142, 43);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_venta
            // 
            this.btn_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_venta.ForeColor = System.Drawing.Color.White;
            this.btn_venta.Location = new System.Drawing.Point(21, 181);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(142, 43);
            this.btn_venta.TabIndex = 6;
            this.btn_venta.Text = "Nueva venta";
            this.btn_venta.UseVisualStyleBackColor = true;
            this.btn_venta.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_listar.ForeColor = System.Drawing.Color.White;
            this.btn_listar.Location = new System.Drawing.Point(445, 50);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(142, 43);
            this.btn_listar.TabIndex = 7;
            this.btn_listar.Text = "Listar clientes";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // IVENDEDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IVENDEDOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IVENDEDOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_listar;
    }
}