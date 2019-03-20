using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex(4);
            Complex c3 = new Complex(4,5);
            Complex c4 = new Complex();
            c1.Print();
            c2.Print();
            c3.Print();
            c4.Print();
            Console.Read();
        }
    }
}
