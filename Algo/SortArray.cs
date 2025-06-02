namespace Algorithms
{
    internal class SortArray
    {
        int[] arry;
        public int[] Arry { get { return arry; } }
        int length = 0;

        public SortArray(int length)
        {
            this.length = length;
            arry = new int[length];
        }

        public void Print()
        {
            SortClass.Print(arry);
            Console.WriteLine();
        }

        public void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = random.Next(0, 1_00);
            }
        }

        public void Sort()
        {
            SortClass.SelectionSort(arry);
        }

        public void RecSort()
        {
            for (int i = 0; i < length; i++)
            {

            }
        }

    }
}
