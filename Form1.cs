using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.Alumnos objetoAlumons = new Clases.Alumnos();
            objetoAlumons.mostrarAlumnos(dataTotalAlumnos);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.Alumnos objetoAlumons = new Clases.Alumnos();
            objetoAlumons.eliminarAlumno(txtId);
            objetoAlumons.mostrarAlumnos(dataTotalAlumnos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Alumnos objetoAlumons = new Clases.Alumnos();
            objetoAlumons.guardarAlumno(txtNombres.Text, txtApellidos.Text);
            objetoAlumons.mostrarAlumnos(dataTotalAlumnos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Clases.Alumnos objetoAlumons = new Clases.Alumnos();
            objetoAlumons.modificarAlumno(txtId, txtNombres, txtApellidos);
            objetoAlumons.mostrarAlumnos(dataTotalAlumnos);
            objetoAlumons.seleccionarAlumno(dataTotalAlumnos, txtId, txtNombres, txtApellidos);
        }

        private void dataTotalAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.Alumnos objetoAlumons = new Clases.Alumnos();
            objetoAlumons.seleccionarAlumno(dataTotalAlumnos, txtId, txtNombres, txtApellidos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
