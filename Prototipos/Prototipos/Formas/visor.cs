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
    public partial class visor : Form
    {
        public visor()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void Rotar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Invalidate();
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    pictureBox1.Image.Save(filePath);
                }
            }
        }

        private void recortar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private Form pantallaCompletaForm;
        private void imagencompleta_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (pantallaCompletaForm == null)
                {
                    pantallaCompletaForm = new Form();
                    pantallaCompletaForm.FormBorderStyle = FormBorderStyle.None; 
                    pantallaCompletaForm.WindowState = FormWindowState.Maximized;
                    pantallaCompletaForm.BackColor = Color.Black; 

                    PictureBox pictureBoxPantallaCompleta = new PictureBox();
                    pictureBoxPantallaCompleta.Dock = DockStyle.Fill; 
                    pictureBoxPantallaCompleta.Image = pictureBox1.Image;
                    pictureBoxPantallaCompleta.SizeMode = PictureBoxSizeMode.Zoom;

                    pantallaCompletaForm.Controls.Add(pictureBoxPantallaCompleta);
                    pantallaCompletaForm.KeyDown += PantallaCompletaForm_KeyDown; 
                }

                pantallaCompletaForm.Show();
            }
        }
        private void PantallaCompletaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pantallaCompletaForm.Hide(); 
            }
        }

        private List<string> imagenes = new List<string> { "imagen1.jpg", "imagen2.jpg", "imagen3.jpg" };
        private int indiceImagenActual = 0;

        private void MostrarImagenActual()
        {
            if (indiceImagenActual >= 0 && indiceImagenActual < imagenes.Count)
            {
                pictureBox1.Image = Image.FromFile(imagenes[indiceImagenActual]);
            }
        }

        private double factorZoom = 1.0;
        private void siguiente_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                factorZoom /= 1.2; // Reduce el factor de zoom en un 20%.
                AplicarZoom();
            }

        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            indiceImagenActual = (indiceImagenActual - 1 + imagenes.Count) % imagenes.Count;
            MostrarImagenActual();
        }
        private void AplicarEspejoHorizontal()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Invalidate();
            }
        }

        private void Acercarse_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                factorZoom *= 1.2; // Aumenta el factor de zoom en un 20%.
                AplicarZoom();
            }
        }

        private void AplicarZoom()
        {
            if (pictureBox1.Image != null)
            {
                int nuevaAnchura = (int)(pictureBox1.Image.Width * factorZoom);
                int nuevaAltura = (int)(pictureBox1.Image.Height * factorZoom);

                // Crea una nueva imagen con el tamaño ajustado.
                Bitmap imagenZoom = new Bitmap(pictureBox1.Image, nuevaAnchura, nuevaAltura);

                // Muestra la nueva imagen en el PictureBox.
                pictureBox1.Image = imagenZoom;
            }
        }
    }
}
