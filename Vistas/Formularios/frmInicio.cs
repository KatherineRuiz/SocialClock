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
    public partial class frmInicio : Form
    {

        public frmInicio()
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
            //Redondeamos paneles
            RedondearPanel(pnlContenido, 50);
            RedondearPanel(pnlBienvenida, 40);

            OcultarSubTabla(false);
        }

        private void OcultarSubTabla(bool estado)
        {
            pnlPrimerAño.Visible = estado;
            pnlEspacio1.Visible = estado;
            pnlSegundoAño.Visible = estado;
            pnlEspacio2.Visible = estado;
            pnlTercerAño.Visible = estado;
            pnlEspacio3.Visible = estado;
            pnlEstudiantesRetirados.Visible = estado;
            pnlEspacio4.Visible = estado;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            //Creamos un objeto Estudiante
            Estudiante es = new Estudiante();
            es.Carnet = int.Parse(txtCarnet.Text);
            es.NombreEstudiante = txtNombre.Text;
            es.Nie = int.Parse(txtNie.Text);
            es.NivelAcademico = cbNivelAcademico.Text;
            es.Seccion = cbSeccion.Text;
            es.Especialidad = cbEspecialidad.Text;
            es.Proyecto = cbProyecto.Text;
            es.Estado = true;

            es.InsertarEstudiantes();
        }

        

        //private void btnPrimerAño_Click(object sender, EventArgs e)
        //{
        //    frmInicio1 fi1 = new frmInicio1();
        //    fi1.Show();
        //    this.Hide();
        //}

        //private void btnSegundoAño_Click(object sender, EventArgs e)
        //{
        //    frmInicio2 fi2 = new frmInicio2();
        //    fi2.Show();
        //    this.Hide();
        //}

        //private void btnTercerAño_Click(object sender, EventArgs e)
        //{
        //    frmInicio3 fi3 = new frmInicio3();
        //    fi3.Show();
        //    this.Hide();
        //}


    }
}
