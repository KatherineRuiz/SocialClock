using Modelos;
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
    public partial class frmInicio1 : Form
    {
        public frmInicio1()
        {
            InitializeComponent();
        }

        private void RedondearPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void frmInicio1_Load(object sender, EventArgs e)
        {
            RedondearPanel(pnFondo, 50);
            RedondearPanel(pnBienvenida, 40);

            MostrarEstudiantes();
        }

        //Creamos un metodo para mostrar la informacion de la base de datos 
        private void MostrarEstudiantes()
        {
            dgvPrimerAño.DataSource = null;
            dgvPrimerAño.DataSource = Estudiante.CargarEstudiantesPrimerAño();
            {

            }
        }
    }
}
