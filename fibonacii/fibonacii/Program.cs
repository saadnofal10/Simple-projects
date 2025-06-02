using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace fibonacii
{
    internal class Program
    {

        static  async Task  Main(string[] args)
        {

            long x = await Fib.Recfib(99);
            Console.WriteLine(x);
            //Console.WriteLine(x);
            //long r =/*fib*/(99);
            //Console.WriteLine(r);



        }

        /*
         F1 = 1     
         F2 = 1 + 0 
        int S = 1   
        int R = 0
        res= s + r 

         F3 = 1 +  1
         F4 = 2 + 1
         F5 = 3 + 2
         F6 = 5 + 3 
         F7 = 8 + 5
         
         
         */
        /* static int fib (int num)
         {

             long s = 1;
             long r = 0;
             for(int i = 1; i < num; i++) 
             {
                 if ( num >=2)
                 {
                 res = s + r;
                 r = s;
                 s = res; 
                 }
             }
             if(num == 1)
             {
                 res = s;
             }
             else if(res < 0 )
             {
                 res *= -1;
             }
             return res;

         }*/
    }
}
class Fib
{
    static Dictionary<int, long> memo = new Dictionary<int, long>();
    public static long RecfibDictionary(int num)
    {
        if (memo.ContainsKey(num)) return memo[num];
        if (num > 2)
        {
            memo[num] = RecfibDictionary(num - 1) + RecfibDictionary(num - 2);
            return memo[num];
        }

        return 1;
    }
    public static async Task<long> Recfib(int num) {
        if (num > 2)
        {
            long fib1 = await Recfib(num - 1);
            long fib2 = await Recfib(num - 2);
            return fib1+ fib2;
        }
        return 1;
    }

}





