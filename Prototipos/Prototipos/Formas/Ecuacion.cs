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
    public partial class Ecuacion : Form
    {
        public Ecuacion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double calcular = b * b - 4 * a * c;

                if (a == 0)
                {
                    MessageBox.Show("Error: 'a' no puede ser cero. Intente de nuevo.");
                }
                if (b == 0)
                {
                    MessageBox.Show("Error: 'b' no puede ser cero. Intente de nuevo.");
                }
                if (c == 0)
                {
                    MessageBox.Show("Error: 'c' no puede ser cero. Intente de nuevo.");
                }
                else if (calcular > 0)
                {
                    double x1 = (-b + Math.Sqrt(calcular)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(calcular)) / (2 * a);
                    textBox4.Text = ($"{x1}");
                    textBox5.Text = ($"{x2}");
                }
                else if (calcular == 0)
                {
                    double x = -b / (2 * a);
                    MessageBox.Show("La raíz real doble es: x = " + x);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un valor de tipo numérico.");
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
