using System;

namespace frac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frac kss1 = new Frac(1, 1);
            Frac kss2 = new Frac(1, 2);
            Frac kss3 = kss1 - kss2;
            Console.WriteLine(kss3);
            Console.ReadKey();

        }
    }
    class Frac
    {
        // fields
        double up;
        double down;
        // properties
        //public double Up { get { return up; } set { up = value; } }
        //public double Down { get { return down; } set { down = value; } }
        //defult constructor
        public Frac() { }
        //parmeters constructor
        public Frac(double up, double down)
        {
            this.up = up;
            this.down = down;
        }
        public static Frac operator /(Frac a, Frac b)
        {
            Frac frac = new Frac();
            frac.up = a.up * b.down;
            frac.down = a.down * b.up;
            return frac;
        }
        public static Frac operator *(Frac a, Frac b)
        {
            Frac frac = new Frac();
            frac.up = a.up * b.up;
            frac.down = a.down * b.down;
            return frac;
        }
        public static Frac operator +(Frac a, Frac b)
        {
            Frac frac = new Frac();
            if(a.down == b.down)
            {
                frac.up=a.up + b.up;
                frac.down = a.down;
            }
            else
            {
                frac.up=a.up*b.down+b.up*a.down;
                frac.down = a.down * b.down;
            }
            return frac;
        }
        public static Frac operator -(Frac a, Frac b)
        {
            Frac frac = new Frac();
            if (a.down == b.down)
            {
                frac.up = a.up - b.up;
                frac.down = a.down;
            }
            else
            {
                frac.up = a.up * b.down - b.up * a.down;
                frac.down = a.down * b.down;
            }
            return frac;
        }
        public override string ToString() // تستخدم عند يكون لدينا اوبيراتور للطباعة 
        {
            return $"{up}/{down}";
        }
    }
}
