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

            estudiantes.Add(new Estudiante { Id = 1, Nombre = "Carlos" });
            estudiantes.Add(new Estudiante { Id = 2, Nombre = "Ana" });
            estudiantes.Add(new Estudiante { Id = 3, Nombre = "Luis" });
            estudiantes.Add(new Estudiante { Id = 4, Nombre = "Maria" });
            estudiantes.Add(new Estudiante { Id = 5, Nombre = "Pedro" });
            estudiantes.Add(new Estudiante { Id = 6, Nombre = "Jose" });
            estudiantes.Add(new Estudiante { Id = 7, Nombre = "Sofia" });
            estudiantes.Add(new Estudiante { Id = 8, Nombre = "Diana" });
            estudiantes.Add(new Estudiante { Id = 9, Nombre = "Ricardo" });
            estudiantes.Add(new Estudiante { Id = 10, Nombre = "Valeria" });

            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = estudiantes;
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
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

    }
}
