using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Length = 10;
            rectangle.Width = 5;
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Length = 4;
            rectangle1.Width = 5;
            Circle circle = new Circle();
            circle.Radius = 10;
            Circle circle1 = new Circle();
            Triangle triangle = new Triangle();
            triangle.High = 4;
            triangle.Base = 4;
            Triangle triangle1 = new Triangle();
            triangle1.High = 6;
            triangle1.Base = 6;


            Console.WriteLine(rectangle.CalcSpace() + rectangle1.CalcSpace());
            Console.WriteLine(circle.CalcSpace() + circle1.CalcSpace());
            Console.WriteLine(triangle.CalcSpace() + triangle1.CalcSpace());

        }

        abstract class IShape
        {
            public abstract double CalcSpace();
          
            
        }
        class Rectangle : IShape
        {
            double length;
            double width;
           
            public  double Length
            {
                set { length = value; } get => length;
            }
            public  double Width { set { width = value; } get { return width; } }
            public override double CalcSpace()
            {
                return length * width;
            }
            public static Rectangle operator +(Rectangle r1 , Rectangle r2)

            {
                Rectangle r = new Rectangle();
                r.length=r1.length+r2.length;
                r.width =r1.width +r2.width;
                return r;
                
            }
            public override string ToString()
            {
                return $"{length}{width}";

            }

        }
        class Triangle : IShape
        {
            double high;
            double mbase;
            public double High { set { high = value;  } get { return high; } }
            public double Base { set { mbase = value; } get { return mbase; } }
            public override double CalcSpace()
            {
                return (High * Base) / 2;
            }
            public static Triangle operator +(Triangle t1 , Triangle t2)
            {
                Triangle t = new Triangle();
                t.High=t1.High +t2.high;
                t.mbase =t1.mbase+t2.mbase;
                return t;
            }
            public override string ToString()
            {
                return $"{high}{mbase}";
            }
        }
        class Circle : IShape
        {
            double radius;
            public double Radius { set; get; }
            public override double CalcSpace()
            {
                return (Radius * Radius) * 3.14;
            }
            public static Circle operator +(Circle c1 , Circle c2)
            {
                Circle c = new Circle();
                c.Radius = c1.Radius + c2.Radius;
                return c;
            }
            public override string ToString()
            {
                return $"{radius}";
            }
        }

    }
    
   /* class Contianer
    {
        int index = 0;
        IShape[] shapes = new IShape[2];
        public void AddShape(IShape newShape)
        {
            if (index == 2) { Console.WriteLine("u can not add shape"); }
            else { shapes[index] = newShape; index++; }
        }

    }*/

}
    
