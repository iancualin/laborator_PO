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
            get;
        }
        public double Y
        {
            get;
        }
        public point()
            {
            x = 0;
            y = 0;
            }
        public void  rotate (int t )
        {
            double x0, y0;
            t = t * Math.PI / 180; 
            x0 = x;
            y0 = y;
            x = x0 * Math.Cos(t) - y0 * Math.Asin(t);
            y = y0 * Math.Cos(t) + x0 * Math.Asin(t);
        }

    }
}
//