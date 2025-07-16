using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Modelos.Entidades
{

    public class Estudiante
    {
        //Declaramso los atributos de la entidad
        private int id;
        private string nombreEstudiante;
        private string nivelAcademico;
        private string seccion;
        private string especialidad;
        private string proyecto;
        private int carnet;
        private int nie;
        private bool estado = true;

        public int Id { get => id; set => id = value; }
        public string NombreEstudiante { get => nombreEstudiante; set => nombreEstudiante = value; }
        public string NivelAcademico { get => nivelAcademico; set => nivelAcademico = value; }
        public string Seccion { get => seccion; set => seccion = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Proyecto { get => proyecto; set => proyecto = value; }
        public int Carnet { get => carnet; set => carnet = value; }
        public int Nie { get => nie; set => nie = value; }
        public bool Estado { get => estado; set => estado = value; }


        //Creeamos un metodoestatico de tipo DataTable para cargar los registros que están en la base de datos en una tabla 
        //Metodo Leer
        public static DataTable CargarEstudiantesPrimerAño()
        {
            //Creamso una variable de tipo SqlConnection y llamamos al metodo de la clase Conexion
            SqlConnection con = Conexion.Conectar();

            string comando = "select carnet, nombreEstudiante, nivelAcademico, seccion, especialidad, proyecto, nie from Estudiante where nivelAcademico = 1;";

            //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);

            //Creamos un objeto DataTable, una tabla donde se guardara la informacion
            DataTable dt = new DataTable();

            //Pasamos la informacion de adaptador a la tabla
            ad.Fill(dt);

            return dt;
        }

        //Metodo Insertar
        public bool InsertarEstudiantes()
        {
            SqlConnection con = Conexion.Conectar();

            //Comando para insertar datos a Sql Server
            string comando = "insert into Estudiantes(carnet, nombreEstudiante, nivelAcademico, seccion, especialidad, proyecto, @nie)" +
                "values (@carnet, @nombreEstudiante, @nivelAcademico, @seccion, @especialidad, @proyecto, @nie);";

            //Creamos un objeto de tipo SqlCommand
            SqlCommand cmd = new SqlCommand(comando,con);

            //Sustituimos los valores temporales por los astributos
            cmd.Parameters.AddWithValue("@carnet", carnet);
            cmd.Parameters.AddWithValue("@nombreEstudiante", nombreEstudiante);
            cmd.Parameters.AddWithValue("@nivelAcademico", nivelAcademico);
            cmd.Parameters.AddWithValue("@seccion", seccion);
            cmd.Parameters.AddWithValue("@especialidad", especialidad);
            cmd.Parameters.AddWithValue("@proyecto", proyecto);
            cmd.Parameters.AddWithValue("@nie", nie);

            //Enviamos el comando a SqlServer
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
        
}
