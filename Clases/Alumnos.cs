using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_C_.Clases
{
    internal class Alumnos
    {


        public void mostrarAlumnos(DataGridView tablaAlumnos)
        {
            try
            {
                Conexion conObject = new Conexion();
                tablaAlumnos.DataSource = null;
                String query = "SELECT * FROM alumnos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conObject.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlumnos.DataSource = dt;
                conObject.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron mostrar datos, {ex.ToString()}");
            }
        }

        public void guardarAlumno(String nombres, String apellidos)
        {
            try
            {
                Conexion conObject = new Conexion();
                Console.Write(nombres);
                String query = $"INSERT INTO alumnos (nombres, apellidos) VALUES ('{nombres}','{apellidos}');";
                MySqlCommand commandSql = new MySqlCommand(query, conObject.establecerConexion());
                MySqlDataReader reader = commandSql.ExecuteReader();

                MessageBox.Show("Información guardada de forma exitosa");
                while (reader.Read())
                {

                }
                conObject.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron mostrar datos, {ex.ToString()}");
            }
        }

        public void seleccionarAlumno(DataGridView tabla, TextBox id, TextBox nombres, TextBox apellidos)
        {
            try
            {
                id.Text = tabla.CurrentRow.Cells[0].Value.ToString();
                nombres.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                apellidos.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                Console.WriteLine($"{nombres.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron mostrar datos, {ex.ToString()}");
            }
        }

        public void modificarAlumno(TextBox id, TextBox nombres, TextBox apellidos)
        {
            try
            {
                Conexion conObject = new Conexion();
                Console.Write(nombres);
                String query = $"UPDATE alumnos SET nombres='{nombres.Text}', apellidos='{apellidos.Text}' WHERE id={id.Text};";
                MySqlCommand commandSql = new MySqlCommand(query, conObject.establecerConexion());
                MySqlDataReader reader = commandSql.ExecuteReader();

                MessageBox.Show("Información actualizada de forma exitosa");
                while (reader.Read())
                {

                }
                conObject.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron actualizar datos, {ex.ToString()}");
            }
        }

        public void eliminarAlumno(TextBox id)
        {
            try
            {
                Conexion conObject = new Conexion();
                String query = $"DELETE FROM alumnos WHERE id={id.Text};";
                MySqlCommand commandSql = new MySqlCommand(query, conObject.establecerConexion());
                MySqlDataReader reader = commandSql.ExecuteReader();

                MessageBox.Show("Estudiante eliminado");
                while (reader.Read())
                {

                }
                conObject.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron actualizar datos, {ex.ToString()}");
            }
        }

    }
}
