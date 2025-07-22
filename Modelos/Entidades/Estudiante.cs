using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Modelos.Entidades
{

    public class Estudiante
    {
        //Declaramos los atributos de la entidad
        private int id;
        private string nombreEstudiante;
        private string carnet;
        private string nie;
        private bool estado;
        private int proyecto;
        private int espNivSec;

        private int especialidad;
        private int nivelAcademico;
        private int seccion;


        public int Id { get => id; set => id = value; }
        public string NombreEstudiante { get => nombreEstudiante; set => nombreEstudiante = value; }
        public string Carnet { get => carnet; set => carnet = value; }
        public string Nie { get => nie; set => nie = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Proyecto { get => proyecto; set => proyecto = value; }
        public int EspNivSec { get => espNivSec; set => espNivSec = value; }


        public int Especialidad { get => especialidad; set => especialidad = value; }
        public int NivelAcademico { get => nivelAcademico; set => nivelAcademico = value; }
        public int Seccion { get => seccion; set => seccion = value; }


        //Creeamos un metodo estatico de tipo DataTable para cargar los registros que están en la base de datos en una tabla 
        //Metodo Leer
        public static DataTable CargarEstudiantesPrimerAño()
        {
            //Creamso una variable de tipo SqlConnection y llamamos al metodo de la clase Conexion
            SqlConnection conexion = Conexion.Conectar();

            string consultaQuery = "select  carnet As [Carnet], nombreEstudiante As [Nombre],Especialidad.nombreEspecialidad As [Especialidad]," +
                "\r\nNivelAcademico.nombreNivel As [Nivel académico], Seccion.nombreSeccion As [Seccion], nie As [NIE], CASE estadoEstudiante" +
                "\r\nwhen 0 then 'ACTIVO'" +
                "\r\nwhen 1 then 'INACTIVO'" +
                "\r\nEND As [Estado],\r\nProyecto.nombreProyecto As [Proyecto], BitacoraSocial.registroHoras As [No. Horas]" +
                "\r\nfrom Estudiante " +
                "\r\nLEFT JOIN \r\nBitacoraSocial on BitacoraSocial.idEstudiante = Estudiante.idEstudiante" +
                "\r\nINNER JOIN\r\nProyecto on Estudiante.id_Proyecto = Proyecto.idProyecto" +
                "\r\nINNER JOIN\r\nEsp_Niv_Sec on Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec" +
                "\r\nINNER JOIN\r\nEspecialidad on Esp_Niv_Sec.id_Especialidad = Especialidad.idEspecialidad" +
                "\r\nINNER JOIN \r\nNivelAcademico on Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico" +
                "\r\nINNER JOIN \r\nSeccion on Esp_Niv_Sec.id_Seccion = Seccion.idSeccion where NivelAcademico.idNivelAcademico = 1" +
                "\r\nand estadoEstudiante = 0;";

            //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            //Creamos un objeto DataTable, una tabla donde se guardara la informacion
            DataTable dataVirtual = new DataTable();
            //Pasamos la informacion de adaptador a la tabla
            add.Fill(dataVirtual);

            return dataVirtual;
        }

        public static DataTable CargarEstudiantesSegundoAño()
        {
            //Creamos una variable de tipo SqlConnection y llamamos al metodo de la clase Conexion
            SqlConnection conexion = Conexion.Conectar();

            string consultaQuery = "select  carnet As [Carnet], nombreEstudiante As [Nombre],Especialidad.nombreEspecialidad As [Especialidad]," +
                "\r\nNivelAcademico.nombreNivel As [Nivel académico], Seccion.nombreSeccion As [Seccion], nie As [NIE], CASE estadoEstudiante" +
                "\r\nwhen 0 then 'ACTIVO'" +
                "\r\nwhen 1 then 'INACTIVO'" +
                "\r\nEND As [Estado],\r\nProyecto.nombreProyecto As [Proyecto], BitacoraSocial.registroHoras As [No. Horas]" +
                "\r\nfrom Estudiante " +
                "\r\nLEFT JOIN \r\nBitacoraSocial on BitacoraSocial.idEstudiante = Estudiante.idEstudiante" +
                "\r\nINNER JOIN\r\nProyecto on Estudiante.id_Proyecto = Proyecto.idProyecto" +
                "\r\nINNER JOIN\r\nEsp_Niv_Sec on Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec" +
                "\r\nINNER JOIN\r\nEspecialidad on Esp_Niv_Sec.id_Especialidad = Especialidad.idEspecialidad" +
                "\r\nINNER JOIN \r\nNivelAcademico on Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico" +
                "\r\nINNER JOIN \r\nSeccion on Esp_Niv_Sec.id_Seccion = Seccion.idSeccion where NivelAcademico.idNivelAcademico = 2" +
                "\r\nand estadoEstudiante = 0;";

            //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            //Creamos un objeto DataTable, una tabla donde se guardara la informacion
            DataTable dataVirtual = new DataTable();
            //Pasamos la informacion de adaptador a la tabla
            add.Fill(dataVirtual);

            return dataVirtual;
        }

        public static DataTable CargarEstudiantesTercerAño()
        {
            //Creamos una variable de tipo SqlConnection y llamamos al metodo de la clase Conexion
            SqlConnection conexion = Conexion.Conectar();

            string consultaQuery = "select  carnet As [Carnet], nombreEstudiante As [Nombre],Especialidad.nombreEspecialidad As [Especialidad]," +
                "\r\nNivelAcademico.nombreNivel As [Nivel académico], Seccion.nombreSeccion As [Seccion], nie As [NIE], CASE estadoEstudiante" +
                "\r\nwhen 0 then 'ACTIVO'" +
                "\r\nwhen 1 then 'INACTIVO'" +
                "\r\nEND As [Estado]," +
                "\r\nProyecto.nombreProyecto As [Proyecto], BitacoraSocial.registroHoras As [No. Horas]" +
                "\r\nfrom Estudiante " +
                "\r\nLEFT JOIN \r\nBitacoraSocial on BitacoraSocial.idEstudiante = Estudiante.idEstudiante" +
                "\r\nINNER JOIN\r\nProyecto on Estudiante.id_Proyecto = Proyecto.idProyecto" +
                "\r\nINNER JOIN\r\nEsp_Niv_Sec on Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec" +
                "\r\nINNER JOIN\r\nEspecialidad on Esp_Niv_Sec.id_Especialidad = Especialidad.idEspecialidad" +
                "\r\nINNER JOIN \r\nNivelAcademico on Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico" +
                "\r\nINNER JOIN \r\nSeccion on Esp_Niv_Sec.id_Seccion = Seccion.idSeccion where estadoEstudiante = 0 and idNivelAcademico = 3;";

            //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            //Creamos un objeto DataTable, una tabla donde se guardara la informacion
            DataTable dataVirtual = new DataTable();
            //Pasamos la informacion de adaptador a la tabla
            add.Fill(dataVirtual);

            return dataVirtual;
        }

        public static DataTable CargarEstudiantesRetirados()
        {
            //Creamso una variable de tipo SqlConnection y llamamos al metodo de la clase Conexion
            SqlConnection conexion = Conexion.Conectar();

            string consultaQuery = "select  carnet As [Carnet], nombreEstudiante As [Nombre],Especialidad.nombreEspecialidad As [Especialidad]," +
                "\r\nNivelAcademico.nombreNivel As [Nivel académico], Seccion.nombreSeccion As [Seccion], nie As [NIE], CASE estadoEstudiante" +
                "\r\nwhen 0 then 'ACTIVO'" +
                "\r\nwhen 1 then 'INACTIVO'" +
                "\r\nEND As [Estado],\r\nProyecto.nombreProyecto As [Proyecto], BitacoraSocial.registroHoras As [No. Horas]" +
                "\r\nfrom Estudiante " +
                "\r\nLEFT JOIN \r\nBitacoraSocial on BitacoraSocial.idEstudiante = Estudiante.idEstudiante" +
                "\r\nINNER JOIN\r\nProyecto on Estudiante.id_Proyecto = Proyecto.idProyecto" +
                "\r\nINNER JOIN\r\nEsp_Niv_Sec on Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec" +
                "\r\nINNER JOIN\r\nEspecialidad on Esp_Niv_Sec.id_Especialidad = Especialidad.idEspecialidad" +
                "\r\nINNER JOIN \r\nNivelAcademico on Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico" +
                "\r\nINNER JOIN \r\nSeccion on Esp_Niv_Sec.id_Seccion = Seccion.idSeccion where estadoEstudiante = 1;";

            //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            //Creamos un objeto DataTable, una tabla donde se guardara la informacion
            DataTable dataVirtual = new DataTable();
            //Pasamos la informacion de adaptador a la tabla
            add.Fill(dataVirtual);

            return dataVirtual;
        }

        //Metodo Insertar
        public bool InsertarEstudiantes()
        {
            EspNivSec = BuscarEspNivSec(especialidad, nivelAcademico, seccion);

            SqlConnection conexion = Conexion.Conectar();

            //Comando para insertar datos a Sql Server
            string consultaQuery = "insert into Estudiante( nombreEstudiante, carnet, nie, estadoEstudiante, id_Proyecto, id_EspNivSec)" +
                "values ( @nombreEstudiante, @carnet, @nie, @estadoEstudiante, @id_Proyecto, @id_EspNivSec);";

            //Creamos un objeto de tipo SqlCommand
            SqlCommand cmd = new SqlCommand(consultaQuery, conexion);

            //Sustituimos los valores temporales por los astributos
            cmd.Parameters.AddWithValue("@nombreEstudiante", nombreEstudiante);
            cmd.Parameters.AddWithValue("@carnet", carnet);
            cmd.Parameters.AddWithValue("@nie", nie);
            cmd.Parameters.AddWithValue("@estadoEstudiante", estado);
            cmd.Parameters.AddWithValue("@id_Proyecto", proyecto);
            cmd.Parameters.AddWithValue("@id_EspNivSec", EspNivSec);

            //Enviamos el comando a SqlServer
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Ingreso correcto");
                return true;
            }
            else
            {
                MessageBox.Show("Error");
                return false;
            }


        }

        public int BuscarEspNivSec(int especialidad, int nivelAcademico, int seccion)
        {
            int resultado = 0;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                string consultaQuery = "SELECT idEsp_Niv_Sec FROM Esp_Niv_Sec WHERE id_Especialidad = @esp AND id_NivelAcademico = @niv AND id_Seccion = @sec;";

                using (SqlCommand cmd = new SqlCommand(consultaQuery, conexion))
                {
                    cmd.Parameters.AddWithValue("@esp", especialidad);
                    cmd.Parameters.AddWithValue("@niv", nivelAcademico);
                    cmd.Parameters.AddWithValue("@sec", seccion);

                    object valor = cmd.ExecuteScalar();

                    if (valor != null && int.TryParse(valor.ToString(), out int id))
                    {
                        resultado = id;
                    }
                }
            }

            return resultado;
        }


    }


}

