using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace EstructuraEstudiantes2
{
    public partial class Form1 : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
        }
      

        
        private void ActualizarListaEstudiantes()
        {
            listBoxEstudiantes.Items.Clear();

            foreach (Estudiante estudiante in estudiantes)
            {
                listBoxEstudiantes.Items.Add($"{estudiante.Nombre} {estudiante.Apellido}");
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.Correo = txtCorreo.Text;
            estudiante.Nota1 = Convert.ToDouble(txtNota1.Text);
            estudiante.Nota2 = Convert.ToDouble(txtNota2.Text);
            estudiante.Nota3 = Convert.ToDouble(txtNota3.Text);

            estudiantes.Add(estudiante);

            ActualizarListaEstudiantes();
            LimpiarCampos();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnVerDetalles_Click_1(object sender, EventArgs e)
        {
            {
                if (listBoxEstudiantes.SelectedIndex != -1)
                {
                    int indiceSeleccionado = listBoxEstudiantes.SelectedIndex;

                    Estudiante estudianteSeleccionado = estudiantes[indiceSeleccionado];

                    txtNombre.Text = estudianteSeleccionado.Nombre;
                    txtApellido.Text = estudianteSeleccionado.Apellido;
                    txtCorreo.Text = estudianteSeleccionado.Correo;
                    txtNota1.Text = estudianteSeleccionado.Nota1.ToString();
                    txtNota2.Text = estudianteSeleccionado.Nota2.ToString();
                    txtNota3.Text = estudianteSeleccionado.Nota3.ToString();
                    txtNotaDefinitiva.Text = estudianteSeleccionado.NotaDefinitiva.ToString();

                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNotaDefinitiva.Clear();
        }
    }

    public class Estudiante
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double NotaDefinitiva => (Nota1 + Nota2 + Nota3) / 3.0;
    }
}

