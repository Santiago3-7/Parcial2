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
    public partial class Dinero : Form
    {
        public Dinero()
        {
            InitializeComponent();
        }
        private void Dinero_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pesos = Convert.ToDouble(textBox1.Text);

                if (pesos < 0)
                {
                    MessageBox.Show("Ingresa valores positivos.");
                }
                else
                {
                    double dolares_resultado = (pesos / 2 / 17.41);
                    textBox2.Text = ($"{dolares_resultado}");
                    double euros_resultado = (pesos / 2 / 18.40);
                    textBox3.Text = ($"{euros_resultado}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ingresa un valor de tipo numerico");
            }
        }
    }
    
}
