using System;

namespace _3._3._1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 3, 3, 3, 43, 43, 43, 4443, 4, 52, 3, 4, 52, 3, 4, 52, 3, 4, 52, 3, 4, 5, 5, 3, 3, 1, 1 };
	


			Console.WriteLine("Сум: " + arr.SumOfAll());
			Console.WriteLine("Авг" + arr.Avg());
			Console.WriteLine("Исп" + arr.Prevalent());

		}
	}
}
