using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (SqlConnection con = Conexion.Conectar())
            {
                string comando = @"INSERT INTO BitacoraSocial 
                               (registroHoras, descripcion, fechaBitacora, idEstudiante)
                               VALUES (@registroHoras, @descripcion, @fechaBitacora, @idEstudiante)";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@registroHoras", registroHoras);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@fechaBitacora", fechaBitacora);
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
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
