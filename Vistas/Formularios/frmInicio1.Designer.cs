﻿namespace Vistas.Formularios
{
    partial class frmInicio1
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
            this.pnFondo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnBienvenida = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.gbListadoEstudiantes = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPrimerAño = new System.Windows.Forms.DataGridView();
            this.btnPrimerAño = new Vistas.Clases.RedondearBoton();
            this.btnEditar = new Vistas.Clases.RedondearBoton();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.btnProyecto = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnFondo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnBienvenida.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbListadoEstudiantes.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerAño)).BeginInit();
            this.tlpMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFondo
            // 
            this.pnFondo.BackColor = System.Drawing.Color.White;
            this.pnFondo.Controls.Add(this.tableLayoutPanel2);
            this.pnFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFondo.Location = new System.Drawing.Point(105, 20);
            this.pnFondo.Margin = new System.Windows.Forms.Padding(5, 20, 20, 20);
            this.pnFondo.Name = "pnFondo";
            this.pnFondo.Size = new System.Drawing.Size(1245, 709);
            this.pnFondo.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbListadoEstudiantes, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pnBienvenida, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.88717F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.11284F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1245, 709);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnBienvenida
            // 
            this.pnBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.pnBienvenida.Controls.Add(this.tableLayoutPanel10);
            this.pnBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBienvenida.Location = new System.Drawing.Point(15, 15);
            this.pnBienvenida.Margin = new System.Windows.Forms.Padding(15);
            this.pnBienvenida.Name = "pnBienvenida";
            this.pnBienvenida.Size = new System.Drawing.Size(1215, 111);
            this.pnBienvenida.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.txtBusqueda, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1215, 111);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1176F));
            this.tableLayoutPanel3.Controls.Add(this.btnRegresar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblBienvenida, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1209, 49);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Perpetua Titling MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenida.Location = new System.Drawing.Point(189, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(863, 48);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Administración de servicio social";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnRegresar.IconColor = System.Drawing.Color.White;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(23, 43);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.Silver;
            this.txtBusqueda.Location = new System.Drawing.Point(8, 70);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(1199, 26);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Text = "Ingrese el carnet del estudiante";
            // 
            // gbListadoEstudiantes
            // 
            this.gbListadoEstudiantes.Controls.Add(this.tableLayoutPanel9);
            this.gbListadoEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListadoEstudiantes.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoEstudiantes.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbListadoEstudiantes.Location = new System.Drawing.Point(30, 171);
            this.gbListadoEstudiantes.Margin = new System.Windows.Forms.Padding(30);
            this.gbListadoEstudiantes.Name = "gbListadoEstudiantes";
            this.gbListadoEstudiantes.Size = new System.Drawing.Size(1185, 508);
            this.gbListadoEstudiantes.TabIndex = 3;
            this.gbListadoEstudiantes.TabStop = false;
            this.gbListadoEstudiantes.Text = "LISTADO DE ESTUDIANTES";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.btnEditar, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.btnPrimerAño, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.dgvPrimerAño, 0, 2);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.57895F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36842F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.05264F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1179, 475);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // dgvPrimerAño
            // 
            this.dgvPrimerAño.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrimerAño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimerAño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrimerAño.Location = new System.Drawing.Point(20, 166);
            this.dgvPrimerAño.Margin = new System.Windows.Forms.Padding(20);
            this.dgvPrimerAño.Name = "dgvPrimerAño";
            this.dgvPrimerAño.Size = new System.Drawing.Size(1139, 289);
            this.dgvPrimerAño.TabIndex = 2;
            // 
            // btnPrimerAño
            // 
            this.btnPrimerAño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrimerAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.btnPrimerAño.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnPrimerAño.BorderRadius = 60;
            this.btnPrimerAño.BorderSize = 0;
            this.btnPrimerAño.FlatAppearance.BorderSize = 0;
            this.btnPrimerAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimerAño.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerAño.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrimerAño.Image = global::Vistas.Properties.Resources.primero;
            this.btnPrimerAño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimerAño.Location = new System.Drawing.Point(47, 12);
            this.btnPrimerAño.Name = "btnPrimerAño";
            this.btnPrimerAño.Size = new System.Drawing.Size(1084, 68);
            this.btnPrimerAño.TabIndex = 0;
            this.btnPrimerAño.Text = "Primer año";
            this.btnPrimerAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimerAño.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrimerAño.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.btnEditar.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnEditar.BorderRadius = 30;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::Vistas.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(979, 96);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(150, 41);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Controls.Add(this.btnAjustes, 0, 0);
            this.tlpMenu.Controls.Add(this.btnInicio, 0, 1);
            this.tlpMenu.Controls.Add(this.btnProyecto, 0, 2);
            this.tlpMenu.Controls.Add(this.btnEstadistica, 0, 3);
            this.tlpMenu.Controls.Add(this.btnSalir, 0, 4);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(3, 3);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 5;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tlpMenu.Size = new System.Drawing.Size(94, 743);
            this.tlpMenu.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::Vistas.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(36, 671);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 69);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.Image = global::Vistas.Properties.Resources.estadistica;
            this.btnEstadistica.Location = new System.Drawing.Point(3, 415);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(88, 127);
            this.btnEstadistica.TabIndex = 3;
            this.btnEstadistica.UseVisualStyleBackColor = true;
            // 
            // btnProyecto
            // 
            this.btnProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProyecto.FlatAppearance.BorderSize = 0;
            this.btnProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyecto.Image = global::Vistas.Properties.Resources.proyectos2;
            this.btnProyecto.Location = new System.Drawing.Point(3, 279);
            this.btnProyecto.Name = "btnProyecto";
            this.btnProyecto.Size = new System.Drawing.Size(88, 130);
            this.btnProyecto.TabIndex = 2;
            this.btnProyecto.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Image = global::Vistas.Properties.Resources.inicio2;
            this.btnInicio.Location = new System.Drawing.Point(3, 151);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(88, 122);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Image = global::Vistas.Properties.Resources.ajustes2;
            this.btnAjustes.Location = new System.Drawing.Point(3, 3);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(88, 142);
            this.btnAjustes.TabIndex = 0;
            this.btnAjustes.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1270F));
            this.tableLayoutPanel1.Controls.Add(this.tlpMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnFondo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmInicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmInicio1";
            this.Text = "frmInicio1";
            this.Load += new System.EventHandler(this.frmInicio1_Load);
            this.pnFondo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnBienvenida.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbListadoEstudiantes.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerAño)).EndInit();
            this.tlpMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFondo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbListadoEstudiantes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private Clases.RedondearBoton btnEditar;
        private Clases.RedondearBoton btnPrimerAño;
        private System.Windows.Forms.DataGridView dgvPrimerAño;
        private System.Windows.Forms.Panel pnBienvenida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProyecto;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}