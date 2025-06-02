using System;
using System.Threading;

namespace using_random_with_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* RandomArray RA = new RandomArray(10);
            RA.Fill();
            RA.Print_Random_Array();
            RA.Sort();
            Console.WriteLine("----------------------------------------");
            RA.Print_Random_Array();*/
           RecArray RA = new RecArray(10);
			RA.Fill();
			RA.RecSort();
			RA.Print_Random_Array();
          

		}
    }
    class RandomArray
    {
        int[] array;
        public RandomArray()
        {
            
        }
        public RandomArray(int Length)
        {
            array = new int[Length]; 
        }
        public void Fill()
        {
           
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
        }
        public void Print_Random_Array()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public void Sort()
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int y = i + 1; y <= array.Length-1; y++)
                {
                    if (array[i] > array[y])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[y];
                        array[y] = temp;
                    }
                }
            }
        }
    }
    class RecArray
    {
		int[] array;
        int i = 0;
		public RecArray()
		{

		}
		public RecArray(int Length)
		{
			array = new int[Length];
		}
		public void Fill()
		{

			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(0, 100);
			}
		}
		public void Print_Random_Array()
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
			}
		}
		public void RecSort()
        {
            if(i<=array.Length)
            {
				for (int e = i+1 ; i < array.Length; i++)
				{
					
					if (array[i] > array[e])
					{
						int temp;
						temp = array[i];
						array[i] = array[e];
						array[e] = temp;
					}
					
				}
				RecSort();
				i++;



			}
           
		}
           
		
            /*for (int i = 0; i < array.Length - 1; i++)
			{
				for (int y = i + 1; y < array.Length ; y++)
				{
					if (array[i] > array[y])
					{
						int temp;
						temp = array[i];
						array[i] = array[y];
						array[y] = temp;
					}
				}
			}*/
            

		
	}

}

