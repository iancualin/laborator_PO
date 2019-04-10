using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray ma = new MyArray(100);
            for(int i=0;i<10;i++)
            {
                ma.Add(i * i);
            }
            ma[3] += 5;

            Console.WriteLine(ma);
            //elimina toate aparitiile argumentului din vector
           // ma.Remove(14);
           

        }
    }
}
