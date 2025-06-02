using System;
namespace my_homework
{
    internal class rocks
    {
        static string[] cpu_qustion;
        static int[] Trueanswers1;
        static int[] Trueanswers2;
        static int[] Trueanswers3;
        static string[] useranswers1;
        static string[] useranswers2;
        static string[] useranswers3;
        static int[] marks;
        static void Main(string[] args)
        {
            Console.WriteLine("Windows version: " + Environment.OSVersion);
            Console.WriteLine("64 bit operating system? : {0}", Environment.Is64BitOperatingSystem ? "Yes" : "No");
            Console.WriteLine("PC name : " + Environment.MachineName);
            Console.WriteLine("Number of CPUs : " + Environment.ProcessorCount);
            Console.WriteLine("Windows Folder : " + Environment.SystemDirectory);
            Console.WriteLine("Logical Drives Available : {0}", String.Join(" & ", Environment.GetLogicalDrives()).TrimEnd(',', ' ').Replace("\\", String.Empty));
            Random names1 = new Random(); // creat sentence1
            Random names2 = new Random(); // creat sentence2
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!?.#,"; // array of cahrs that accepted //
            Console.WriteLine("enter the number of the qustions: ");
            int nofq; // number of the qustions //
            do
            {
                nofq = int.Parse(Console.ReadLine());
                if (nofq <= 0)
                {
                    Console.WriteLine("pls enter a number that biger than 0");
                }
            } while (nofq <= 0);

            cpu_qustion = new string[nofq];
            Trueanswers1 = new int[nofq];
            Trueanswers2 = new int[nofq];
            Trueanswers3 = new int[nofq];
            useranswers1 = new string[nofq];
            useranswers2 = new string[nofq];
            useranswers3 = new string[nofq];// My Arrays
            marks = new int[nofq];

            Console.WriteLine("Please enter your name[your first name and the last name] , SVU id and ...... \nuse chars that contain [A-Z] , [a-z] , [0-9] , [,.#!?] at least 6 0f Accepted chars");
            string username = Console.ReadLine(); // the user input words
            string specialname = ""; // the space of chars that we well save the accepted chars in //
            for (int i = 0; i < username.Length; i++)
            {
                if ((username[i] >= 'A' && username[i] <= 'Z') || (username[i] >= 'a' && username[i] <= 'z') || (username[i] >= 48 && username[i] <= 57) || username[i] == 33 || username[i] == 35 || username[i] == 44 || username[i] == 46 || username[i] == 63)
                {
                    if (specialname.IndexOf(username[i]) == -1) { specialname += username[i]; }
                }
            }//the accepted chars

            while (specialname.Length <= 6)
            {
                specialname = "";

                Console.WriteLine("Please enter your name[your first name and the last name] , SVU id and ...... \nuse chars that contain [A-Z] , [a-z] , [0-9] , [,.#!?] at least 6 0f Accepted chars");
                username = Console.ReadLine();

                for (int i = 0; i < username.Length; i++)
                {

                    if ((username[i] >= 'A' && username[i] <= 'Z') || (username[i] >= 'a' && username[i] <= 'z') || (username[i] >= 48 && username[i] <= 57) || username[i] == 33 || username[i] == 35 || username[i] == 44 || username[i] == 46 || username[i] == 63)
                    {
                        if (specialname.IndexOf(username[i]) == -1) { specialname += username[i]; }
                    }
                }
            }

            Console.WriteLine("------------------------------------\n" + specialname + "\n------------------------------------");
            for (int i = 0; i < nofq; i++)
            {

                int size;
                do
                {
                    Console.WriteLine("Q" + (i + 1) + ":" + "\nWrite the size of chars between 20-80:");
                    size = int.Parse(Console.ReadLine());
                } while (size >= 81 || size <= 19);

                string qusetion = "";
                string qusetion1 = "";
                string charss = "!?.#,";

                for (int y = 0; y < size; y++) { qusetion = qusetion + chars[names1.Next(0, chars.Length)]; } // random chars sentence 1

                for (int z = 0; z < size; z++)
                {
                    int random = names2.Next(4);
                    if (random == 0) { qusetion1 += (char)(names2.Next(65, 91)); }
                    else if (random == 1) { qusetion1 += (char)(names2.Next(97, 123)); }
                    else if (random == 2) { qusetion1 += (char)(names2.Next(48, 58)); }
                    else if (random == 3) { qusetion1 += charss[(names2.Next(0, charss.Length))]; }
                }//random chars sentence 2

                Console.WriteLine(qusetion + "\n" + qusetion1);


                // order 1
                Console.Write("What is the number of special letters in sentence 1 : ");
                useranswers1[i] = Console.ReadLine();

                int count1 = 0;
                for (int j = 0; j < specialname.Length; j++)
                {
                    for (int p = 0; p < qusetion.Length; p++)
                    {
                        if (specialname[j] == qusetion[p])
                        {
                            count1++;
                            break;
                        }
                    }

                    Trueanswers1[i] = count1;
                }
                if (useranswers1[i] == Trueanswers1[i].ToString()) // user answer
                {
                    marks[i]++;
                }
                if (ToLower(useranswers1[i]) == "ignore") { Console.WriteLine("IGNORED"); }


                // order 2
                Console.Write("What is the number of special letters in sentence 2 : ");
                useranswers2[i] = (Console.ReadLine());
                int count2 = 0;

                for (int h = 0; h < specialname.Length; h++)
                {
                    for (int m = 0; m < qusetion1.Length; m++)
                    {
                        if (specialname[h] == qusetion1[m])
                        {
                            count2++;
                            break;

                        }

                    }

                    Trueanswers2[i] = count2;
                }
                if (useranswers2[i] == Trueanswers2[i].ToString())// user answer
                {
                    marks[i]++;
                }
                if (ToLower(useranswers2[i]) == "ignore") { Console.WriteLine("IGNORED"); }

                // order 3
                string special_Q = "";
                for (int q = 0; q < qusetion.Length; q++)
                {
                    if ((qusetion[q] >= 'A' && qusetion[q] <= 'Z') || (qusetion[q] >= 'a' && qusetion[q] <= 'z') || (qusetion[q] >= 48 && qusetion[q] <= 57)|| qusetion[q] == 33 || qusetion[q] == 35 || qusetion[q] == 44 ||qusetion[q] == 46 ||qusetion[q] == 63)
                    {
                        if (special_Q.IndexOf(qusetion[q]) == -1) { special_Q += qusetion[q]; }
                    }
                }

                Console.Write("What is the number of the same letter in sentence 1 and sentence 2 : ");
                useranswers3[i] = Console.ReadLine();
                int count3 = 0;
                for (int h = 0; h < special_Q.Length; h++) // abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.#?!,
                {
                    for (int m = 0; m < qusetion1.Length; m++) // ASew23 ewRASS
                    {
                        if (special_Q[h] == qusetion1[m])
                        {
                            count3++;
                            break;
                        }
                    }
                    Trueanswers3[i] = count3;
                }
                if (useranswers3[i] == Trueanswers3[i].ToString())// user answer
                {
                    marks[i]++;
                }
                if (ToLower(useranswers3[i]) == "ignore") { Console.WriteLine("IGNORED"); }


                cpu_qustion[i] = "------------------------------------Q" + (i + 1) + "------------------------------------" + "\n" + qusetion + "\n" + qusetion1;
                Console.WriteLine("------------------------------------------------------------------------");
            }
            bool whiling = true;
            while (whiling == true)
            {
                Console.WriteLine("1- Show the questions\n" +
                    "2- show the number of wrong answers\n" +
                    "3- show the number the correct answer\n" +
                    "4- Show the number of relatively correct answers\n" +
                    "5- show the user's answers and the correct answers for every question and is the answer correct completly\n" +
                    "6- write exit to end the game");
                string chose = Console.ReadLine();
                switch (ToLower(chose))
                {
                    case "1":
                        for (int i = 0; i < cpu_qustion.Length; i++)
                            Console.WriteLine(cpu_qustion[i]);
                        break;
                    case "2":
                        W(marks);
                        break;
                       
                    case "3":
                        C(marks);
                        break;
                        
                    case "4":
                        RC(marks);
                        break;
                    case "5":
                        UA();
                        break;
                    case "exit":
                        Console.WriteLine("------------------------------------------------------------------------");
                        whiling = false;
                        break;
                    default:
                        break;
                }
                
            }
        }


        // functions
        static string ToLower(string str)
        {
            string New = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    New += (char)(str[i] + 32);
                }
                else
                {
                    New += str[i];
                }
            }
            return New;
        }
        static void W(int[] marks)
        {
            int count = 0;
            for (int i = 0; i < marks.Length; i++) { if (marks[i] == 0) { count++; } }
            Console.WriteLine("The number of wrong answres is :" + count);
        }
        static void C(int[] marks)
        {
            int count = 0;
            for (int i = 0; i < marks.Length; i++) { if (marks[i] == 3) { count++; } }
            Console.WriteLine("The number of Correct answres is :" + count);
        }
        static void RC(int[] marks)
        {
            int count = 0;
            for (int i = 0; i < marks.Length; i++) { if (marks[i] == 1 || marks[i] == 2) { count++; } }
            Console.WriteLine("The number of Relativly Correct answres is :" + count);
        }
        static void UA()
        {
            for (int i = 0; i < useranswers1.Length; i++)
            {
                Console.WriteLine("------------------------------------Q" + (i + 1) + "------------------------------------");
                Console.WriteLine("order 1 :" + "\t" + "the user's answer: " + useranswers1[i] + "\t" + "the right answer: " + Trueanswers1[i]);
                Console.WriteLine("order 2 :" + "\t" + "the user's answer: " + useranswers2[i] + "\t" + "the right answer: " + Trueanswers2[i]);
                Console.Write("order 3 :" + "\t" + "the user's answer: " + useranswers3[i] + "\t" + "the right answer: " + Trueanswers3[i] + "\t");
                if (marks[i] == 3)
                    Console.WriteLine("yes it is completely correct");
                else
                    Console.WriteLine("no it is not completely correct");
            }
        }
    }
}
