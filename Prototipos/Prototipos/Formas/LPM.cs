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
    public partial class LPM : Form
    {
        public LPM()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double edad = Convert.ToDouble(textBox1.Text);

                if (edad < 0)
                {
                    MessageBox.Show("Ingresa valores positivos.");
                }
                else
                {
                    double fcm = (220 - edad);
                    textBox2.Text = ($"{fcm}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ingresa un valor de tipo numerico");
            }
        }
    }
    
}
