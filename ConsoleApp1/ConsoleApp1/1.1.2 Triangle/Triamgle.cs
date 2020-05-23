using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1._1._1._2_Triangle
{
	public static class Triamgle
	{
		public static void MakeTriangle(int rows)
		{
			//Как вариант
			string template = "*";
			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine(template);
				template += "*";
			}

			//Как вариант
			for (int i = 0; i <= rows; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
