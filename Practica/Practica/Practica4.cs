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

    }
}
