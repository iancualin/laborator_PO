using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator1
{
    class Program
    {
        static void Main(string[] args)
        {
            point p = new point(5,6);
            point x = new point(0, 4);
            point y = new point(0, 0);
            point m = new point(3, 0);
            p.rotate(90);
            triughi z = new triughi(x,y,m);
            z.perimetru();
            z.arie();

        }

       
    }
}
//o clasa point
//o clasa triunghi parametrii 3 pct 