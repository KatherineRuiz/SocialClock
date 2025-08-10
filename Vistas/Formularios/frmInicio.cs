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
using System.Net;
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
            RedondearPanel(pnlBienvenida, 40);
            ocultarSubTabla(false);
            mostrarNivelAcademico();
            mostrarProyecto();
            mostrarSeccion();
            mostrarEspecialidad();
            MostrarEstudiantePrimerAño();
            MostrarEstudianteSegundoAño();
            MostrarEstudianteTercerAño();
            MostrarEstudianteRetirado();

            lblEstado.Visible = false;
            rbActivo.Visible = false;
            rbInactivo.Visible = false;
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

        //Método para ocultar subtablas
        private void ocultarSubTabla(bool estado)
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

        #region Gestión de botones del listado de estudiantes

        private void btnPrimerAño_Click(object sender, EventArgs e)
        {
            pnlSegundoAño.Visible = false;
            pnlEspacio2.Visible = false;
            pnlTercerAño.Visible = false;
            pnlEspacio3.Visible = false;
            pnlEstudiantesRetirados.Visible = false;
            pnlEspacio4.Visible = false;
            if (pnlPrimerAño.Visible == false)
            {
                pnlPrimerAño.Visible = true;
                pnlEspacio1.Visible = true;
            }
            else
            {
                ocultarSubTabla(false);
            }

            MostrarEstudiantePrimerAño();
        }

        private void btnSeundoAño_Click(object sender, EventArgs e)
        {
            pnlPrimerAño.Visible = false;
            pnlEspacio1.Visible = false;
            pnlTercerAño.Visible = false;
            pnlEspacio3.Visible = false;
            pnlEstudiantesRetirados.Visible = false;
            pnlEspacio4.Visible = false;
            if (pnlSegundoAño.Visible == false)
            {
                pnlSegundoAño.Visible = true;
                pnlEspacio2.Visible = true;
            }
            else
            {
                ocultarSubTabla(false);
            }
        }

        private void btnTercerAño_Click_1(object sender, EventArgs e)
        {
            pnlPrimerAño.Visible = false;
            pnlEspacio1.Visible = false;
            pnlSegundoAño.Visible = false;
            pnlEspacio2.Visible = false;
            pnlEstudiantesRetirados.Visible = false;
            pnlEspacio4.Visible = false;
            if (pnlTercerAño.Visible == false)
            {
                pnlTercerAño.Visible = true;
                pnlEspacio3.Visible = true;
            }
            else
            {
                ocultarSubTabla(false);
            }
        }

        private void btnEstudiantesRetirados_Click_1(object sender, EventArgs e)
        {
            pnlPrimerAño.Visible = false;
            pnlEspacio1.Visible = false;
            pnlSegundoAño.Visible = false;
            pnlEspacio2.Visible = false;
            pnlTercerAño.Visible = false;
            pnlEspacio3.Visible = false;
            if (pnlEstudiantesRetirados.Visible == false)
            {
                pnlEstudiantesRetirados.Visible = true;
                pnlEspacio4.Visible = true;
            }
            else
            {
                ocultarSubTabla(false);
            }
        }

        #endregion



        #region Metodos para mostrar las opciones disponibles de los combo box
        private void mostrarNivelAcademico()
        {
            cbNivelAcademico.DataSource = null;
            cbNivelAcademico.DataSource = NivelAcademico.cargarNivelAcademico();
            cbNivelAcademico.DisplayMember = "nombreNivel";
            cbNivelAcademico.ValueMember = "idNivelAcademico";
            cbNivelAcademico.SelectedIndex = -1;
        }

        private void mostrarEspecialidad()
        {
            cbEspecialidad.DataSource = null;
            cbEspecialidad.DataSource = Especialidad.cargarEspecialidad();
            cbEspecialidad.DisplayMember = "nombreEspecialidad";
            cbEspecialidad.ValueMember = "idEspecialidad";
            cbEspecialidad.SelectedIndex = -1;
        }

        private void mostrarSeccion()
        {
            cbSeccion.DataSource = null;
            cbSeccion.DataSource = Seccion.cargarSeccion();
            cbSeccion.DisplayMember = "nombreSeccion";
            cbSeccion.ValueMember = "idSeccion";
            cbSeccion.SelectedIndex = -1;
        }

        private void mostrarProyecto()
        {
            cbProyecto.DataSource = null;
            cbProyecto.DataSource = Proyecto.cargarProyecto();
            cbProyecto.DisplayMember = "nombreProyecto";
            cbProyecto.ValueMember = "idProyecto";
            cbProyecto.SelectedIndex = -1;
        }
        #endregion

        private void MostrarEstudiantePrimerAño()
        {
            dgvPrimerAño.DataSource = null;
            dgvPrimerAño.DataSource = Estudiante.CargarEstudiantesPrimerAño();
        }

        private void MostrarEstudianteSegundoAño()
        {
            dgvSegundoAño.DataSource = null;
            dgvSegundoAño.DataSource = Estudiante.CargarEstudiantesSegundoAño();
        }

        private void MostrarEstudianteTercerAño()
        {
            dgvTercerAño.DataSource = null;
            dgvTercerAño.DataSource = Estudiante.CargarEstudiantesTercerAño();
        }

        private void MostrarEstudianteRetirado()
        {
            dgvEstudiantesRetirados.DataSource = null;
            dgvEstudiantesRetirados.DataSource = Estudiante.CargarEstudiantesRetirados();
        }


        public void frmInicio_Load(object sender, EventArgs e)
        {
            RedondearPanel(pnlBienvenida, 40);
            ocultarSubTabla(false);
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            //Creamos un objeto Estudiante
            Estudiante es = new Estudiante();
            es.Carnet = txtCarnet.Text;
            es.NombreEstudiante = txtNombre.Text;
            es.Nie = txtNie.Text;
            es.Proyecto = Convert.ToInt32(cbProyecto.SelectedValue);
            es.Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
            es.NivelAcademico = Convert.ToInt32(cbNivelAcademico.SelectedValue);
            es.Seccion = Convert.ToInt32(cbSeccion.SelectedValue);

            if (rbActivo.Checked == true)
            {
                es.Estado = false;
            }
            else if (rbInactivo.Checked == true)
            {
                es.Estado = true;
            }

            es.InsertarEstudiantes();
            MostrarEstudiantePrimerAño();
            MostrarEstudianteSegundoAño();
            MostrarEstudianteTercerAño();
            MostrarEstudianteRetirado();
            MessageBox.Show("Exelente. Datos registrados", "Inscripción exitosa");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCarnet.Text = "";
            txtNie.Text = "";
            rbActivo.Checked = true;

            lblEstado.Visible = false;
            rbActivo.Visible = false;
            rbInactivo.Visible = false;
        }

        #region Metodos para cargar datos que se actualizaran
        private void dgvPrimerAño_DoubleClick(object sender, EventArgs e)
        {
            txtCarnet.Text = dgvPrimerAño.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvPrimerAño.CurrentRow.Cells[2].Value.ToString();
            //cbEspecialidad.SelectedValue = Convert.ToInt32(dgvPrimerAño.CurrentRow.Cells[3].Value);
            //cbNivelAcademico.SelectedValue = Convert.ToInt32(dgvPrimerAño.CurrentRow.Cells[4].Value.ToString());
            //cbSeccion.SelectedValue = Convert.ToInt32(dgvPrimerAño.CurrentRow.Cells[5].Value.ToString());
            txtNie.Text = dgvPrimerAño.CurrentRow.Cells[6].Value.ToString();
            //cbProyecto.SelectedValue = Convert.ToInt32(dgvPrimerAño.CurrentRow.Cells[8].Value.ToString());

            lblEstado.Visible = true;
            rbActivo.Visible = true;
            rbInactivo.Visible = true;
        }

        private void dgvSegundoAño_DoubleClick(object sender, EventArgs e)
        {
            txtCarnet.Text = dgvSegundoAño.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvSegundoAño.CurrentRow.Cells[2].Value.ToString();
            txtNie.Text = dgvSegundoAño.CurrentRow.Cells[6].Value.ToString();
            //cbEspecialidad.SelectedValue = Convert.ToInt32(dgvSegundoAño.CurrentRow.Cells[3].Value.ToString());
            //cbNivelAcademico.SelectedValue = Convert.ToInt32(dgvSegundoAño.CurrentRow.Cells[4].Value.ToString());
            //cbSeccion.SelectedValue = Convert.ToInt32(dgvSegundoAño.CurrentRow.Cells[5].Value.ToString());
            //cbProyecto.SelectedValue = Convert.ToInt32(dgvSegundoAño.CurrentRow.Cells[8].Value.ToString());

            lblEstado.Visible = true;
            rbActivo.Visible = true;
            rbInactivo.Visible = true;
        }

        private void dgvTercerAño_DoubleClick(object sender, EventArgs e)
        {
            txtCarnet.Text = dgvTercerAño.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvTercerAño.CurrentRow.Cells[2].Value.ToString();
            txtNie.Text = dgvTercerAño.CurrentRow.Cells[6].Value.ToString();
            //cbEspecialidad.SelectedValue = Convert.ToInt32(dgvTercerAño.CurrentRow.Cells[3].Value.ToString());
            //cbNivelAcademico.SelectedValue = Convert.ToInt32(dgvTercerAño.CurrentRow.Cells[4].Value.ToString());
            //cbSeccion.SelectedValue = Convert.ToInt32(dgvTercerAño.CurrentRow.Cells[5].Value.ToString());
            //cbProyecto.SelectedValue = Convert.ToInt32(dgvTercerAño.CurrentRow.Cells[8].Value.ToString());

            lblEstado.Visible = true;
            rbActivo.Visible = true;
            rbInactivo.Visible = true;
        }

        private void dgvEstudiantesRetirados_DoubleClick(object sender, EventArgs e)
        {
            txtCarnet.Text = dgvEstudiantesRetirados.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvEstudiantesRetirados.CurrentRow.Cells[2].Value.ToString();
            txtNie.Text = dgvEstudiantesRetirados.CurrentRow.Cells[6].Value.ToString();
            if (int.TryParse(dgvPrimerAño.CurrentRow.Cells[2]?.Value?.ToString(), out int especialidadId))
                cbEspecialidad.SelectedValue = especialidadId;

            if (int.TryParse(dgvPrimerAño.CurrentRow.Cells[3]?.Value?.ToString(), out int nivelId))
                cbNivelAcademico.SelectedValue = nivelId;

            if (int.TryParse(dgvPrimerAño.CurrentRow.Cells[4]?.Value?.ToString(), out int seccionId))
                cbSeccion.SelectedValue = seccionId;

            if (int.TryParse(dgvPrimerAño.CurrentRow.Cells[7]?.Value?.ToString(), out int proyectoId))
                cbProyecto.SelectedValue = proyectoId;
            //cbEspecialidad.SelectedValue = Convert.ToInt32(dgvEstudiantesRetirados.CurrentRow.Cells[3].Value.ToString());
            //cbNivelAcademico.SelectedValue = Convert.ToInt32(dgvEstudiantesRetirados.CurrentRow.Cells[4].Value.ToString());
            //cbSeccion.SelectedValue = Convert.ToInt32(dgvEstudiantesRetirados.CurrentRow.Cells[5].Value.ToString());
            //cbProyecto.SelectedValue = Convert.ToInt32(dgvEstudiantesRetirados.CurrentRow.Cells[8].Value.ToString());

            lblEstado.Visible = true;
            rbActivo.Visible = true;
            rbInactivo.Visible = true;
        }
        #endregion


        private void btnEditar_Click(object sender, EventArgs e)
        {
            //int niv = 

            Estudiante es = new Estudiante();
            es.Carnet = txtCarnet.Text;
            es.NombreEstudiante = txtNombre.Text;
            es.Nie = txtNie.Text;
            es.Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
            es.NivelAcademico = Convert.ToInt32(cbNivelAcademico.SelectedValue);
            es.Seccion = Convert.ToInt32(cbSeccion.SelectedValue);
            if (rbActivo.Checked == true)
            {
                es.Estado = false;
            }
            else if (rbInactivo.Checked == true)
            {
                es.Estado = true;
            }

            if (es.NivelAcademico == 1 && es.Estado == false)
            {
                es.Id = int.Parse(dgvPrimerAño.CurrentRow.Cells[0].Value.ToString());
            }
            else if(es.NivelAcademico == 2 && es.Estado == false)
            {
                es.Id = int.Parse(dgvSegundoAño.CurrentRow.Cells[0].Value.ToString());
            }
            else if (es.NivelAcademico == 2 && es.Estado == false)
            {
                es.Id = int.Parse(dgvTercerAño.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                es.Id = int.Parse(dgvEstudiantesRetirados.CurrentRow.Cells[0].Value.ToString());
            }
            if (es.actualizarEstudiantes())
            {
                MostrarEstudiantePrimerAño();
                MostrarEstudianteSegundoAño();
                MostrarEstudianteTercerAño();
                MostrarEstudianteRetirado();
            }
            else
            {
                MessageBox.Show("Error al actualizar la información", "La actualización falló");

            }
        }
    }
}
