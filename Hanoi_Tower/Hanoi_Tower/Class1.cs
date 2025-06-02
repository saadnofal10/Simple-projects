using System;

namespace Hanoi_Tower
{
	internal class Class1
	{
		public void Hanoi(int n,string source,string helper,string final)
		{
			if (n > 0)
			{
				Hanoi(n-1,source,helper,final);
				Console.WriteLine($"Move {n} from {source} to {helper}");
				Hanoi(n-1,helper,source,final);
			}
		}
	}
}
