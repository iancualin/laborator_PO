using System;

namespace laborator4
{
    public class Fractie
    {
       
        private int numarator;
        private int numitor;
        private int v1;
        private int v2;
        private string v;

        public Fractie()
        {
            numarator = 0;
            numitor = 1;

        }

        public Fractie(string v)
        {
            string[] tokens = v.Split('/');
            int numarator, numitor;

            if(tokens.Length!=2)
            {
                
                this.numarator = 0;
                this.numitor = 1;
            }
            else
            {
                bool r1 = int.TryParse(tokens[0], out numarator);
                bool r2 = int.TryParse(tokens[1], out numitor);
                if(r1 && r2)
                {
                    int d;
                    d = Util.gcd(numarator, numitor);
                    this.numarator = numarator / d;
                    this.numitor = numitor / d;
                }
                else
                {
                    this.numarator = 0;
                    this.numitor = 1;
                }

            }
        }

        public Fractie Divide(Fractie right)
        {
            int r_numarator, r_numitor;
            r_numarator = numarator * right.numitor;
            r_numitor = numitor * right.numarator;
            return new Fractie(r_numarator, r_numitor);

        }

        public Fractie Subtract(Fractie right)
        {
            int r_numarator, r_numitor;
            r_numitor = numitor * right.numitor;
            r_numarator = numarator * right.numitor - numitor * right.numarator;
            return new Fractie(r_numarator, r_numitor);
        }

        public Fractie Multiply(Fractie right)
        {
            int r_numarator, r_numitor;
            r_numarator = numarator * right.numarator;
            r_numitor = numitor * right.numitor;
            return new Fractie(r_numarator, r_numitor);
        }

        public Fractie Add(Fractie right)
        {
            int r_numarator, r_numitor;
            r_numitor = numitor * right.numitor;
            r_numarator = numarator * right.numitor + numitor * right.numarator;
            return new Fractie(r_numarator, r_numitor);
        }

        public Fractie(int numarator, int numitor)
        {
            int d;
            d = Util.gcd(numarator, numitor);
            this.numarator = numarator/d;
            this.numitor = numitor/d;
        }

        internal void Print()
        {
            Console.WriteLine(numarator + "/" + numitor);
        }
    }

    internal class Util
    {
        private Util()
        {

        }
        public static int gcd(int a,int b)
        {
            int r;
            while(b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}