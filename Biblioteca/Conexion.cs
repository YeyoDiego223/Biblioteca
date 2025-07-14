using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Biblioteca
{
    internal class Conexion
    {
        private static string cadenaConexion = "Server=DIEGOFG\\SQLEXPRESS;Database:BDBIBLIOTECA;Trusted_Connection=True;";
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            return conexion;
        }
    }
}
