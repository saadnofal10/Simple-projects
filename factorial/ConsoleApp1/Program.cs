using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fact f = new fact();
            string a =f.Recfract(3).ToString();
            Console.WriteLine(a);



        }
    }
    class fact
    {
        public long Recfract(int n)
        {
            if(n<2) 
                return 1;
           
            return n*Recfract(n-1);
        }
    }
}
