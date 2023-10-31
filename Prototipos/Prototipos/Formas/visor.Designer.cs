
namespace Prototipos.Formas
{
    partial class visor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visor));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.Rotar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.imagencompleta = new System.Windows.Forms.Button();
            this.Acercarse = new System.Windows.Forms.Button();
            this.Zoomout = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Zoom = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.Button();
            this.Alejarse = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 435);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(4, 447);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ajustar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.showButton);
            this.flowLayoutPanel1.Controls.Add(this.clearButton);
            this.flowLayoutPanel1.Controls.Add(this.backgroundButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Controls.Add(this.Rotar);
            this.flowLayoutPanel1.Controls.Add(this.guardar);
            this.flowLayoutPanel1.Controls.Add(this.imagencompleta);
            this.flowLayoutPanel1.Controls.Add(this.Acercarse);
            this.flowLayoutPanel1.Controls.Add(this.Zoomout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(164, 447);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 103);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.AutoSize = true;
            this.showButton.Location = new System.Drawing.Point(703, 4);
            this.showButton.Margin = new System.Windows.Forms.Padding(4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(192, 33);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Mostrar una imagen";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(531, 4);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(164, 33);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Borrar la imagen";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.AutoSize = true;
            this.backgroundButton.Location = new System.Drawing.Point(263, 4);
            this.backgroundButton.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(260, 33);
            this.backgroundButton.TabIndex = 2;
            this.backgroundButton.Text = "Establecer el color de fondo";
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(155, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 33);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Cerrar";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Rotar
            // 
            this.Rotar.Location = new System.Drawing.Point(47, 4);
            this.Rotar.Margin = new System.Windows.Forms.Padding(4);
            this.Rotar.Name = "Rotar";
            this.Rotar.Size = new System.Drawing.Size(100, 28);
            this.Rotar.TabIndex = 4;
            this.Rotar.Text = "Rotar";
            this.Rotar.UseVisualStyleBackColor = true;
            this.Rotar.Click += new System.EventHandler(this.Rotar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(767, 45);
            this.guardar.Margin = new System.Windows.Forms.Padding(4);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(128, 28);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "Guardar imagen";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // imagencompleta
            // 
            this.imagencompleta.AutoSize = true;
            this.imagencompleta.Location = new System.Drawing.Point(625, 45);
            this.imagencompleta.Margin = new System.Windows.Forms.Padding(4);
            this.imagencompleta.Name = "imagencompleta";
            this.imagencompleta.Size = new System.Drawing.Size(134, 28);
            this.imagencompleta.TabIndex = 7;
            this.imagencompleta.Text = "Imagen completa";
            this.imagencompleta.UseVisualStyleBackColor = true;
            this.imagencompleta.Click += new System.EventHandler(this.imagencompleta_Click);
            // 
            // Acercarse
            // 
            this.Acercarse.AutoSize = true;
            this.Acercarse.Location = new System.Drawing.Point(512, 45);
            this.Acercarse.Margin = new System.Windows.Forms.Padding(4);
            this.Acercarse.Name = "Acercarse";
            this.Acercarse.Size = new System.Drawing.Size(105, 28);
            this.Acercarse.TabIndex = 9;
            this.Acercarse.Text = "Acercarse";
            this.Acercarse.UseVisualStyleBackColor = true;
            this.Acercarse.Click += new System.EventHandler(this.Acercarse_Click);
            // 
            // Zoomout
            // 
            this.Zoomout.AutoSize = true;
            this.Zoomout.Location = new System.Drawing.Point(399, 45);
            this.Zoomout.Margin = new System.Windows.Forms.Padding(4);
            this.Zoomout.Name = "Zoomout";
            this.Zoomout.Size = new System.Drawing.Size(105, 28);
            this.Zoomout.TabIndex = 8;
            this.Zoomout.Text = "Alejarse";
            this.Zoomout.UseVisualStyleBackColor = true;
            this.Zoomout.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // Zoom
            // 
            this.Zoom.Location = new System.Drawing.Point(543, 44);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(84, 23);
            this.Zoom.TabIndex = 7;
            this.Zoom.Text = "Zoom";
            this.Zoom.UseVisualStyleBackColor = true;
            this.Zoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(543, 44);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(84, 23);
            this.imagen.TabIndex = 7;
            this.imagen.Text = "Imagen completa";
            this.imagen.UseVisualStyleBackColor = true;
            this.imagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alejarse
            // 
            this.Alejarse.AutoSize = true;
            this.Alejarse.Location = new System.Drawing.Point(278, 45);
            this.Alejarse.Margin = new System.Windows.Forms.Padding(4);
            this.Alejarse.Name = "Alejarse";
            this.Alejarse.Size = new System.Drawing.Size(105, 28);
            this.Alejarse.TabIndex = 8;
            this.Alejarse.Text = "Alejarse";
            this.Alejarse.UseVisualStyleBackColor = true;
            this.Alejarse.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "visor";
            this.Text = "visor";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Rotar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button Zoom;
        private System.Windows.Forms.Button imagen;
        private System.Windows.Forms.Button imagencompleta;
        private System.Windows.Forms.Button Zoomout;
        private System.Windows.Forms.Button Alejarse;
        private System.Windows.Forms.Button Acercarse;
    }
}