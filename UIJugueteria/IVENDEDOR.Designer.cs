﻿namespace UIJugueteria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerHistorialCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_venta = new System.Windows.Forms.Button();
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnVerHistorialCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelSuperior);
            this.panel1.Controls.Add(this.btn_venta);
            this.panel1.Controls.Add(this.grillaClientes);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 365);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVerHistorialCliente
            // 
            this.btnVerHistorialCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerHistorialCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHistorialCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerHistorialCliente.ForeColor = System.Drawing.Color.White;
            this.btnVerHistorialCliente.Location = new System.Drawing.Point(618, 251);
            this.btnVerHistorialCliente.Name = "btnVerHistorialCliente";
            this.btnVerHistorialCliente.Size = new System.Drawing.Size(142, 43);
            this.btnVerHistorialCliente.TabIndex = 9;
            this.btnVerHistorialCliente.Text = "Ver historial cliente";
            this.btnVerHistorialCliente.UseVisualStyleBackColor = true;
            this.btnVerHistorialCliente.Click += new System.EventHandler(this.btnVerHistorialCliente_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de clientes";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.btn_salir);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(799, 36);
            this.panelSuperior.TabIndex = 8;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seccion Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(695, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(101, 30);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Cerrar sesion";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_venta
            // 
            this.btn_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_venta.ForeColor = System.Drawing.Color.White;
            this.btn_venta.Location = new System.Drawing.Point(618, 182);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(142, 43);
            this.btn_venta.TabIndex = 6;
            this.btn_venta.Text = "Nueva venta";
            this.btn_venta.UseVisualStyleBackColor = true;
            this.btn_venta.Click += new System.EventHandler(this.button5_Click);
            // 
            // grillaClientes
            // 
            this.grillaClientes.AllowUserToAddRows = false;
            this.grillaClientes.AllowUserToDeleteRows = false;
            this.grillaClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.grillaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grillaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grillaClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grillaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.EnableHeadersVisualStyles = false;
            this.grillaClientes.GridColor = System.Drawing.Color.DarkSlateGray;
            this.grillaClientes.Location = new System.Drawing.Point(35, 113);
            this.grillaClientes.MultiSelect = false;
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.ReadOnly = true;
            this.grillaClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaClientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.grillaClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grillaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaClientes.Size = new System.Drawing.Size(553, 211);
            this.grillaClientes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(618, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IVENDEDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 365);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IVENDEDOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IVENDEDOR";
            this.Load += new System.EventHandler(this.IVENDEDOR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerHistorialCliente;
    }
}