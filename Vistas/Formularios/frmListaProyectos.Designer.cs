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
            this.tlpListaProyectos = new System.Windows.Forms.Panel();
            this.lblListaProyectos = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tlpListaProyectos.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpListaProyectos
            // 
            this.tlpListaProyectos.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.tlpListaProyectos.Controls.Add(this.lblListaProyectos);
            this.tlpListaProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpListaProyectos.Location = new System.Drawing.Point(0, 0);
            this.tlpListaProyectos.Name = "tlpListaProyectos";
            this.tlpListaProyectos.Size = new System.Drawing.Size(1328, 100);
            this.tlpListaProyectos.TabIndex = 0;
            // 
            // lblListaProyectos
            // 
            this.lblListaProyectos.AutoSize = true;
            this.lblListaProyectos.BackColor = System.Drawing.Color.Transparent;
            this.lblListaProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListaProyectos.Font = new System.Drawing.Font("Perpetua Titling MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProyectos.ForeColor = System.Drawing.Color.White;
            this.lblListaProyectos.Image = global::Vistas.Properties.Resources.fondo;
            this.lblListaProyectos.Location = new System.Drawing.Point(381, 19);
            this.lblListaProyectos.Name = "lblListaProyectos";
            this.lblListaProyectos.Size = new System.Drawing.Size(596, 60);
            this.lblListaProyectos.TabIndex = 0;
            this.lblListaProyectos.Text = "Lista de Proyectos";
            this.lblListaProyectos.Click += new System.EventHandler(this.lblListaProyectos_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.pnlCabecera);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 100);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1328, 797);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlCabecera.Controls.Add(this.comboBox1);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1328, 100);
            this.pnlCabecera.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(65, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PRIMER AÑO";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1145, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 897);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.tlpListaProyectos);
            this.Name = "frmListaProyectos";
            this.Text = "frmListaProyectos";
            this.Load += new System.EventHandler(this.frmListaProyectos_Load);
            this.tlpListaProyectos.ResumeLayout(false);
            this.tlpListaProyectos.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tlpListaProyectos;
        private System.Windows.Forms.Label lblListaProyectos;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}