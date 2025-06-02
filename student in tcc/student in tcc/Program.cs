using System;

namespace student_in_tcc
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Tcc DamasTcc = new Tcc(10);
            int n;
            do
            {
                Console.WriteLine("1- Add Student \n2- Students num in the area \n3- The First student \n4- Exit  " );
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (n)
                {

                    case 1:
                        students std = new students();
                        Console.WriteLine("Enter the student name : ");
                        std.Name = Console.ReadLine();
                        Console.WriteLine("Enter the student area : ");
                        std.Area = Console.ReadLine();
                        Console.WriteLine("Enter the student mark : ");
                        std.Mark = double.Parse(Console.ReadLine());
                        DamasTcc.AddStudent(std);
                        Console.WriteLine("-------------------------------------------------------");
                        
                        break;
                    case 2:
                        string AREA;
                        Console.WriteLine("Enter the area");
                        AREA = Console.ReadLine();
                        Console.WriteLine("the numbers of students in this area is : " + DamasTcc.FindTheArea(AREA));
                        Console.WriteLine("-------------------------------------------------------");
                        break;
                    case 3:
                        DamasTcc.TheHighestMark();
                     
                        break;
                    case 4:
                        Console.WriteLine("Okay, thanks.");
                        break;


                }

            } while (n != 4);
        }

        class students
        {
            string name;
            double mark;
            string area;

            public students() { }
            public students(string name)
            {
                this.name = name;
            }
            public students(string name, double mark) : this(name)
            {
                this.mark = mark;
            }
            public students(string name, double mark, string area) : this(name, mark)
            {
                this.area = area;
            }
            public string Name
            {
                set { name = value; }
                get { return name; }
            }
            public double Mark
            {
                set { mark = value; }
                get { return mark; }
            }
            public string Area
            {
                set { area = value; }
                get { return area; }

            }
        }
        class Tcc
        {
            students[] std;
            int index = 0;
            public Tcc(int length)
            {
                std = new students[length];
            }
            public void AddStudent(students m)
            {
                if (index == std.Length)
                {
                    Console.WriteLine("Array is Full");
                }
                else
                {
                    std[index++] = m;
                    
                    Console.WriteLine("Add Completed");
                }

            }
            public int FindTheArea(string Area)
            {
                int counter = 0;
                for (int i = 0; i < index; i++)
                {
                    if (std[i].Area == Area)
                    {
                        counter++;
                    }
                }
                return counter;
            }
            public void TheHighestMark()
            {
                int maxIndex = 0;
                for (int i = 0; i < index; i++)
                {
                    if (std[maxIndex].Mark < std[i].Mark)
                    {
                        maxIndex = i;
                    }
                }
                Console.WriteLine("Student's name: " + std[maxIndex].Name + "\nStudent's avg: " + std[maxIndex].Mark + "\nStudent's country: " + std[maxIndex].Area);
                Console.WriteLine("--------------------------------------------------------------");
            }
        }
    }


}

