using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorsComp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadVector(out int[] v1);           
            Console.WriteLine("Norma vectorului este: "+ Norma(v1));
            ReadVector(out int[] v2);
            Console.WriteLine("Produsul scalar al celor 2 vectori este: " + ProdScalar(v1, v2));
            Console.WriteLine("Produsul vectorial al celor 2 vectori este: " + ProdVectorial(v1, v2));
            Console.WriteLine("Aria paralelogramului este: " + Arie(v1, v2));
            ReadVector(out int[] v3);
            Console.WriteLine("Produsul mixt este: " + ProdMixt(v1, v2));
        }

        private static string ProdMixt(int[] v1, int[] v2)
        {
            throw new NotImplementedException();
        }

        private static double Arie(int[] v1, int[] v2)
        {
            int iSum = v1[1] * v2[2] - v1[2] * v2[1];
            int jSum = v1[0] * v2[2] - v1[2] * v2[0];
            int kSum = v1[0] * v2[1] - v1[1] * v2[0];
            int[] vf = new int[3];
            vf[0] = iSum;
            vf[1] = jSum;
            vf[2] = kSum;
            return Norma(vf);
        }

        private static string ProdVectorial(int[] v1, int[] v2)
        {
            int iSum = v1[1]*v2[2] - v1[2] * v2[1];
            int jSum = v1[0] * v2[2] - v1[2] * v2[0];
            int kSum = v1[0] * v2[1] - v1[1] * v2[0];
            return SwapToString(iSum) + "i" + SwapToString(jSum) + "j" + SwapToString(kSum) + "k";
        }

        private static string SwapToString(int nb)
        {
            if (nb < 0)
            return nb.ToString();            
            return "+" + nb.ToString();
        }

        private static int ProdScalar(int[] v1, int[] v2)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
                sum += v1[i] * v2[i];
            return sum;
        }

        private static double Norma(int[] v)
        {
            return Math.Sqrt(v[0] * v[0] + v[1] * v[1] + v[2] * v[2]);
        }

        private static void ReadVector(out int[] vector)
        {
            vector = new int[3];
            Console.WriteLine("Introduceti cei 3 scalari:");
            for (int i = 0; i < 3; i++)
                vector[i] = int.Parse(Console.ReadLine());
        }
    }
}
