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
