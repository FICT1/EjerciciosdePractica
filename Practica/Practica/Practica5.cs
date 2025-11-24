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
    public partial class Practica5 : Form
    {
        int[] numeros = new int[15];
        Random rand = new Random();

        public Practica5()
        {
            InitializeComponent();
        }

        private void Practica5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rand.Next(1, 101);
            }

            lblNumeros.Text = string.Join(", ", numeros);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int max = numeros[0];
            int min = numeros[0];
            int iteraciones = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                iteraciones++;

                if (numeros[i] > max)
                {
                    max = numeros[i];
                }

                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }

            lblResultado.Text =
                "Máximo: " + max +
                "\nMínimo: " + min +
                "\nIteraciones: " + iteraciones;
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Practica6 f4 = new Practica6();
            f4.Show();
            this.Hide();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Practica4 f2 = new Practica4();
            f2.Show();
            this.Hide();
        }
    }
}
