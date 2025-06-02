using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Diagnostics;
using System.Collections;


namespace Files_Demo
{
    internal class Program
    {
        public static void write(string path)
        {
            StreamWriter sw = new StreamWriter(File.Open(path,FileMode.OpenOrCreate));
            for(int i =0; i <= 10; i++)
            {
                sw.WriteLine(i);
            }
            sw.Close();
        }
        public static void read(string path) 
        {
            if (File.Exists(path)) 
            {
                string e = "";
                StreamReader sr = new StreamReader(File.Open(path, FileMode.Open));
                while ((e = sr.ReadLine())!=null) 
                {
                    Console.WriteLine(e);
                }
            }
        }

        static void Main(string[] args)
        {
            string Path = "C:\\Users\\NOFAL\\Desktop\\De1mo.txt";
read(Path);
        }
    }
}



class Emplyee
{
    public string Name { get; set; }
    public double price { get; set; }
    public Emplyee()
    {
    }
    public Emplyee(string name, double price)
    {
        Name = name;
        this.price = price;
    }

}
class ourfile
{
    public void write(string path, int n)
    {
        BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Name of emp " + (i + 1));
            bw.Write(Console.ReadLine());
            Console.WriteLine("Salary of emp " + (i + 1));
            bw.Write(Convert.ToDouble(Console.ReadLine()));
        }
        bw.Close();
    }
    public void read(string path)
    {
        BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
        while (br.PeekChar() != -1)
        {
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());

        }
        br.Close();
    }
    public int countEmp(string path)
    {
        int c = 0;
        if (File.Exists(path))
        {
            BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
            while (br.PeekChar() != -1)
            {
                br.ReadString();
                br.ReadDouble();
                c++;
            }
            br.Close();
        }

        return c;
    }
    public Emplyee[] fromfiletoarray(string path)
    {
        int n = countEmp(path);
        Emplyee[] emp = new Emplyee[n];
        int index = 0;
        if (File.Exists(path))
        {
            BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
            while (br.PeekChar() != -1)
            {
                emp[index++] = new Emplyee(br.ReadString(), br.ReadDouble());
            }
            br.Close();
        }
        return emp;
    }
    public void FromArrayTofile(Emplyee[] emplyees, string path)
    {
        BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
        for (int i = 0; i < emplyees.Length; i++)
        {
            bw.Write(emplyees[i].Name);
            bw.Write(emplyees[i].price);
        }
        bw.Close();
    }
}
