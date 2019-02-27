using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laborator1
{
    internal class point
    {
        double x, y;

        public point(double a, double b)
        {
            x = a;
            y = b;
        }
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public point()
            {
            x = 0;
            y = 0;
            }
        public void  rotate (double t )
        {
            double x0, y0;
            t = t * Math.PI / 180; 
            x0 = x;
            y0 = y;
            x = x0 * Math.Cos(t) - y0 * Math.Sin(t);
            y = y0 * Math.Cos(t) + x0 * Math.Sin(t);
            Console.WriteLine("rotatia {0},{1}", x, y);
        }

        public static implicit operator point(double v)
        {
            throw new NotImplementedException();
        }
    }
}
//