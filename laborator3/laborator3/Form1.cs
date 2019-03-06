using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborator3
{
    public partial class Form1 : Form
    {
        public List<NumericUpDown> pointValues = new List<NumericUpDown>(); 
        public Form1()
        {
            InitializeComponent();
            pointValues.Add(numericUpDown1);
            pointValues.Add(numericUpDown2);
            pointValues.Add(numericUpDown3);
            pointValues.Add(numericUpDown4);
            pointValues.Add(numericUpDown5);
            pointValues.Add(numericUpDown6);
            pointValues.Add(numericUpDown7);
            pointValues.Add(numericUpDown8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawCircleOnCenter(float coordX, float coordY, Graphics g, float radius)
        {
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, coordX - radius, coordY - radius,
              radius + radius, radius + radius);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = new Bitmap(776, 426);
            Graphics g = Graphics.FromImage(this.pictureBox1.Image);
            List<Point> points = new List<Point>();
            List<Tuple<float, float>> functions = new List<Tuple<float, float>>();
            int currentPoint = 0;
            for (int i = 0; i < 8; i = i+2)
            {
                
                Point point = new Point((int)pointValues[i].Value, (int)pointValues[i+1].Value);
                points.Add(point);

                if (currentPoint == 1 || currentPoint == 3)
                {
                    g.DrawLine(new Pen(Color.Black), points[currentPoint - 1], points[currentPoint]);
                    float a = (float)(points[currentPoint - 1].Y - points[currentPoint].Y) / (float)(points[currentPoint - 1].X - points[currentPoint].X);
                    float b = (float)points[currentPoint - 1].Y - (a * (float)points[currentPoint - 1].X);
                    functions.Add(new Tuple<float, float>(a, b));
                }
                ++currentPoint;
            }
            float intersectionX = (functions[1].Item2 - functions[0].Item2) / (functions[0].Item1 - functions[1].Item1);
            float intersectionY = functions[0].Item1 * intersectionX + functions[0].Item2;
            DrawCircleOnCenter(intersectionX, intersectionY, g, 5f);
        }
    }
}
