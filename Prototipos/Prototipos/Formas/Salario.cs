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
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
        }
        private void Salario_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double salario_actual = Convert.ToDouble(textBox1.Text);

                if (salario_actual < 0)
                {
                    MessageBox.Show("Ingresa valores positivos.");
                }
                else
                {
                    double calcular = (salario_actual * 25 / 100);
                    double resultado = (salario_actual + calcular);
                    textBox2.Text = ($"{resultado}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ingresa un valor de tipo numerico");
            }
        }
    }
    
}
