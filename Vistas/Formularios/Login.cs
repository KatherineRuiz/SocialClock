using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            RedondearPanel(pnlLogin, 40);
        }

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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();

            string claveBD = "";
            claveBD = usr.ConsultarClave(txtUsuario.Text);

            //MessageBox.Show("claveBD " + claveBD, "Error");
            if (claveBD != null)
            {
                if (txtClave.Text == claveBD)
                {
                    frmSocialClock fe = new frmSocialClock();
                    fe.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o clave no coinciden", "Error");
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o clave no coinciden", "Error");
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}