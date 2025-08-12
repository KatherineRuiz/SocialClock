namespace Vistas.Formularios
{
    partial class frmProyectos_Colaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProyectos_Colaborador));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpListadoProyectos = new System.Windows.Forms.TabPage();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.gbProyectos = new System.Windows.Forms.GroupBox();
            this.dgvContenido = new System.Windows.Forms.DataGridView();
            this.tlpListaProyectos = new System.Windows.Forms.Panel();
            this.pnlListadoProyectos = new System.Windows.Forms.Panel();
            this.lblListadoProyectos = new System.Windows.Forms.Label();
            this.tpEstudiantesProyecto = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbServicioSocial = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblNumEstudiante = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtNumEstudiante = new System.Windows.Forms.TextBox();
            this.txtActvidad = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.dtpFechaBitacora = new System.Windows.Forms.DateTimePicker();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarBitacora = new Vistas.Clases.RedondearBoton();
            this.redondearBoton1 = new Vistas.Clases.RedondearBoton();
            this.btnVerBitacora = new Vistas.Clases.RedondearBoton();
            this.btnLimpiarBitacora = new Vistas.Clases.RedondearBoton();
            this.btnRegistrar = new Vistas.Clases.RedondearBoton();
            this.gbBitacoraEstudiantes = new System.Windows.Forms.GroupBox();
            this.dgvBitacoraEstudiantes = new System.Windows.Forms.DataGridView();
            this.pnlEstudiantesProyecto = new System.Windows.Forms.Panel();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpListadoProyectos.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.gbProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenido)).BeginInit();
            this.tlpListaProyectos.SuspendLayout();
            this.pnlListadoProyectos.SuspendLayout();
            this.tpEstudiantesProyecto.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbServicioSocial.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbBitacoraEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraEstudiantes)).BeginInit();
            this.pnlEstudiantesProyecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpListadoProyectos);
            this.tabControl1.Controls.Add(this.tpEstudiantesProyecto);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1370, 815);
            this.tabControl1.TabIndex = 1;
            // 
            // tpListadoProyectos
            // 
            this.tpListadoProyectos.BackColor = System.Drawing.Color.White;
            this.tpListadoProyectos.Controls.Add(this.pnlContenido);
            this.tpListadoProyectos.Controls.Add(this.tlpListaProyectos);
            this.tpListadoProyectos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpListadoProyectos.Location = new System.Drawing.Point(4, 22);
            this.tpListadoProyectos.Margin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.tpListadoProyectos.Name = "tpListadoProyectos";
            this.tpListadoProyectos.Padding = new System.Windows.Forms.Padding(2);
            this.tpListadoProyectos.Size = new System.Drawing.Size(1362, 789);
            this.tpListadoProyectos.TabIndex = 0;
            this.tpListadoProyectos.Text = "Listado de Proyectos";
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.gbProyectos);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(2, 118);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlContenido.Size = new System.Drawing.Size(1358, 669);
            this.pnlContenido.TabIndex = 3;
            // 
            // gbProyectos
            // 
            this.gbProyectos.Controls.Add(this.dgvContenido);
            this.gbProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProyectos.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProyectos.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbProyectos.Location = new System.Drawing.Point(20, 10);
            this.gbProyectos.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.gbProyectos.Name = "gbProyectos";
            this.gbProyectos.Size = new System.Drawing.Size(1318, 649);
            this.gbProyectos.TabIndex = 3;
            this.gbProyectos.TabStop = false;
            this.gbProyectos.Text = "Proyectos";
            // 
            // dgvContenido
            // 
            this.dgvContenido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContenido.Location = new System.Drawing.Point(3, 30);
            this.dgvContenido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContenido.Name = "dgvContenido";
            this.dgvContenido.ReadOnly = true;
            this.dgvContenido.RowHeadersVisible = false;
            this.dgvContenido.RowHeadersWidth = 51;
            this.dgvContenido.RowTemplate.Height = 24;
            this.dgvContenido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContenido.Size = new System.Drawing.Size(1312, 616);
            this.dgvContenido.TabIndex = 14;
            this.dgvContenido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContenido_CellContentClick);
            // 
            // tlpListaProyectos
            // 
            this.tlpListaProyectos.BackColor = System.Drawing.Color.Transparent;
            this.tlpListaProyectos.Controls.Add(this.pnlListadoProyectos);
            this.tlpListaProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpListaProyectos.Location = new System.Drawing.Point(2, 2);
            this.tlpListaProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.tlpListaProyectos.Name = "tlpListaProyectos";
            this.tlpListaProyectos.Padding = new System.Windows.Forms.Padding(20);
            this.tlpListaProyectos.Size = new System.Drawing.Size(1358, 116);
            this.tlpListaProyectos.TabIndex = 2;
            // 
            // pnlListadoProyectos
            // 
            this.pnlListadoProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.pnlListadoProyectos.Controls.Add(this.lblListadoProyectos);
            this.pnlListadoProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListadoProyectos.Location = new System.Drawing.Point(20, 20);
            this.pnlListadoProyectos.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlListadoProyectos.Name = "pnlListadoProyectos";
            this.pnlListadoProyectos.Size = new System.Drawing.Size(1318, 76);
            this.pnlListadoProyectos.TabIndex = 16;
            // 
            // lblListadoProyectos
            // 
            this.lblListadoProyectos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListadoProyectos.AutoSize = true;
            this.lblListadoProyectos.BackColor = System.Drawing.Color.Transparent;
            this.lblListadoProyectos.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoProyectos.ForeColor = System.Drawing.Color.White;
            this.lblListadoProyectos.Location = new System.Drawing.Point(394, 14);
            this.lblListadoProyectos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListadoProyectos.Name = "lblListadoProyectos";
            this.lblListadoProyectos.Size = new System.Drawing.Size(503, 44);
            this.lblListadoProyectos.TabIndex = 2;
            this.lblListadoProyectos.Text = "Listado de Proyectos";
            // 
            // tpEstudiantesProyecto
            // 
            this.tpEstudiantesProyecto.AutoScroll = true;
            this.tpEstudiantesProyecto.BackColor = System.Drawing.Color.White;
            this.tpEstudiantesProyecto.Controls.Add(this.tableLayoutPanel2);
            this.tpEstudiantesProyecto.Location = new System.Drawing.Point(4, 22);
            this.tpEstudiantesProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.tpEstudiantesProyecto.Name = "tpEstudiantesProyecto";
            this.tpEstudiantesProyecto.Padding = new System.Windows.Forms.Padding(2);
            this.tpEstudiantesProyecto.Size = new System.Drawing.Size(1362, 789);
            this.tpEstudiantesProyecto.TabIndex = 1;
            this.tpEstudiantesProyecto.Text = "Estudiantes del Proyecto";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbServicioSocial, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gbBitacoraEstudiantes, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pnlEstudiantesProyecto, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1358, 785);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // gbServicioSocial
            // 
            this.gbServicioSocial.Controls.Add(this.tableLayoutPanel1);
            this.gbServicioSocial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServicioSocial.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServicioSocial.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbServicioSocial.Location = new System.Drawing.Point(30, 113);
            this.gbServicioSocial.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.gbServicioSocial.Name = "gbServicioSocial";
            this.gbServicioSocial.Size = new System.Drawing.Size(1298, 238);
            this.gbServicioSocial.TabIndex = 13;
            this.gbServicioSocial.TabStop = false;
            this.gbServicioSocial.Text = "Servicio social";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.60784F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39216F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1292, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.radioButton7);
            this.panel3.Controls.Add(this.tableLayoutPanel9);
            this.panel3.Controls.Add(this.radioButton8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 199);
            this.panel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(317, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado:";
            // 
            // radioButton7
            // 
            this.radioButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.radioButton7.Location = new System.Drawing.Point(587, 239);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(129, 34);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Inactivo";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 644F));
            this.tableLayoutPanel9.Controls.Add(this.lblActividad, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.lblNumEstudiante, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblHoras, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.txtNumEstudiante, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtActvidad, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.42373F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.87248F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.2953F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(970, 199);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // lblActividad
            // 
            this.lblActividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.ForeColor = System.Drawing.Color.Black;
            this.lblActividad.Location = new System.Drawing.Point(11, 137);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(304, 36);
            this.lblActividad.TabIndex = 2;
            this.lblActividad.Text = "Actividad realizada:";
            // 
            // lblNumEstudiante
            // 
            this.lblNumEstudiante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumEstudiante.AutoSize = true;
            this.lblNumEstudiante.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEstudiante.ForeColor = System.Drawing.Color.Black;
            this.lblNumEstudiante.Location = new System.Drawing.Point(57, 7);
            this.lblNumEstudiante.Name = "lblNumEstudiante";
            this.lblNumEstudiante.Size = new System.Drawing.Size(212, 36);
            this.lblNumEstudiante.TabIndex = 1;
            this.lblNumEstudiante.Text = "N° Estudiante:";
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.Black;
            this.lblHoras.Location = new System.Drawing.Point(71, 62);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(183, 36);
            this.lblHoras.TabIndex = 1;
            this.lblHoras.Text = "Num. Horas:";
            // 
            // txtNumEstudiante
            // 
            this.txtNumEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumEstudiante.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEstudiante.Location = new System.Drawing.Point(329, 9);
            this.txtNumEstudiante.Name = "txtNumEstudiante";
            this.txtNumEstudiante.ReadOnly = true;
            this.txtNumEstudiante.Size = new System.Drawing.Size(332, 31);
            this.txtNumEstudiante.TabIndex = 7;
            this.txtNumEstudiante.Text = "         ";
            // 
            // txtActvidad
            // 
            this.txtActvidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtActvidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActvidad.Location = new System.Drawing.Point(330, 124);
            this.txtActvidad.Multiline = true;
            this.txtActvidad.Name = "txtActvidad";
            this.txtActvidad.Size = new System.Drawing.Size(636, 61);
            this.txtActvidad.TabIndex = 9;
            this.txtActvidad.Text = "         ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.95349F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.04651F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tableLayoutPanel3.Controls.Add(this.lblFecha, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtHoras, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaBitacora, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(329, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(638, 55);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(219, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(112, 36);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtHoras
            // 
            this.txtHoras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHoras.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(3, 12);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(209, 31);
            this.txtHoras.TabIndex = 8;
            this.txtHoras.Text = "         ";
            // 
            // dtpFechaBitacora
            // 
            this.dtpFechaBitacora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaBitacora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBitacora.Location = new System.Drawing.Point(341, 12);
            this.dtpFechaBitacora.MinDate = new System.DateTime(2025, 8, 9, 16, 29, 5, 0);
            this.dtpFechaBitacora.Name = "dtpFechaBitacora";
            this.dtpFechaBitacora.Size = new System.Drawing.Size(291, 31);
            this.dtpFechaBitacora.TabIndex = 10;
            this.dtpFechaBitacora.Value = new System.DateTime(2025, 8, 9, 16, 29, 5, 0);
            // 
            // radioButton8
            // 
            this.radioButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton8.AutoSize = true;
            this.radioButton8.BackColor = System.Drawing.Color.Transparent;
            this.radioButton8.Checked = true;
            this.radioButton8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.radioButton8.Location = new System.Drawing.Point(472, 239);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(109, 34);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Activo";
            this.radioButton8.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminarBitacora);
            this.panel2.Controls.Add(this.redondearBoton1);
            this.panel2.Controls.Add(this.btnVerBitacora);
            this.panel2.Controls.Add(this.btnLimpiarBitacora);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(979, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 199);
            this.panel2.TabIndex = 4;
            // 
            // btnEliminarBitacora
            // 
            this.btnEliminarBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.btnEliminarBitacora.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnEliminarBitacora.BorderRadius = 30;
            this.btnEliminarBitacora.BorderSize = 0;
            this.btnEliminarBitacora.FlatAppearance.BorderSize = 0;
            this.btnEliminarBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBitacora.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarBitacora.ForeColor = System.Drawing.Color.White;
            this.btnEliminarBitacora.Image = global::Vistas.Properties.Resources.eliminar;
            this.btnEliminarBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarBitacora.Location = new System.Drawing.Point(4, 152);
            this.btnEliminarBitacora.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.btnEliminarBitacora.Name = "btnEliminarBitacora";
            this.btnEliminarBitacora.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminarBitacora.Size = new System.Drawing.Size(263, 41);
            this.btnEliminarBitacora.TabIndex = 7;
            this.btnEliminarBitacora.Text = "Eliminar";
            this.btnEliminarBitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarBitacora.UseVisualStyleBackColor = false;
            // 
            // redondearBoton1
            // 
            this.redondearBoton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.redondearBoton1.BorderColor = System.Drawing.Color.Aquamarine;
            this.redondearBoton1.BorderRadius = 30;
            this.redondearBoton1.BorderSize = 0;
            this.redondearBoton1.FlatAppearance.BorderSize = 0;
            this.redondearBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redondearBoton1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redondearBoton1.ForeColor = System.Drawing.Color.White;
            this.redondearBoton1.Image = ((System.Drawing.Image)(resources.GetObject("redondearBoton1.Image")));
            this.redondearBoton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.redondearBoton1.Location = new System.Drawing.Point(138, 107);
            this.redondearBoton1.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.redondearBoton1.Name = "redondearBoton1";
            this.redondearBoton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.redondearBoton1.Size = new System.Drawing.Size(130, 39);
            this.redondearBoton1.TabIndex = 8;
            this.redondearBoton1.Text = "Editar";
            this.redondearBoton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.redondearBoton1.UseVisualStyleBackColor = false;
            // 
            // btnVerBitacora
            // 
            this.btnVerBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.btnVerBitacora.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnVerBitacora.BorderRadius = 30;
            this.btnVerBitacora.BorderSize = 0;
            this.btnVerBitacora.FlatAppearance.BorderSize = 0;
            this.btnVerBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerBitacora.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerBitacora.ForeColor = System.Drawing.Color.White;
            this.btnVerBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerBitacora.Location = new System.Drawing.Point(4, 58);
            this.btnVerBitacora.Name = "btnVerBitacora";
            this.btnVerBitacora.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVerBitacora.Size = new System.Drawing.Size(264, 45);
            this.btnVerBitacora.TabIndex = 7;
            this.btnVerBitacora.Text = "Ver bitacora";
            this.btnVerBitacora.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarBitacora
            // 
            this.btnLimpiarBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.btnLimpiarBitacora.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnLimpiarBitacora.BorderRadius = 30;
            this.btnLimpiarBitacora.BorderSize = 0;
            this.btnLimpiarBitacora.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBitacora.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBitacora.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarBitacora.Location = new System.Drawing.Point(4, 107);
            this.btnLimpiarBitacora.Name = "btnLimpiarBitacora";
            this.btnLimpiarBitacora.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLimpiarBitacora.Size = new System.Drawing.Size(128, 39);
            this.btnLimpiarBitacora.TabIndex = 6;
            this.btnLimpiarBitacora.Text = "Limpiar";
            this.btnLimpiarBitacora.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BorderRadius = 30;
            this.btnRegistrar.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(5, 5);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(263, 48);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // gbBitacoraEstudiantes
            // 
            this.gbBitacoraEstudiantes.Controls.Add(this.dgvBitacoraEstudiantes);
            this.gbBitacoraEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBitacoraEstudiantes.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBitacoraEstudiantes.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbBitacoraEstudiantes.Location = new System.Drawing.Point(30, 371);
            this.gbBitacoraEstudiantes.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.gbBitacoraEstudiantes.Name = "gbBitacoraEstudiantes";
            this.gbBitacoraEstudiantes.Size = new System.Drawing.Size(1298, 404);
            this.gbBitacoraEstudiantes.TabIndex = 12;
            this.gbBitacoraEstudiantes.TabStop = false;
            this.gbBitacoraEstudiantes.Text = "Bitacora de estudiantes";
            // 
            // dgvBitacoraEstudiantes
            // 
            this.dgvBitacoraEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacoraEstudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvBitacoraEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoraEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacoraEstudiantes.Location = new System.Drawing.Point(3, 30);
            this.dgvBitacoraEstudiantes.Name = "dgvBitacoraEstudiantes";
            this.dgvBitacoraEstudiantes.ReadOnly = true;
            this.dgvBitacoraEstudiantes.Size = new System.Drawing.Size(1292, 371);
            this.dgvBitacoraEstudiantes.TabIndex = 1;
            this.dgvBitacoraEstudiantes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBitacoraEstudiantes_CellContentDoubleClick);
            // 
            // pnlEstudiantesProyecto
            // 
            this.pnlEstudiantesProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.pnlEstudiantesProyecto.Controls.Add(this.btnRegresar);
            this.pnlEstudiantesProyecto.Controls.Add(this.label2);
            this.pnlEstudiantesProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstudiantesProyecto.Location = new System.Drawing.Point(20, 15);
            this.pnlEstudiantesProyecto.Margin = new System.Windows.Forms.Padding(20, 15, 30, 15);
            this.pnlEstudiantesProyecto.Name = "pnlEstudiantesProyecto";
            this.pnlEstudiantesProyecto.Size = new System.Drawing.Size(1308, 73);
            this.pnlEstudiantesProyecto.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnRegresar.IconColor = System.Drawing.Color.White;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresar.Location = new System.Drawing.Point(3, 7);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(66, 62);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(606, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estudiantes del proyecto";
            // 
            // frmProyectos_Colaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1100, 788);
            this.ClientSize = new System.Drawing.Size(1387, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmProyectos_Colaborador";
            this.Text = "Proyectos_Colaborador";
            this.Load += new System.EventHandler(this.frmProyectos_Colaborador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpListadoProyectos.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.gbProyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenido)).EndInit();
            this.tlpListaProyectos.ResumeLayout(false);
            this.pnlListadoProyectos.ResumeLayout(false);
            this.pnlListadoProyectos.PerformLayout();
            this.tpEstudiantesProyecto.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbServicioSocial.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbBitacoraEstudiantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraEstudiantes)).EndInit();
            this.pnlEstudiantesProyecto.ResumeLayout(false);
            this.pnlEstudiantesProyecto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpListadoProyectos;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel tlpListaProyectos;
        private System.Windows.Forms.Panel pnlListadoProyectos;
        private System.Windows.Forms.Label lblListadoProyectos;
        private System.Windows.Forms.TabPage tpEstudiantesProyecto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbBitacoraEstudiantes;
        private System.Windows.Forms.DataGridView dgvBitacoraEstudiantes;
        private System.Windows.Forms.Panel pnlEstudiantesProyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbProyectos;
        private System.Windows.Forms.DataGridView dgvContenido;
        private System.Windows.Forms.GroupBox gbServicioSocial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblNumEstudiante;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtNumEstudiante;
        private System.Windows.Forms.TextBox txtActvidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.DateTimePicker dtpFechaBitacora;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Panel panel2;
        private Clases.RedondearBoton btnEliminarBitacora;
        private Clases.RedondearBoton redondearBoton1;
        private Clases.RedondearBoton btnVerBitacora;
        private Clases.RedondearBoton btnLimpiarBitacora;
        private Clases.RedondearBoton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnRegresar;
    }
}