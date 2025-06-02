using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Complex
    {
        double real;
        double img;
        public Complex(double real, double img)
        {
            this.real = real;
            this.img = img;
        }
        public Complex()
        { }
        public double Real
        {
            set { this.real = value; }
            get { return this.real; }
        }
        public double Image
        {
            set { this.img = value; }   
            get { return this.img; }
        }
        public void Print()
        {
            Console.WriteLine("z3 = " + real + " + " + img + "i") ;
        }
        
    }
    class program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            Complex c3 = new Complex();
            c1.Real = double.Parse(Console.ReadLine());
            c1.Image = double.Parse(Console.ReadLine());
            c2.Real = Convert.ToDouble(Console.ReadLine());
            c2.Image = Convert.ToDouble(Console.ReadLine());
            c3.Real = c1.Real + c2.Real;
            c3.Image = c1.Image + c2.Image;
            c3.Print();
        }
    }
}
