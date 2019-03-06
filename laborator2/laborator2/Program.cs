using System;

namespace laborator2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[,] mat = GenMat(3, 3);
            ShowMat(mat, 3, 3);
            ParcurgereSpirala(mat, 3, 3);
            Console.ReadKey();
        }

        static void ParcurgereSpirala(int[,] a, int endRowIndex, int endColumnIndex)
        {
            int i, startRowIndex = 0, startColumnIndex = 0;

            while (startRowIndex < endRowIndex && startColumnIndex < endColumnIndex)
            {

                for (i = startColumnIndex; i < endColumnIndex; ++i)
                {
                    Console.Write(a[startRowIndex, i] + " ");
                }
                startRowIndex++;

                for (i = startRowIndex; i < endRowIndex; ++i)
                {
                    Console.Write(a[i, endColumnIndex - 1] + " ");
                }
                endColumnIndex--;
                

                if (startRowIndex < endRowIndex)
                {
                    for (i = endColumnIndex - 1; i >= startColumnIndex; --i)
                    {
                        Console.Write(a[endRowIndex - 1, i] + " ");
                    }
                    endRowIndex--;
                }

                if (startColumnIndex < endColumnIndex)
                {
                    for (i = endRowIndex - 1; i >= startRowIndex; --i)
                    {
                        Console.Write(a[i, startColumnIndex] + " ");
                    }
                    startColumnIndex++;
                }
            }
        }

        static void ShowMat(int[,] mat, int m, int n)
        {
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("{0} ", mat[i, j]);
                }
                Console.WriteLine('\n');
            }
        }

        static int[,] GenMat(int m, int n)
        {
            int[,] mat = new int[m, n];
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    mat[i, j] = rnd.Next(0, 101);
                }
            }
            return mat;
        }
    }
}
