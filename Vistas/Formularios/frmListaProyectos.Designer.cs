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
            this.tlpListaProyectos = new System.Windows.Forms.Panel();
            this.pnlListadoProyectos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContenido = new System.Windows.Forms.DataGridView();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.pnlContenido.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.tlpListaProyectos.SuspendLayout();
            this.pnlListadoProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.dgvContenido);
            this.pnlContenido.Controls.Add(this.pnlCabecera);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 165);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1659, 596);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.Transparent;
            this.pnlCabecera.Controls.Add(this.btnProyectos);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1659, 100);
            this.pnlCabecera.TabIndex = 0;
            // 
            // tlpListaProyectos
            // 
            this.tlpListaProyectos.BackColor = System.Drawing.Color.White;
            this.tlpListaProyectos.Controls.Add(this.pnlListadoProyectos);
            this.tlpListaProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpListaProyectos.Location = new System.Drawing.Point(0, 0);
            this.tlpListaProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpListaProyectos.Name = "tlpListaProyectos";
            this.tlpListaProyectos.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.tlpListaProyectos.Size = new System.Drawing.Size(1659, 165);
            this.tlpListaProyectos.TabIndex = 0;
            // 
            // pnlListadoProyectos
            // 
            this.pnlListadoProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.pnlListadoProyectos.Controls.Add(this.label1);
            this.pnlListadoProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListadoProyectos.Location = new System.Drawing.Point(27, 25);
            this.pnlListadoProyectos.Margin = new System.Windows.Forms.Padding(27, 18, 27, 18);
            this.pnlListadoProyectos.Name = "pnlListadoProyectos";
            this.pnlListadoProyectos.Size = new System.Drawing.Size(1605, 115);
            this.pnlListadoProyectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Proyectos";
            // 
            // dgvContenido
            // 
            this.dgvContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContenido.Location = new System.Drawing.Point(0, 100);
            this.dgvContenido.Name = "dgvContenido";
            this.dgvContenido.RowHeadersWidth = 51;
            this.dgvContenido.RowTemplate.Height = 24;
            this.dgvContenido.Size = new System.Drawing.Size(1659, 496);
            this.dgvContenido.TabIndex = 1;
            this.dgvContenido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContenido_CellContentClick);
            // 
            // btnProyectos
            // 
            this.btnProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectos.Font = new System.Drawing.Font("Perpetua Titling MT", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.Location = new System.Drawing.Point(12, 5);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(1620, 89);
            this.btnProyectos.TabIndex = 0;
            this.btnProyectos.Text = "PROYECTOS";
            this.btnProyectos.UseVisualStyleBackColor = false;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // frmListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 761);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.tlpListaProyectos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmListaProyectos";
            this.Text = "frmListaProyectos";
            this.Load += new System.EventHandler(this.frmListaProyectos_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.tlpListaProyectos.ResumeLayout(false);
            this.pnlListadoProyectos.ResumeLayout(false);
            this.pnlListadoProyectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel tlpListaProyectos;
        private System.Windows.Forms.Panel pnlListadoProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContenido;
        private System.Windows.Forms.Button btnProyectos;
    }
}