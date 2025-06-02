using System;




namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student std = new student("saad", "c#", 0);
            if (std >= 60)
            {
                Console.WriteLine(std);
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
    }
    class student
    {
        string name;
        string meth;
        int mark;
        public student(string name, string meth, int mark)
        {
            this.name = name;
            this.meth = meth;
            this.mark = mark;
        }
        public static bool operator >=(student a, int x)
        {
            bool stat = false;
            if (a.mark >= 60)
            {
                stat = true;
            }
            return stat;
            
        }
        public static bool operator <=(student a, int x)
        {
            bool stat = false;
            if (a.mark <=60)
            {
                stat = true;
            }
            return stat;
        
        }
        public override string ToString()
        {
            return mark + meth + name;
        }
    }
}
