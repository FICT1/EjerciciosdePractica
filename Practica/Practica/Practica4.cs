using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    

    public partial class Practica4 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        public Practica4()
        {
            InitializeComponent();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Practica3 f3 = new Practica3();
            f3.Show();
            this.Hide();
        }

        private void Practica4_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarEstudiantes_Click(object sender, EventArgs e)
        {
            estudiantes.Clear();

            estudiantes.Add(new Estudiante { Id = 100, Nombre = "Carlos" });
            estudiantes.Add(new Estudiante { Id = 220, Nombre = "Ana" });
            estudiantes.Add(new Estudiante { Id = 311, Nombre = "Luis" });
            estudiantes.Add(new Estudiante { Id = 214, Nombre = "Maria" });
            estudiantes.Add(new Estudiante { Id = 590, Nombre = "Pedro" });
            estudiantes.Add(new Estudiante { Id = 677, Nombre = "Jose" });
            estudiantes.Add(new Estudiante { Id = 234, Nombre = "Sofia" });
            estudiantes.Add(new Estudiante { Id = 432, Nombre = "Diana" });
            estudiantes.Add(new Estudiante { Id = 211, Nombre = "Ricardo" });
            estudiantes.Add(new Estudiante { Id = 987, Nombre = "Valeria" });

            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = estudiantes;
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbBuscarID.Text, out int idBuscado))
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }

            Estudiante encontrado = null;

           
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Id == idBuscado)
                {
                    encontrado = estudiantes[i];
                    break;
                }
            }

            if (encontrado != null)
            {
                MessageBox.Show("Estudiante encontrado: " + encontrado.Nombre);
            }
            else
            {
                MessageBox.Show("No existe estudiante con ese ID");
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs f)
        {
            string nombreBuscado = tbBuscarNombre.Text.ToLower();

            estudiantes = estudiantes.OrderBy(e => e.Nombre).ToList();

            int inicio = 0;
            int fin = estudiantes.Count - 1;
            bool encontrado = false;

            while (inicio <= fin)
            {
                int mitad = (inicio + fin) / 2;
                string nombreMitad = estudiantes[mitad].Nombre.ToLower();

                if (nombreMitad == nombreBuscado)
                {
                    MessageBox.Show("Estudiante encontrado: ID " + estudiantes[mitad].Id);
                    encontrado = true;
                    break;
                }
                else if (nombreBuscado.CompareTo(nombreMitad) < 0)
                {
                    fin = mitad - 1;
                }
                else
                {
                    inicio = mitad + 1;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró el estudiante");
            }
        }


    }
}
