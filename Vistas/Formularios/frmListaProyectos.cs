using Modelos;
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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmListaProyectos : Form
    {
        public frmListaProyectos()
        {
            InitializeComponent();
            mostrarProyecto();
            proyectoConexion();

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
       

        //private void btnProyectos_Click(object sender, EventArgs e)
        //{
        //    dgvContenido.DataSource = null;
        //    dgvContenido.DataSource = Proyecto.cargarTodosProyectos();
        //}
        private void mostrarProyecto()
        {
            dgvContenido.DataSource = null;
            dgvContenido.DataSource = Proyecto.cargarTodosProyectos();
        }


        private void proyectoConexion()
        {
            dgvBitacoraEstudiantes.DataSource = null;
            dgvBitacoraEstudiantes.DataSource = Proyecto.cargarEstudianteProyecto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Proyecto p = new Proyecto();
            p.NombreProyecto = txtNombreProyecto.Text;
            if (rbnActivo.Checked == true)
            {
                p.EstadoProyecto = false;
            }
            else
            {
                p.EstadoProyecto = true;

            }

            p.InsertarProyecto();
            MessageBox.Show("Exito", "Datos ingresados correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mostrarProyecto();

        }

        private void dgvContenido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que no sea encabezado
            {
                // Leer los datos del registro seleccionado
                DataGridViewRow fila = dgvContenido.Rows[e.RowIndex];

                string id = fila.Cells["Num."].Value.ToString();
                string Proyecto = fila.Cells["Proyecto"].Value.ToString();


                // cbProyecto.Text = Proyecto ;


                tabControl1.SelectedTab = tpEstudiantesProyecto;
            }
        }


    }
}
