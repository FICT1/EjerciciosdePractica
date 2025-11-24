using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ejercicio 1: Búsqueda lineal en un arreglo
//Crear un programa que:
//• Genere un arreglo de 20 números enteros aleatorios.
//• Solicite un número al usuario.
//• Implemente una búsqueda lineal para determinar si el número existe en el arreglo.
//• Muestre la posición o un mensaje indicando que no existe.

namespace Practica
{
    
    public partial class Form1 : Form
    {
        int[] arreglo = new int[20];
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rand.Next(1, 101); 
            }


        }

        private void lblNumeroAleatorio_Click(object sender, EventArgs e)
        {
           lblNumeroAleatorio.Text = string.Join(", ", arreglo);
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tbBusqueda.Text);
            if (int.TryParse(tbBusqueda.Text, out int numer)
)
            {

                int pos = -1;

                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i] == num)
                    {
                        pos = i;
                        break;
                    }
                }

                if (pos != -1)
                {
                    MessageBox.Show("El número está en la posición: " + pos);
                    tbBusqueda.Clear();
                }
                else
                {
                    MessageBox.Show("El número no existe en el arreglo.");
                    tbBusqueda.Clear();
                }
            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Practica2 f2 = new Practica2();
            f2.Show();
            this.Hide();
        }
    }
}

