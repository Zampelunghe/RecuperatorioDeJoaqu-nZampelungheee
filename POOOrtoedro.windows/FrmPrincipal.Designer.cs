
namespace POOOrtoedro.windows
{
    partial class Frm_Principal
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
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrtoedroGridView = new System.Windows.Forms.DataGridView();
            this.colAristaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAristaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAristaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.TrazosToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.GuardartoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrtoedroGridView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Enabled = false;
            this.CantidadTextBox.Location = new System.Drawing.Point(522, 1);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(36, 20);
            this.CantidadTextBox.TabIndex = 21;
            this.CantidadTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cantidad:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrtoedroGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 425);
            this.panel1.TabIndex = 19;
            // 
            // OrtoedroGridView
            // 
            this.OrtoedroGridView.AllowUserToAddRows = false;
            this.OrtoedroGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.OrtoedroGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrtoedroGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrtoedroGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAristaA,
            this.colAristaB,
            this.colAristaC,
            this.colVolumen,
            this.colArea,
            this.ColRelleno});
            this.OrtoedroGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrtoedroGridView.Location = new System.Drawing.Point(0, 0);
            this.OrtoedroGridView.MultiSelect = false;
            this.OrtoedroGridView.Name = "OrtoedroGridView";
            this.OrtoedroGridView.ReadOnly = true;
            this.OrtoedroGridView.RowHeadersVisible = false;
            this.OrtoedroGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrtoedroGridView.Size = new System.Drawing.Size(693, 425);
            this.OrtoedroGridView.TabIndex = 0;
            // 
            // colAristaA
            // 
            this.colAristaA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAristaA.HeaderText = "AristaA";
            this.colAristaA.Name = "colAristaA";
            this.colAristaA.ReadOnly = true;
            // 
            // colAristaB
            // 
            this.colAristaB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAristaB.HeaderText = "AristaB";
            this.colAristaB.Name = "colAristaB";
            this.colAristaB.ReadOnly = true;
            // 
            // colAristaC
            // 
            this.colAristaC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAristaC.HeaderText = "AristaC";
            this.colAristaC.Name = "colAristaC";
            this.colAristaC.ReadOnly = true;
            // 
            // colVolumen
            // 
            this.colVolumen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVolumen.HeaderText = "Volumen";
            this.colVolumen.Name = "colVolumen";
            this.colVolumen.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArea.HeaderText = "Área";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // ColRelleno
            // 
            this.ColRelleno.HeaderText = "Relleno";
            this.ColRelleno.Name = "ColRelleno";
            this.ColRelleno.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBorrar,
            this.tsbEditar,
            this.toolStripSeparator1,
            this.tsbFiltrar,
            this.tsbRefrescar,
            this.toolStripSeparator2,
            this.tsbOrdenar,
            this.toolStripSeparator3,
            this.tsbSalir,
            this.toolStripSeparator4,
            this.GuardartoolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(693, 25);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(43, 22);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(41, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrazosToolStripComboBox});
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(50, 22);
            this.tsbFiltrar.Text = "Filtrar";
            this.tsbFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TrazosToolStripComboBox
            // 
            this.TrazosToolStripComboBox.Name = "TrazosToolStripComboBox";
            this.TrazosToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(59, 22);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOrdenar
            // 
            this.tsbOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.tsbOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdenar.Name = "tsbOrdenar";
            this.tsbOrdenar.Size = new System.Drawing.Size(63, 22);
            this.tsbOrdenar.Text = "Ordenar";
            this.tsbOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOrdenar.Click += new System.EventHandler(this.tsbOrdenar_Click);
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSalir
            // 
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(33, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // GuardartoolStripButton1
            // 
            this.GuardartoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardartoolStripButton1.Name = "GuardartoolStripButton1";
            this.GuardartoolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.GuardartoolStripButton1.Text = "Guardar";
            this.GuardartoolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardartoolStripButton1.Click += new System.EventHandler(this.GuardartoolStripButton1_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrtoedroGridView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView OrtoedroGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAristaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAristaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAristaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRelleno;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbFiltrar;
        private System.Windows.Forms.ToolStripComboBox TrazosToolStripComboBox;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsbOrdenar;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton GuardartoolStripButton1;
    }
}