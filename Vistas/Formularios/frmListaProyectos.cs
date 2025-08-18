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
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Vistas.Formularios
{
    public partial class frmListaProyectos : Form
    {
        public frmListaProyectos()
        {
            InitializeComponent();
            mostrarProyecto();
            proyectoConexion();
            CargarDataGrid();

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

        private void btnAgregar_Click_1(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
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
            p.IdProyecto = int.Parse(dgvContenido.CurrentRow.Cells[0].Value.ToString());
            if(p.ActualizarProyectos()==true)
            {
                MessageBox.Show("Datos Actualizados correctamente","Exito");
                mostrarProyecto();
            }
            else
            {
                MessageBox.Show("Hubo un error , intenta de nuevo.","Error");
            }
        }

        private void dgvContenido_DoubleClick(object sender, EventArgs e)
        {
            txtNombreProyecto.Text = dgvContenido.CurrentRow.Cells[1].Value.ToString();
            if (dgvContenido.CurrentRow.Cells[2].Value.ToString()=="ACTIVO") {
            rbnActivo.Checked = true;
            }
            else { 
            rbnInactivo.Checked = true;
            
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProyecto.Text = "";

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dgvContenido.SelectedRows.Count > 0)
            {
                try
                {
                   
                    object valorId = dgvContenido.SelectedRows[0].Cells["Num."].Value;

                    if (valorId == null || valorId == DBNull.Value)
                    {
                        MessageBox.Show("No se encontró el ID del proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int idProyecto = Convert.ToInt32(valorId);

                    // Confirmar antes de eliminar
                    DialogResult confirm = MessageBox.Show(
                        "¿Está seguro de eliminar este proyecto?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            Proyecto proyecto = new Proyecto();
                            bool eliminado = proyecto.EliminarProyectos(idProyecto);

                            if (eliminado)
                            {
                                MessageBox.Show("Proyecto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Recargar el DataGridView usando método estático
                                try
                                {
                                    dgvContenido.DataSource = Proyecto.cargarTodosProyectos();
                                }
                                catch (Exception exRecarga)
                                {
                                    MessageBox.Show("Error al recargar los datos: " + exRecarga.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception exEliminar)
                        {
                            MessageBox.Show("Error al eliminar el proyecto: " + exEliminar.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proyecto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmListaProyectos_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvContenido.DataSource = null;
                dgvContenido.DataSource = Proyecto.Buscar(txtNombreProyecto.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Intenta de nuevo", "Error" + ex);

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                BitacoraSocial bitacora = new BitacoraSocial
                {
                    IdEstudiante = int.Parse(txtEstudianteBitacora.Text),
                    RegistroHoras = int.Parse(txtHoras.Text),
                    Descripcion = txtActvidad.Text,
                    FechaBitacora = dtpFechaBitacora.Value.Date
                };

                if (bitacora.InsertarBitacoraSocial())
                {
                    MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txtEstudianteBitacora.Clear();
                    txtHoras.Clear();
                    txtActvidad.Clear();

                    // Actualizar DataGridView
                    CargarDataGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar.\nDetalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarBitacora_Click(object sender, EventArgs e)
        {
            txtEstudianteBitacora.Text = "";
            txtHoras.Text = "";
            txtActvidad.Text = "";
        }

        private void dgvBitacoraEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvBitacoraEstudiantes.Rows[e.RowIndex];

                txtEstudianteBitacora.Text = fila.Cells["Estudiante"].Value.ToString();
                txtHoras.Text = fila.Cells["Horas"].Value.ToString();
                txtActvidad.Text = fila.Cells["Actividad"].Value.ToString();
                dtpFechaBitacora.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
            }
        }

        private void CargarDataGrid()
        {
            BitacoraSocial bitacora = new BitacoraSocial();
            dgvBitacoraEstudiantes.DataSource = bitacora.MostrarBitacoraSocial();
        }
    }
}
