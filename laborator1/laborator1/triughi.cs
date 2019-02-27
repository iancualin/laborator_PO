using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laborator1
{
    internal class triughi
    {
        point p1, p2, p3;
        
        
       
        
       
        public triughi (point p1,point p2,point p3)
        {
            this.p1=p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public void perimetru()
        {
            double l1, l2, l3;
            l1 = Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            l2 = Math.Sqrt((p3.X - p2.X) * (p3.X - p2.X) + (p3.Y - p2.Y) * (p3.Y - p2.Y));
            l3 = Math.Sqrt((p1.X - p3.X) * (p1.X - p3.X) + (p1.Y - p3.Y) * (p1.Y - p3.Y));
            double p;
            p = l1 + l2 + l3;
            Console.WriteLine("perimetrul este :{0}", p);
        }
        public void arie()
        {
            double a;
            a = p1.X * p2.Y + p2.X * p3.Y + p1.Y * p3.X - p2.Y * p3.X - p1.Y * p2.X - p1.X * p3.Y;
            if (a < 0)
                a = a * (-1);
            a = a / 2;
            Console.WriteLine("aria este :{0}", a);
        }
    }
}