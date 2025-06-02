using System;

namespace Hanoi_Tower
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int u = 1;
			Hanoi(3, "a", "b", "c", ref u);
			Console.WriteLine("-----------------------------------");
			Class1 b = new Class1();
			b.Hanoi(3, "f", "t", "w");


		}
		public static void Hanoi(int disks, string source, string dest, string aux, ref int i)
		{
			if (disks > 0)
			{
				// move disk number 1 from source to dest
				Hanoi(disks - 1, source, aux, dest, ref i);

				Console.WriteLine(i++ + ") Move disk " + disks + " form [" + source + "] to [" + aux + "]");
				Hanoi(disks - 1, aux, dest, source, ref i);

			}


		}
	}
}
