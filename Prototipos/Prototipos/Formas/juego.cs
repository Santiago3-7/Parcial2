using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipos.Formas
{
    public partial class juego : Form
    {
        public juego()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adivina adivina = new adivina();
            adivina.Show();
        }
    }
}
