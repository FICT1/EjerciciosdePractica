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

    }
}
