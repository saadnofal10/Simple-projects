using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace point_x_y_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int px; //coordinates x
            int py; // coordinates y
            do
            {
                Console.WriteLine("Enter point's coordinates");
                Console.Write("x = "); px = int.Parse(Console.ReadLine());
                Console.Write("y = "); py = int.Parse(Console.ReadLine());
            } while (px < 0 && py < 0 );
            point p1 = new point(px , py);
            Console.WriteLine();
            int n;
            do
            {
                Console.WriteLine("Enter a number for those actions:"+"\n"+"1- move the point. \n2- compare points. \n3- draw the point. \n4- print the point. \n5- exit.");
                n = int.Parse(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        Console.WriteLine("enter  x , y coordinate to add them on "+"("+px+","+py+")"+ " of the base coordinates");
                        int newX = int.Parse(Console.ReadLine());
                        int newY=int.Parse(Console.ReadLine());
                        p1.Move(newX, newY);
                        break;
                    case 2:
                        Console.WriteLine("enter coordinates for the new point to comoare it with base point's coordinates");
                        int newPointX = int.Parse(Console.ReadLine());
                        int newPointY=int.Parse(Console.ReadLine());
                        point p2 = new point(newPointX,newPointY);
                        p1.Compare(p2);
                        break;
                    case 3:
                        p1.Draw();
                        break;
                    case 4:
                        p1.print();
                        break;
                    case 5:
                        break;
                    
                }
            } while (n>0 && n <=4);
            Console.WriteLine("\nthe end");
        }
        
    }
    class point
    {
        public int x { set; get; }
        public int y { set; get; } 
        int point_number;
        public point()
        {
            point_number++;
        }
        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
            point_number++;
        }
        public static void AddPoint(int x , int y)
        {
            point NewPoint = new point(x,y);
        }
        public void print()
        {
            Console.WriteLine("P" + point_number+ "(" + x + "," + y +")");
        }
        public void Move(int dx , int dy)
        {
            x = dx + x;
            y = dy + y; 
        }
        public void Compare(point p2)
        {
            if (x == p2.x && y == p2.y)
            {
                Console.WriteLine("the cordinates are equals");
                return;
            }
            else
            {
                Console.WriteLine("the cordinates are not equals");
            }
        }
        public void Draw()
        {
            Console.WriteLine("start drawing");
            for (int i = 0; i < y; i++)
                Console.WriteLine("");
            for (int j = 0; j < x ; j++)
                Console.Write(" ");
            Console.WriteLine("*");
        }
    }
}
