namespace Vistas.Formularios
{
    partial class frmListaProyectos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.dgvContenido = new System.Windows.Forms.DataGridView();
            this.tlpListaProyectos = new System.Windows.Forms.Panel();
            this.pnlListadoProyectos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenido)).BeginInit();
            this.tlpListaProyectos.SuspendLayout();
            this.pnlListadoProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1659, 761);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlContenido);
            this.tabPage1.Controls.Add(this.tlpListaProyectos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1651, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.Transparent;
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1645, 100);
            this.pnlCabecera.TabIndex = 0;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.dgvContenido);
            this.pnlContenido.Controls.Add(this.pnlCabecera);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(3, 168);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1645, 561);
            this.pnlContenido.TabIndex = 3;
            // 
            // dgvContenido
            // 
            this.dgvContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContenido.Location = new System.Drawing.Point(0, 100);
            this.dgvContenido.Name = "dgvContenido";
            this.dgvContenido.RowHeadersWidth = 51;
            this.dgvContenido.RowTemplate.Height = 24;
            this.dgvContenido.Size = new System.Drawing.Size(1645, 461);
            this.dgvContenido.TabIndex = 1;
            // 
            // tlpListaProyectos
            // 
            this.tlpListaProyectos.BackColor = System.Drawing.Color.White;
            this.tlpListaProyectos.Controls.Add(this.pnlListadoProyectos);
            this.tlpListaProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpListaProyectos.Location = new System.Drawing.Point(3, 3);
            this.tlpListaProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpListaProyectos.Name = "tlpListaProyectos";
            this.tlpListaProyectos.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.tlpListaProyectos.Size = new System.Drawing.Size(1645, 165);
            this.tlpListaProyectos.TabIndex = 2;
            // 
            // pnlListadoProyectos
            // 
            this.pnlListadoProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.pnlListadoProyectos.Controls.Add(this.label1);
            this.pnlListadoProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListadoProyectos.Location = new System.Drawing.Point(27, 25);
            this.pnlListadoProyectos.Margin = new System.Windows.Forms.Padding(27, 18, 27, 18);
            this.pnlListadoProyectos.Name = "pnlListadoProyectos";
            this.pnlListadoProyectos.Size = new System.Drawing.Size(1591, 115);
            this.pnlListadoProyectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Proyectos";
            // 
            // frmListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 761);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmListaProyectos";
            this.Text = "frmListaProyectos";
            this.Load += new System.EventHandler(this.frmListaProyectos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenido)).EndInit();
            this.tlpListaProyectos.ResumeLayout(false);
            this.pnlListadoProyectos.ResumeLayout(false);
            this.pnlListadoProyectos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.DataGridView dgvContenido;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel tlpListaProyectos;
        private System.Windows.Forms.Panel pnlListadoProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}