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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpListaProyectos = new System.Windows.Forms.Panel();
            this.pnlListadoProyectos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.tlpListaProyectos.SuspendLayout();
            this.pnlListadoProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.pnlCabecera);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 134);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1244, 484);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlCabecera.Controls.Add(this.comboBox1);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1244, 81);
            this.pnlCabecera.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(859, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(49, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PRIMER AÑO";
            // 
            // tlpListaProyectos
            // 
            this.tlpListaProyectos.BackColor = System.Drawing.Color.White;
            this.tlpListaProyectos.Controls.Add(this.pnlListadoProyectos);
            this.tlpListaProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpListaProyectos.Location = new System.Drawing.Point(0, 0);
            this.tlpListaProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.tlpListaProyectos.Name = "tlpListaProyectos";
            this.tlpListaProyectos.Padding = new System.Windows.Forms.Padding(20);
            this.tlpListaProyectos.Size = new System.Drawing.Size(1244, 134);
            this.tlpListaProyectos.TabIndex = 0;
            // 
            // pnlListadoProyectos
            // 
            this.pnlListadoProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.pnlListadoProyectos.Controls.Add(this.label1);
            this.pnlListadoProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListadoProyectos.Location = new System.Drawing.Point(20, 20);
            this.pnlListadoProyectos.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlListadoProyectos.Name = "pnlListadoProyectos";
            this.pnlListadoProyectos.Size = new System.Drawing.Size(1204, 94);
            this.pnlListadoProyectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Proyectos";
            // 
            // frmListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 618);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.tlpListaProyectos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaProyectos";
            this.Text = "frmListaProyectos";
            this.Load += new System.EventHandler(this.frmListaProyectos_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.tlpListaProyectos.ResumeLayout(false);
            this.pnlListadoProyectos.ResumeLayout(false);
            this.pnlListadoProyectos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel tlpListaProyectos;
        private System.Windows.Forms.Panel pnlListadoProyectos;
        private System.Windows.Forms.Label label1;
    }
}