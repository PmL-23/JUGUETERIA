﻿namespace UIJugueteria.IVendedor
{
    partial class FacturasCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tboxIDCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.dgvFacturasCliente = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnVerDetalleFactura = new System.Windows.Forms.Button();
            this.TotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmisionFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVendedorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasCliente)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxIDCliente
            // 
            this.tboxIDCliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tboxIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxIDCliente.ForeColor = System.Drawing.Color.White;
            this.tboxIDCliente.Location = new System.Drawing.Point(260, 4);
            this.tboxIDCliente.Name = "tboxIDCliente";
            this.tboxIDCliente.Size = new System.Drawing.Size(203, 20);
            this.tboxIDCliente.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Volver";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVolver.Location = new System.Drawing.Point(3, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(30, 23);
            this.btnVolver.TabIndex = 50;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(501, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(133, 24);
            this.btnBuscarCliente.TabIndex = 49;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.ForeColor = System.Drawing.Color.White;
            this.lblIDCliente.Location = new System.Drawing.Point(142, 5);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(71, 18);
            this.lblIDCliente.TabIndex = 48;
            this.lblIDCliente.Text = "ID Cliente";
            // 
            // dgvFacturasCliente
            // 
            this.dgvFacturasCliente.AllowUserToAddRows = false;
            this.dgvFacturasCliente.AllowUserToDeleteRows = false;
            this.dgvFacturasCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFacturasCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturasCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturasCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvFacturasCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturasCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFacturasCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturasCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturasCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVendedorFactura,
            this.IDCliente,
            this.IDFactura,
            this.FechaEmisionFactura,
            this.TotalFactura});
            this.dgvFacturasCliente.EnableHeadersVisualStyles = false;
            this.dgvFacturasCliente.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvFacturasCliente.Location = new System.Drawing.Point(0, 38);
            this.dgvFacturasCliente.MultiSelect = false;
            this.dgvFacturasCliente.Name = "dgvFacturasCliente";
            this.dgvFacturasCliente.ReadOnly = true;
            this.dgvFacturasCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturasCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturasCliente.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFacturasCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFacturasCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturasCliente.Size = new System.Drawing.Size(668, 329);
            this.dgvFacturasCliente.TabIndex = 53;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelSuperior.Controls.Add(this.btnBuscarCliente);
            this.panelSuperior.Controls.Add(this.lblIDCliente);
            this.panelSuperior.Controls.Add(this.tboxIDCliente);
            this.panelSuperior.Controls.Add(this.btnVolver);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(799, 37);
            this.panelSuperior.TabIndex = 54;
            // 
            // btnVerDetalleFactura
            // 
            this.btnVerDetalleFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalleFactura.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalleFactura.Location = new System.Drawing.Point(679, 175);
            this.btnVerDetalleFactura.Name = "btnVerDetalleFactura";
            this.btnVerDetalleFactura.Size = new System.Drawing.Size(111, 44);
            this.btnVerDetalleFactura.TabIndex = 55;
            this.btnVerDetalleFactura.Text = "Ver Detalle Factura";
            this.btnVerDetalleFactura.UseVisualStyleBackColor = true;
            // 
            // TotalFactura
            // 
            this.TotalFactura.HeaderText = "Total";
            this.TotalFactura.Name = "TotalFactura";
            this.TotalFactura.ReadOnly = true;
            // 
            // FechaEmisionFactura
            // 
            this.FechaEmisionFactura.HeaderText = "Fecha de Emision";
            this.FechaEmisionFactura.Name = "FechaEmisionFactura";
            this.FechaEmisionFactura.ReadOnly = true;
            // 
            // IDFactura
            // 
            this.IDFactura.HeaderText = "ID Factura";
            this.IDFactura.Name = "IDFactura";
            this.IDFactura.ReadOnly = true;
            // 
            // IDCliente
            // 
            this.IDCliente.HeaderText = "ID Cliente";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            // 
            // IDVendedorFactura
            // 
            this.IDVendedorFactura.HeaderText = "ID Vendedor";
            this.IDVendedorFactura.Name = "IDVendedorFactura";
            this.IDVendedorFactura.ReadOnly = true;
            // 
            // FacturasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(799, 365);
            this.Controls.Add(this.btnVerDetalleFactura);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.dgvFacturasCliente);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturasCliente";
            this.Text = "FacturasCliente";
            this.Load += new System.EventHandler(this.FacturasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasCliente)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboxIDCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.DataGridView dgvFacturasCliente;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnVerDetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVendedorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmisionFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFactura;
    }
}