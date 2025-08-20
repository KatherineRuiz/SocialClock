using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
   public class BitacoraSocial
    {
        private int idBitacora;
        private int registroHoras;
        private string descripcion;
        private DateTime fechaBitacora;
        private int idEstudiante;

        public int IdBitacora { get => idBitacora; set => idBitacora = value; }
        public int RegistroHoras { get => registroHoras; set => registroHoras = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaBitacora { get => fechaBitacora; set => fechaBitacora = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }


        public bool InsertarBitacoraSocial()
        {
            // Usar using asegura que la conexión se cierre aunque ocurra un error
            using (SqlConnection con = Conexion.Conectar())
            {
                string comando = @"INSERT INTO BitacoraSocial 
                           (registroHoras, descripcion, fechaBitacora, idEstudiante)
                           VALUES (@registroHoras, @descripcion, @fechaBitacora, @idEstudiante)";

                using (SqlCommand cmd = new SqlCommand(comando, con))
                {
                    // Pasar directamente los valores tipados
                    cmd.Parameters.AddWithValue("@registroHoras", this.RegistroHoras);
                    cmd.Parameters.AddWithValue("@descripcion", this.Descripcion);
                    cmd.Parameters.AddWithValue("@fechaBitacora", this.FechaBitacora);
                    cmd.Parameters.AddWithValue("@idEstudiante", this.IdEstudiante);

                    // Abrir conexión solo si no está abierta
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static DataTable Buscar(string termino)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    string query = @"
            SELECT  
                Estudiante.carnet AS [Carnet],  
                Estudiante.nombreEstudiante AS [Nombre],  
                Especialidad.nombreEspecialidad AS [Especialidad],  
                NivelAcademico.nombreNivel AS [Nivel académico],  
                Seccion.nombreSeccion AS [Seccion],  
                Estudiante.nie AS [NIE],  
                CASE Estudiante.estadoEstudiante  
                    WHEN 0 THEN 'ACTIVO'  
                    WHEN 1 THEN 'INACTIVO'  
                END AS [Estado],  
                Proyecto.nombreProyecto AS [Proyecto],  
                BitacoraSocial.registroHoras AS [No. Horas]  

            FROM Estudiante 
            LEFT JOIN BitacoraSocial  
                ON BitacoraSocial.idEstudiante = Estudiante.idEstudiante  
            INNER JOIN Proyecto  
                ON Estudiante.id_Proyecto = Proyecto.idProyecto  
            INNER JOIN Esp_Niv_Sec  
                ON Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec  
            INNER JOIN Especialidad  
                ON Esp_Niv_Sec.id_Especialidad = Especialidad.idEspecialidad  
            INNER JOIN NivelAcademico  
                ON Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico  
            INNER JOIN Seccion  
                ON Esp_Niv_Sec.id_Seccion = Seccion.idSeccion  
            WHERE (@termino = '' 
                   OR Estudiante.nombreEstudiante LIKE @termino 
                   OR Estudiante.carnet LIKE @termino 
                   OR Estudiante.nie LIKE @termino)
            ORDER BY Estudiante.nombreEstudiante;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@termino", string.IsNullOrEmpty(termino) ? "" : "%" + termino + "%");

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable(); // Devuelve vacío si hay error
            }
        }





        public bool eliminarBitacora(int id)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    string consultaDelete = "DELETE FROM BitacoraSocial WHERE idBitacora = @idBitacora";
                    SqlCommand delete = new SqlCommand(consultaDelete, con);
                    delete.Parameters.AddWithValue("@idBitacora", id);

                    return delete.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public DataTable MostrarBitacoraSocial()
        {
            using (SqlConnection con = Conexion.Conectar())
            {
                string query = @"SELECT idBitacora AS ID, registroHoras AS Horas, descripcion AS Actividad, fechaBitacora AS Fecha, idEstudiante AS Estudiante 
                             FROM BitacoraSocial";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



    }
}
