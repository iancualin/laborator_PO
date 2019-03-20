namespace laborator6
{
    internal class Complex
    {
        private double real, imaginar;

        public Complex():this(0,0)
        {

        }
        public Complex(double real , double imaginar)
        {
            this.real = real;
            this.imaginar = imaginar;
        }
        public static Complex  operator+(Complex left , Complex right)
        {
            Complex r = new Complex();
            r.real = left.real + right.real;
            r.imaginar = left.imaginar + right.imaginar;
            return r;
        }
        public override string ToString()
        {
            return "(" + real + " " + imaginar + ")";
        }

    }
}