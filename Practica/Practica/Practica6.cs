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
    }
}
