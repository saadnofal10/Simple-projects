using System;

namespace خوارزميات
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // l1 { 2 , 0 , 1} => 102        l2 { 8 , 3 , 2} => 238   
            //   {0 , 4 , 2} ===>  102 + 238 = 240
            int[] l1 = { 2, 0, 1 ,2 };
            int[] l2 = { 8, 3, 2 };
            int temp = 0;
            int temp1 = 0;
            int res = 0;
            

            //==============================================================
            // l[0]=l[3-0-1]=l[2] =>l[1]=l[3-1-1]=l[1] =>l[2]=l[3-2-1]=l[0]
            for (int i = 0; i < l1.Length/2 ; i++)
            {
                temp = l1[i];
                l1[i] = l1[l1.Length - i - 1];
                l1[l1.Length - i - 1] = temp;
                
            }
            for(int i = 0; i < l1.Length; i++) { Console.WriteLine(l1[i]); }

            for (int i = 0; i < (l2.Length / 2); i++)
            {
                temp1 = l2[i];
                l2[i] = l2[l2.Length - i - 1];
                l2[l2.Length - i - 1] = temp1;
            }
            //================================================================
            int n = 0;
            int power = 1;
            for (int i = 0; i < l1.Length; i++)// 102
            {
                power = 10;
                n *= power;
                n += l1[i];
                power *= 10;
            }
            Console.WriteLine(n);
            Console.WriteLine("+");
            int n1 = 0;
            power = 1;
            for (int i = 0; i < l2.Length; i++)// 238
            {
                power = 10;
                n1 *= power;
                n1 += l2[i];
                power *= 10;
            }
            Console.WriteLine(n1);
            Console.WriteLine("-------------");
            res = n + n1;
            string s = Convert.ToString(res);
            int[] newREs = new int[res.ToString().Length];
            for (int i = 0; i < newREs.Length; i++)
            {
                newREs[i] = Convert.ToInt32(s[i]) - 48;
            }

            for (int i = 0; i < newREs.Length; i++)
            {
                Console.Write(newREs[i]);
            }
            Console.WriteLine();

        }

        //====================================  خوارزمية جمع عددين من مصفوفة  ============================================
        /*
                    int sum = 0;
                    int target = 6;
                    int[] a = { 0, 2, 1, 0, 1, 10, 4, 4 };
                    Console.Write("the target is = " + target + " , the array is = [");
                    for (int x = 0; x < a.Length; x++)
                    {
                        Console.Write(a[x] + ",");

                    }
                    Console.WriteLine("]");
                    Console.WriteLine("\n");

                    for (int i = 0; i < a.Length; i++)
                    {

                        for (int j = i + 1; j <= a.Length - 1; j++)
                        {
                            sum = a[i] + a[j];
                            if (sum == target)
                            {
                                Console.WriteLine("a[" + i + "]=" + a[i] + " and " + "a[" + j + "]=" + a[j] + " are the wanted");
                            }
                            sum = 0;
                        }
                    }*/

    }
}

