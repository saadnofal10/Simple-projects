using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace بناء_مستطيل
{
    internal class Program
    {

        class point
        {
            int x, y;
            public point(int x, int y) { this.x = x; this.y = y; }
            public point() { }
            public int X
            {
                set { this.x = value; }
                get { return this.x; }
            }
            public int Y
            {
                set { this.y = value; }
                get { return this.y; }
            }
            class Rectangle
            {
                int h, w;
                point startpoint = new point();
                //باني بثالثة بارامترات 
                public Rectangle(point s/*هي مشان ال اكس والواي*/, int h, int w)
                {
                    startpoint.X = s.X;
                    startpoint.Y = s.Y;
                    this.h = h;
                    this.w = w;
                }
            }
            static void Main(string[] args)
            {
                point p1 = new point();
                Rectangle r1 = new Rectangle(p1 , 2 ,3);
            }
        }
    }
}
