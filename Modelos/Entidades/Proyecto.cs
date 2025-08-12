using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Proyecto
    {
        private int idProyecto;
        private string nombreProyecto;
        private bool estadoProyecto;

        public int IdProyecto { get => idProyecto; set => idProyecto = value; }
        public string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }
        public bool EstadoProyecto { get => estadoProyecto; set => estadoProyecto = value; }

        public static DataTable cargarProyecto()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "select idProyecto, nombreProyecto, estadoProyecto from Proyecto;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable virtualTable = new DataTable();
            add.Fill(virtualTable);
            return virtualTable;
        }

        public static DataTable cargarTodosProyectos()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "select idProyecto As [Num.], nombreProyecto As Proyecto, CASE estadoProyecto\r\nwhen 0 then 'ACTIVO'\r\nwhen 1 then 'INACTIVO'\r\nEND As [Estado]\r\nfrom Proyecto ";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable virtualTable = new DataTable();
            add.Fill(virtualTable);
            return virtualTable;
        }

        public bool InsertarProyecto()
        {

            SqlConnection con = Conexion.Conectar();
            string comando = "Insert into Proyecto(nombreProyecto, estadoProyecto)" + "values (@nombreProyecto, @estadoProyecto);";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nombreProyecto", nombreProyecto);
            cmd.Parameters.AddWithValue("@estadoProyecto", EstadoProyecto);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DataTable cargarEstudianteProyecto()
        {

            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "select carnet As [Carnet], nombreEstudiante As [Nombre],Especialidad.nombreEspecialidad As [Especialidad]," +
                "\r\nNivelAcademico.nombreNivel As [Nivel académico], Seccion.nombreSeccion As [Seccion], nie As [NIE], CASE estadoEstudiante" +
                "\r\nwhen 0 then 'ACTIVO'\r\nwhen 1 then 'INACTIVO'\r\nEND As [Estado],\r\nProyecto.nombreProyecto As [Proyecto], BitacoraSocial.registroHoras As [No. Horas]" +
                "\r\nfrom Estudiante \r\nLEFT JOIN \r\nBitacoraSocial on BitacoraSocial.idEstudiante = Estudiante.idEstudiante" +
                "\r\nINNER JOIN\r\nProyecto on Estudiante.id_Proyecto = Proyecto.idProyecto" +
                "\r\nINNER JOIN\r\nEsp_Niv_Sec on Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec" +
                "\r\nINNER JOIN\r\nEspecialidad on Esp_Niv_Sec.id_Especialidad = Especialidad.idEspecialidad" +
                "\r\nINNER JOIN \r\nNivelAcademico on Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico" +
                "\r\nINNER JOIN \r\nSeccion on Esp_Niv_Sec.id_Seccion = Seccion.idSeccion;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable virtualTable = new DataTable();
            add.Fill(virtualTable);
            return virtualTable;
        }

        public bool ActualizarProyectos()

        {
            SqlConnection conexion = Conexion.Conectar();
            string comando = "UPDATE Proyecto set nombreProyecto=@nombreProyecto," + "estadoProyecto=@estadoProyecto where idProyecto=@id";
            SqlCommand cmd = new SqlCommand(comando , conexion);
            cmd.Parameters.AddWithValue("@nombreProyecto", nombreProyecto);
            cmd.Parameters.AddWithValue("@estadoProyecto", estadoProyecto);
            cmd.Parameters.AddWithValue("@id", idProyecto);
            if(cmd.ExecuteNonQuery()>0)
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
