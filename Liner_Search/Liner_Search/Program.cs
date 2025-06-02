using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liner_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Search s = new Search();
            int[]a = { 1, 2, 3 ,4 ,4 ,5,12};
            s.LinerSearch(a , 4);
        }

    }
    
}
