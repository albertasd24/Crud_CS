using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_C_.Clases
{
    internal class Conexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "escuela";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";

        static string uri_conexion = $"server={servidor};port={puerto};user id={usuario};password={password};database={bd};port={puerto}";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = uri_conexion;
                conex.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Conexión no exitosa a la base de datos. {e.ToString()}");
            }
            return conex;
        }

        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
