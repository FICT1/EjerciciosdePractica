using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Ejercicio 2: Búsqueda binaria en una lista ordenada
//Crear un programa que:
//• Genere una lista de 30 números aleatorios.
//• Ordene la lista con Array.Sort() o List.Sort().
//• Implemente búsqueda binaria manual (sin BinarySearch).
//• Muestre el proceso paso a paso (mitad actual, sub-lista, etc.).

namespace Practica
{
    public partial class Practica2 : Form
    {
        int[] lista = new int[30];
        Random rand2 = new Random();

        public Practica2()
        {
            InitializeComponent();
        }

        private void lblListaOrdenada_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            for (int i = 0; < lista.Length; i++)
            {
                lista[i] = rand2.Next(1, 101);
            }
            Array.Sort(lista);
            lblListaOrdenada.Text = string.Join(", ", lista);
        }


    }
}
