namespace UIJugueteria
{
    partial class CrearUsuario
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
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.tboxContraseñaCrear = new System.Windows.Forms.TextBox();
            this.tboxUsuarioCrear = new System.Windows.Forms.TextBox();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblContraseñaCrear = new System.Windows.Forms.Label();
            this.lblNombreCUrear = new System.Windows.Forms.Label();
            this.tboxContraseñaConfirmacion = new System.Windows.Forms.TextBox();
            this.lblContraseñaConfirmacion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.PancelCentral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PancelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.Firebrick;
            this.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Location = new System.Drawing.Point(270, 280);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(243, 25);
            this.btnCrearUsuario.TabIndex = 31;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // tboxContraseñaCrear
            // 
            this.tboxContraseñaCrear.Location = new System.Drawing.Point(334, 202);
            this.tboxContraseñaCrear.Name = "tboxContraseñaCrear";
            this.tboxContraseñaCrear.PasswordChar = '*';
            this.tboxContraseñaCrear.Size = new System.Drawing.Size(100, 20);
            this.tboxContraseñaCrear.TabIndex = 30;
            this.tboxContraseñaCrear.TextChanged += new System.EventHandler(this.tboxContraseñaCrear_TextChanged);
            // 
            // tboxUsuarioCrear
            // 
            this.tboxUsuarioCrear.Location = new System.Drawing.Point(334, 177);
            this.tboxUsuarioCrear.Name = "tboxUsuarioCrear";
            this.tboxUsuarioCrear.Size = new System.Drawing.Size(100, 20);
            this.tboxUsuarioCrear.TabIndex = 29;
            this.tboxUsuarioCrear.TextChanged += new System.EventHandler(this.tboxUsuarioCrear_TextChanged);
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(334, 152);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(100, 20);
            this.tboxDNI.TabIndex = 28;
            this.tboxDNI.TextChanged += new System.EventHandler(this.tboxDNI_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNombre.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNombre.Location = new System.Drawing.Point(279, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblApellido.ForeColor = System.Drawing.Color.Firebrick;
            this.lblApellido.Location = new System.Drawing.Point(278, 129);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(334, 126);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(100, 20);
            this.tboxApellido.TabIndex = 26;
            this.tboxApellido.TextChanged += new System.EventHandler(this.tboxApellido_TextChanged_1);
            // 
            // tboxNombre
            // 
            this.tboxNombre.BackColor = System.Drawing.Color.White;
            this.tboxNombre.Location = new System.Drawing.Point(334, 100);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 25;
            this.tboxNombre.TextChanged += new System.EventHandler(this.tboxNombre_TextChanged_1);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDNI.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDNI.Location = new System.Drawing.Point(301, 155);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 13);
            this.lblDNI.TabIndex = 22;
            this.lblDNI.Text = "DNI";
            this.lblDNI.Click += new System.EventHandler(this.lblDNI_Click);
            // 
            // lblContraseñaCrear
            // 
            this.lblContraseñaCrear.AutoSize = true;
            this.lblContraseñaCrear.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblContraseñaCrear.ForeColor = System.Drawing.Color.Firebrick;
            this.lblContraseñaCrear.Location = new System.Drawing.Point(261, 205);
            this.lblContraseñaCrear.Name = "lblContraseñaCrear";
            this.lblContraseñaCrear.Size = new System.Drawing.Size(67, 13);
            this.lblContraseñaCrear.TabIndex = 24;
            this.lblContraseñaCrear.Text = "Contraseña";
            this.lblContraseñaCrear.Click += new System.EventHandler(this.lblContraseñaCrear_Click);
            // 
            // lblNombreCUrear
            // 
            this.lblNombreCUrear.AutoSize = true;
            this.lblNombreCUrear.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNombreCUrear.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNombreCUrear.Location = new System.Drawing.Point(236, 180);
            this.lblNombreCUrear.Name = "lblNombreCUrear";
            this.lblNombreCUrear.Size = new System.Drawing.Size(92, 13);
            this.lblNombreCUrear.TabIndex = 23;
            this.lblNombreCUrear.Text = "Nombre Usuario";
            this.lblNombreCUrear.Click += new System.EventHandler(this.lblNombreCUrear_Click);
            // 
            // tboxContraseñaConfirmacion
            // 
            this.tboxContraseñaConfirmacion.Location = new System.Drawing.Point(334, 228);
            this.tboxContraseñaConfirmacion.Name = "tboxContraseñaConfirmacion";
            this.tboxContraseñaConfirmacion.PasswordChar = '*';
            this.tboxContraseñaConfirmacion.Size = new System.Drawing.Size(100, 20);
            this.tboxContraseñaConfirmacion.TabIndex = 33;
            this.tboxContraseñaConfirmacion.TextChanged += new System.EventHandler(this.tboxContraseñaConfirmacion_TextChanged);
            // 
            // lblContraseñaConfirmacion
            // 
            this.lblContraseñaConfirmacion.AutoSize = true;
            this.lblContraseñaConfirmacion.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblContraseñaConfirmacion.ForeColor = System.Drawing.Color.Firebrick;
            this.lblContraseñaConfirmacion.Location = new System.Drawing.Point(211, 231);
            this.lblContraseñaConfirmacion.Name = "lblContraseñaConfirmacion";
            this.lblContraseñaConfirmacion.Size = new System.Drawing.Size(117, 13);
            this.lblContraseñaConfirmacion.TabIndex = 32;
            this.lblContraseñaConfirmacion.Text = "Confirme Contraseña";
            this.lblContraseñaConfirmacion.Click += new System.EventHandler(this.lblContraseñaConfirmacion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(305, 311);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(187, 25);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // PancelCentral
            // 
            this.PancelCentral.Controls.Add(this.label1);
            this.PancelCentral.Controls.Add(this.tboxNombre);
            this.PancelCentral.Controls.Add(this.btnVolver);
            this.PancelCentral.Controls.Add(this.lblNombreCUrear);
            this.PancelCentral.Controls.Add(this.btnCrearUsuario);
            this.PancelCentral.Controls.Add(this.tboxContraseñaConfirmacion);
            this.PancelCentral.Controls.Add(this.lblContraseñaCrear);
            this.PancelCentral.Controls.Add(this.lblContraseñaConfirmacion);
            this.PancelCentral.Controls.Add(this.lblDNI);
            this.PancelCentral.Controls.Add(this.tboxApellido);
            this.PancelCentral.Controls.Add(this.tboxContraseñaCrear);
            this.PancelCentral.Controls.Add(this.lblApellido);
            this.PancelCentral.Controls.Add(this.tboxUsuarioCrear);
            this.PancelCentral.Controls.Add(this.lblNombre);
            this.PancelCentral.Controls.Add(this.tboxDNI);
            this.PancelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PancelCentral.Location = new System.Drawing.Point(0, 0);
            this.PancelCentral.Name = "PancelCentral";
            this.PancelCentral.Size = new System.Drawing.Size(778, 367);
            this.PancelCentral.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(244, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 62);
            this.label1.TabIndex = 36;
            this.label1.Text = "Jugueteria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 367);
            this.Controls.Add(this.PancelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            this.PancelCentral.ResumeLayout(false);
            this.PancelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox tboxContraseñaCrear;
        private System.Windows.Forms.TextBox tboxUsuarioCrear;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblContraseñaCrear;
        private System.Windows.Forms.Label lblNombreCUrear;
        private System.Windows.Forms.TextBox tboxContraseñaConfirmacion;
        private System.Windows.Forms.Label lblContraseñaConfirmacion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel PancelCentral;
        private System.Windows.Forms.Label label1;
    }
}