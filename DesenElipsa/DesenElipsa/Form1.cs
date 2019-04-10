using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesenElipsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            graphics = Graphics.FromImage(pictureBox1.Image);
        }

        Graphics graphics;
        Bitmap bitmap;
        Random random;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            random = new Random();
            Pen pen = new Pen(Color.Red, 5);
            graphics.DrawEllipse(pen, 160, 100, 150, 250);
            pen.Color = Color.Blue;
            for (int i = 0; i < 100; i++)
            {
                Brush brush = new SolidBrush(Color.Blue);
                //int pointVal = ChooseCoord(170, 290,i);
                graphics.FillEllipse(brush, ChooseCoord(160, 300, i), ChooseCoord(170, 290, i), 2, 2);
            }
            for (int i = 0; i < 100; i++)
            {
                Brush brush = new SolidBrush(Color.Blue);
                //int pointVal = ChooseCoord(170, 290,i);
                graphics.FillEllipse(brush, ChooseCoord(190, 270, i), ChooseCoord(120, 200, i), 2, 2);
            }
            for (int i = 0; i < 100; i++)
            {
                Brush brush = new SolidBrush(Color.Blue);
                //int pointVal = ChooseCoord(170, 290,i);
                graphics.FillEllipse(brush, ChooseCoord(200, 280, i), ChooseCoord(170, 340, i), 2, 2);
            }
            pictureBox1.Image = bitmap;
        }

        private int ChooseCoord(int bound1, int bound2, int count)
        {                   
            return random.Next(bound1, bound2);
        }
    }
}
