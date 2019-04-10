using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Numerics;

namespace Huge
{
    class Program
    {
        static void Main(string[] args)
        {
            Huge h1 = new Huge(123456789);
            Console.WriteLine(h1);
            Huge h2 = new Huge("8888");
            Huge h3 = new Huge("8888");

            Console.WriteLine(h2);
            Console.WriteLine(h3);
            Huge sum = h2 + h3;

            Console.WriteLine(sum);

            Huge product = h2 * h3;
            Console.WriteLine("produsul este :");
            Console.WriteLine(product);

            //Huge h4 = h2 + 1234567;

            //Huge h5 = h1.Power(10);

            //Console.WriteLine(h5);

            //int mod = h4 % 1234564;

            // Console.WriteLine(h5);

            //BigInteger big = new BigInteger();

        }
    }
}
//un tip abstract de date cu numele huge care implementeaza conceptul unui nr mare