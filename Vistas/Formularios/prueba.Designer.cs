namespace Vistas.Formularios
{
    partial class prueba
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
            this.redondearBoton1 = new Vistas.Clases.RedondearBoton();
            this.SuspendLayout();
            // 
            // redondearBoton1
            // 
            this.redondearBoton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.redondearBoton1.BorderColor = System.Drawing.Color.Aquamarine;
            this.redondearBoton1.BorderRadius = 30;
            this.redondearBoton1.BorderSize = 0;
            this.redondearBoton1.FlatAppearance.BorderSize = 0;
            this.redondearBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.redondearBoton1.Location = new System.Drawing.Point(34, 52);
            this.redondearBoton1.Name = "redondearBoton1";
            this.redondearBoton1.Size = new System.Drawing.Size(333, 173);
            this.redondearBoton1.TabIndex = 0;
            this.redondearBoton1.Text = "redondearBoton1";
            this.redondearBoton1.UseVisualStyleBackColor = false;
            // 
            // prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redondearBoton1);
            this.Name = "prueba";
            this.Text = "prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private Clases.RedondearBoton redondearBoton1;
    }
}