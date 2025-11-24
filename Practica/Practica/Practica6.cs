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
    public partial class Practica6 : Form
    {
        int[,] matriz = new int[10, 10];
        Random rand = new Random();

        public Practica6()
        {
            InitializeComponent();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Practica5 f2 = new Practica5();
            f2.Show();
            this.Hide();
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            dgvMatriz.ColumnCount = 10;
            dgvMatriz.RowCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                    dgvMatriz.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }

        private void btnBuscarNumero_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbBuscarNumero.Text, out int buscado))
            {
                MessageBox.Show("Ingrese un número válido");
                return;
            }

            bool encontrado = false;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] == buscado)
                    {
                        lblResultado.Text = $"Número encontrado en Fila: {i} Columna: {j}";
                        encontrado = true;
                        return;
                    }
                }
            }

            if (!encontrado)
            {
                lblResultado.Text = "Número no encontrado en la matriz";
            }
        }

    }
}
