using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ejercicio 3: Búsqueda de texto dentro de una cadena
//Crear un método que:
//• Reciba un párrafo y una palabra.
//• Devuelva cuántas veces aparece la palabra.
//• No diferencie mayúsculas y minúsculas.
//• No utilice métodos como Contains ni IndexOf, sino una búsqueda manual carácter por
//carácter.


namespace Practica
{
    public partial class Practica3 : Form
    {
        public Practica3()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarTexto_Click(object sender, EventArgs e)
        {
            string texto = tbParrafo.Text.ToLower();
            string palabra = tbPalabra.Text.ToLower();



        }
    }
}
