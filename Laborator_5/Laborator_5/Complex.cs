namespace Laborator_5
{
    public class Complex
    {
        private double a;
        private double b;
        private int v;
        private int v1;

        public Complex()
        {
            a = 0;
            b = 1;
        }

        public Complex(int v)
        {
            this.v = v;
        }

        public Complex(int v, int v1) : this(v)
        {
            this.v1 = v1;
        }
    }
}