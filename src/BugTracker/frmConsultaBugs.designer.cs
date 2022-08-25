﻿namespace BugTracker
{
    partial class frmConsultaBugs
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
            this.pnl_filtros = new System.Windows.Forms.GroupBox();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.cboCriticidades = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboPrioridades = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboAsignadoA = new System.Windows.Forms.ComboBox();
            this.lbl_asignado = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.dgvBugs = new System.Windows.Forms.DataGridView();
            this.pnl_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_filtros
            // 
            this.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_filtros.Controls.Add(this.cboProductos);
            this.pnl_filtros.Controls.Add(this.Label5);
            this.pnl_filtros.Controls.Add(this.txtFechaHasta);
            this.pnl_filtros.Controls.Add(this.Label4);
            this.pnl_filtros.Controls.Add(this.Label3);
            this.pnl_filtros.Controls.Add(this.txtFechaDesde);
            this.pnl_filtros.Controls.Add(this.cboCriticidades);
            this.pnl_filtros.Controls.Add(this.Label1);
            this.pnl_filtros.Controls.Add(this.cboPrioridades);
            this.pnl_filtros.Controls.Add(this.Label2);
            this.pnl_filtros.Controls.Add(this.btnConsultar);
            this.pnl_filtros.Controls.Add(this.cboAsignadoA);
            this.pnl_filtros.Controls.Add(this.lbl_asignado);
            this.pnl_filtros.Controls.Add(this.cboEstados);
            this.pnl_filtros.Controls.Add(this.lbl_estado);
            this.pnl_filtros.Location = new System.Drawing.Point(16, 19);
            this.pnl_filtros.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnl_filtros.Size = new System.Drawing.Size(1200, 219);
            this.pnl_filtros.TabIndex = 1;
            this.pnl_filtros.TabStop = false;
            this.pnl_filtros.Text = "Filtros";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(497, 116);
            this.cboProductos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(239, 28);
            this.cboProductos.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(416, 120);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 20);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Producto:";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(498, 33);
            this.txtFechaHasta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(238, 27);
            this.txtFechaHasta.TabIndex = 13;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(402, 39);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 20);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Fecha Hasta:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(5, 39);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 20);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Fecha desde:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(102, 33);
            this.txtFechaDesde.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(239, 27);
            this.txtFechaDesde.TabIndex = 9;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // cboCriticidades
            // 
            this.cboCriticidades.FormattingEnabled = true;
            this.cboCriticidades.Location = new System.Drawing.Point(497, 73);
            this.cboCriticidades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboCriticidades.Name = "cboCriticidades";
            this.cboCriticidades.Size = new System.Drawing.Size(239, 28);
            this.cboCriticidades.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(416, 79);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Criticidad:";
            // 
            // cboPrioridades
            // 
            this.cboPrioridades.FormattingEnabled = true;
            this.cboPrioridades.Location = new System.Drawing.Point(102, 157);
            this.cboPrioridades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboPrioridades.Name = "cboPrioridades";
            this.cboPrioridades.Size = new System.Drawing.Size(239, 28);
            this.cboPrioridades.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(25, 161);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 20);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Prioridad:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(1074, 175);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 36);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboAsignadoA
            // 
            this.cboAsignadoA.FormattingEnabled = true;
            this.cboAsignadoA.Location = new System.Drawing.Point(102, 116);
            this.cboAsignadoA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboAsignadoA.Name = "cboAsignadoA";
            this.cboAsignadoA.Size = new System.Drawing.Size(239, 28);
            this.cboAsignadoA.TabIndex = 3;
            // 
            // lbl_asignado
            // 
            this.lbl_asignado.AutoSize = true;
            this.lbl_asignado.Location = new System.Drawing.Point(9, 120);
            this.lbl_asignado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_asignado.Name = "lbl_asignado";
            this.lbl_asignado.Size = new System.Drawing.Size(87, 20);
            this.lbl_asignado.TabIndex = 2;
            this.lbl_asignado.Text = "Asignado a:";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(102, 73);
            this.cboEstados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(239, 28);
            this.cboEstados.TabIndex = 1;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(42, 79);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(57, 20);
            this.lbl_estado.TabIndex = 0;
            this.lbl_estado.Text = "Estado:";
            // 
            // dgvBugs
            // 
            this.dgvBugs.AllowUserToAddRows = false;
            this.dgvBugs.AllowUserToDeleteRows = false;
            this.dgvBugs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugs.Location = new System.Drawing.Point(16, 245);
            this.dgvBugs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvBugs.Name = "dgvBugs";
            this.dgvBugs.ReadOnly = true;
            this.dgvBugs.RowHeadersWidth = 51;
            this.dgvBugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBugs.Size = new System.Drawing.Size(1200, 481);
            this.dgvBugs.TabIndex = 6;
            // 
            // frmConsultaBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 741);
            this.Controls.Add(this.dgvBugs);
            this.Controls.Add(this.pnl_filtros);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmConsultaBugs";
            this.Text = "Consultar Bugs en BD";
            this.Load += new System.EventHandler(this.frmBugs_Load);
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox pnl_filtros;
        internal System.Windows.Forms.ComboBox cboProductos;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.MaskedTextBox txtFechaHasta;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.MaskedTextBox txtFechaDesde;
        internal System.Windows.Forms.ComboBox cboCriticidades;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboPrioridades;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.ComboBox cboAsignadoA;
        internal System.Windows.Forms.Label lbl_asignado;
        internal System.Windows.Forms.ComboBox cboEstados;
        internal System.Windows.Forms.Label lbl_estado;
        internal System.Windows.Forms.DataGridView dgvBugs;

    }
}