using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
       /// <summary>
       /// Constructor de la clase Pictures, inicializa componentes.
       /// </summary>
        
        public Form1()
        {
            int number;
            number = 10;
            number = number - 5;
            number = number * 3;
                           
            InitializeComponent();
            //this.Text = number.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }

        }

        /// <summary>
        /// Resumen de lo que hace
        /// </summary>
        /// <param name="sender">Alguna info</param>
        /// <param name="e">Alguna info</param>
        
        private void showimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                //Carga la imagen al picture box
                pictureBox1.Load(openFileDialog1.FileName);
            }
           ;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void deleteimage_Click(object sender, EventArgs e)
        {
            //Clear the picture.
            pictureBox1.Image = null;
        }
    }
}
