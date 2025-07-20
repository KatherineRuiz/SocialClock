using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmSocialClock : Form
    {

        public frmSocialClock()
        {
            InitializeComponent();

        }

        //Metodo para redondear las esquinas de los paneles
        private void RedondearPanel(Panel panel, int radio)
        {
            //Creamos un objeto de tipo GraphicsPath
            GraphicsPath path = new GraphicsPath();
            //Dibujamos la figura
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }


        #region "Metodo para pintar formularios"
        //Creamos un atributo
        private Form activarForm = null;

        private void abrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            //Si existe un formulario abierto, se cerrará
            {
                activarForm.Close();
            }
            //Le damos todos los permisos que tiene la clase form
            activarForm = formularioPintar;
            //Convertimos a un hijo de tipo de form
            formularioPintar.TopLevel = false;
            //Quitamos los bordes
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }
        #endregion
        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirForm(new frmInicio());
        }

        //private void btnTercerAño_Click(object sender, EventArgs e)
        //{
        //    frmInicio3 fi3 = new frmInicio3();
        //    fi3.Show();
        //    this.Hide();
        //}


    }
}
