using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace compare_point_with_tow_points
{
    internal class Program
    {
        public static string ComparePoints(point p1, point p2, point p3)
        {
            
           if(
                (p3.X>=p1.X && p3.X<=p2.X || p3.X <= p1.X && p3.X >= p2.X) 
                &&
                (p3.Y >= p1.Y && p3.Y <= p2.Y || p3.Y <= p1.Y && p3.Y >= p2.Y)
                &&
                (p3.Z >= p1.Z && p3.Z <= p2.Z || p3.Z <= p1.Z && p3.Z >= p2.Z)
            )
            {
                return "it is between them";
            }
            else
                return "it is not between them";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur name sir");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome mister " + name);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("This program can compare 3 point and find if point 3 between point 1 and point 2 (1D , 2D , 3D)");
            Console.WriteLine("please enter which type u want to use (1- 1D , 2- 2D , 3- 3D , 4- exit )");
            int n = int.Parse(Console.ReadLine());
            point p2 = new point();
            point p3 = new point();
            point p1 = new point();

            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the cordoniat X for the 3 points ");
                    Console.WriteLine("point 1 :");
                    p1 = new point()
                    {
                        X = int.Parse(Console.ReadLine())
                    };
                    Console.WriteLine("point 2 :");
                    p2 = new point()
                    {
                        X = int.Parse(Console.ReadLine())
                    };
                    Console.WriteLine("point 3 :");
                    p3 = new point()
                    {
                        X = int.Parse(Console.ReadLine())
                    };
                    
                    Console.WriteLine(ComparePoints(p1, p2, p3));
                    break;
                case 2:
                    Console.WriteLine("Enter the cordoniat X , Y for the 3 points ");
                    Console.WriteLine("point 1 :");
                    p1 = new point()
                    {
                        X = int.Parse(Console.ReadLine()) , Y = int.Parse(Console.ReadLine()) 
                    };
                    Console.WriteLine("point 2 :");
                    p2 = new point()
                    {
                        X = int.Parse(Console.ReadLine()) , Y = int.Parse(Console.ReadLine())
                    };
                    Console.WriteLine("point 3 :");
                    p3 = new point()
                    {
                        X = int.Parse(Console.ReadLine()),
                        Y = int.Parse(Console.ReadLine())
                    };
                    Console.WriteLine(ComparePoints(p1, p2, p3));
                    break;
                case 3:
                    Console.WriteLine("Enter the cordoniat X , Y , Z for the 3 points ");
                    Console.WriteLine("point 1 :");
                    p1 = new point()
                    {
                        X = int.Parse(Console.ReadLine()),
                        Y = int.Parse(Console.ReadLine()),
                        Z = int.Parse(Console.ReadLine())
                    };
                    Console.WriteLine("point 2 :");
                    p2 = new point()
                    {
                        
                        X = int.Parse(Console.ReadLine()),
                        Y = int.Parse(Console.ReadLine()),
                        Z = int.Parse(Console.ReadLine())
                    };
                    Console.WriteLine("point 3 :");
                    p3 = new point()
                    {
                        X = int.Parse(Console.ReadLine()),
                        Y = int.Parse(Console.ReadLine()),
                        Z = int.Parse(Console.ReadLine())
                    };
                    Console.WriteLine(ComparePoints(p1, p2, p3));
                    break;
                case 4:
                    break;




            }
            
        }
    }
    class point
    {
        public int X
        {
            set; get;
        }
        public int Y
        {
            set; get;
        }
        public int Z
        {
            set; get;
        }
        public point()
        {

        }
        public point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

    }
    

}

/*if(p3.X >= p1.X && p3.X <= p2.X || p3.X <= p1.X && p3.X >= p2.X)
{
    return true;
}
else if (p3.X >= p1.X && p3.X <= p2.X && p3.Y >= p1.Y && p3.Y <= p2.Y || p3.X <= p1.X && p3.X >= p2.X && p3.Y <= p1.Y && p3.Y >= p2.Y)
{
    return true;
}*//*
if (p3.X >= p1.X && p3.X <= p2.X && p3.Y >= p1.Y && p3.Y <= p2.Y && p3.Z >= p1.Z && p3.Z <= p2.Z || p3.X <= p1.X && p3.X >= p2.X && p3.Y <= p1.Y && p3.Y >= p2.Y && p3.Z <= p1.Z && p3.Z >= p2.Z)
{
    return "it is between them";
}
if ((p1.X * p1.Y) > 0 && (p2.X * p2.Y) > 0)
{
    if (p3.X * p3.Y <= (p1.X * p1.Y) + (p2.X * p2.Y) && (p3.X * p3.Y >= p1.X * p1.Y || p3.X * p3.Y >= p2.X * p2.Y))
    {
        return "it is between them";
    }
    return " it is not between them ";

}
else if ((p1.X * p1.Y) < 0 && (p2.X * p2.Y) < 0)
{
    if (p3.X * p3.Y <= (p1.X * p1.Y) - (p2.X * p2.Y) && (p3.X * p3.Y >= p1.X * p1.Y || p3.X * p3.Y >= p2.X * p2.Y))
    {

        return "it is between them";

    }

    return " it is not between them ";
}

else
    return "it is not between them";*/

