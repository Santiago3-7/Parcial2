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
    public partial class Triangulo : Form
    {
        public Triangulo()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = Convert.ToDouble(textBox1.Text);
                double basee = Convert.ToDouble(textBox2.Text);

                if (altura < 0 || basee < 0)
                {
                    MessageBox.Show("Ingresa valores positivos.");
                }
                else
                {
                    double area_Triangulo = (altura * basee) / 2;
                    textBox3.Text = area_Triangulo.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un valor de tipo numérico.");
            }

        }

        private void Triangulo_Load(object sender, EventArgs e)
        {

        }
    }
    
}
