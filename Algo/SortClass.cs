namespace Algorithms
{
    internal class SortClass
    {
        //O(n^2)
        public static int[] BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                        Swap(ref a[j], ref a[j + 1]);
                }
            }
            return a;
        }
        //O(n^2)
        public static int[] SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[min] > a[j])
                        min = j;
                }
                Swap(ref a[i], ref a[min]);
            }
            return a;

            //for (int i = 0; i < a.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < a.Length; j++)
            //    {
            //        if (a[i] > a[j])
            //            Swap(ref a[i], ref a[j]);
            //    }
            //}
            //return a;
        }
        //O(n^2)
        public static int[] InsertionSort(int[] a)
        {
            int current;
            for (int i = 1; i < a.Length; i++)
            {
                current = a[i];
                int j = i - 1;
                while (j >= 0 && current < a[j])
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = current;
            }
            return a;
        }


        //O(???)
        public static void MergeSort(int[] a)
        {
            int[] result = Merge(a, 0, a.Length);
            Array.Copy(result, a, result.Length);
        }
        private static int[] Merge(int[] arr, int start, int end)
        {
            //Fase 1 - Split
            if (end - start < 2)
                return new int[] { arr[start] };

            int middle = start + ((end - start) / 2);
            int[] left = Merge(arr, start, middle);
            int[] right = Merge(arr, middle, end);

            //Fase 2 - Sort & Merge
            int[] result = new int[left.Length + right.Length];
            int indexL = 0;
            int indexR = 0;
            int i = 0;
            for (; indexL < left.Length && indexR < right.Length; i++)
            {
                if (left[indexL] < right[indexR])
                {
                    result[i] = left[indexL];
                    indexL++;
                }
                else
                {
                    result[i] = right[indexR];
                    indexR++;
                }
            }

            // Copy remaining elements
            while (indexL < left.Length)
                result[i++] = left[indexL++];

            while (indexR < right.Length)
                result[i++] = right[indexR++];

            return result;
        }



        public static int[] QuickSort(int[] a)
        {
            if (a.Length < 2) return a;
            //int pivot = a[0];
            //int[] lefh = a.AsEnumerable(x => x < pivot);
            //int[] right = a.FirstOrDefault(x => x > pivot);
            //return [.. QuickSort(right), .. QuickSort(right)];
            return null;
        }
        public void Partition(int[] arr, int left, int right)
        {
            int pivotValue = arr[right];
            int partitionIndex = left;
            for (int i = left; i < right; i++)
            {
                if (arr[i] < pivotValue)
                {
                    Swap(ref arr[i], ref arr[partitionIndex]);
                    partitionIndex++;
                }
                Swap(ref arr[right], ref arr[partitionIndex]);
            }
        }

        #region MyRegion

        public static void Print(int[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i]);
                Console.Write(" , ");
            }
            Console.Write(a[a.Length - 1]);
            Console.Write("]");
        }
        public static void Swap(ref int Big, ref int Small)
        {
            int temp = Big;
            Big = Small;
            Small = temp;
        }

        #endregion

    }

}
