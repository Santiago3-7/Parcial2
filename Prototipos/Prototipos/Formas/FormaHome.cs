using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototipos.Formas; 

namespace Prototipos.Formas
{
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangulo Triangulo = new Triangulo();
            Triangulo.Show();
        }

        private void dineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dinero Dinero = new Dinero();
            Dinero.Show();
        }

        private void lPMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LPM LPM = new LPM();
            LPM.Show();
        }

        private void salarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salario Salario = new Salario();
            Salario.Show();
        }

        private void ecuacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ecuacion Ecuacion = new Ecuacion();
            Ecuacion.Show();
        }

        private void tutorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void visorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visor2 visor2 = new visor2();
            visor2.Show();
        }

        private void FormaHome_Load(object sender, EventArgs e)
        {

        }

        private void pruebaMatemáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pruebamate pruebamate = new pruebamate();
            pruebamate.Show();
        }

        private void juegoAdivinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            juego juego = new juego();
            juego.Show();
        }
    }
}
