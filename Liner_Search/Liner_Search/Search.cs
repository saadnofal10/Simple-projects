using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liner_Search
{
    internal class Search
    {
        
        public int LinerSearch(int[] array , int ItemSearch)
        {
            bool Isfound = false;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ItemSearch)
                {
                    Console.WriteLine( "number " + ItemSearch + " in index number " + (i+1));
                    Isfound = true;
                    

                    
                }
                
               
            }
            if(!Isfound)
            {
                Console.WriteLine("there is no " + ItemSearch + " found on the array");
            }
            return 0;
        }

    }
}
