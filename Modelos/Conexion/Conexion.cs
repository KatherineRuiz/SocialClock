using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Modelos
{
    public class Conexion
    {
        private static string servidor = "DESKTOP-V2L6QH5\\SQLEXPRESS";
        private static string baseDeDatos = "SocialClock";

        public static SqlConnection Conectar()
        {
            //creamos una cadena de conexion
            string cadena =
                $"Data Source = {servidor},54321;Initial Catalog = {baseDeDatos};Integrated Security = true;";

            //Creamos un objeto de tipo SqlConnection
            SqlConnection con = new SqlConnection(cadena);

            //Abrimos la conexion entre SQL Server y nuestra aplicacion
            con.Open();
            return con;
        }

    }
}
