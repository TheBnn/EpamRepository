using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1._1._1._3_Another_Triangle
{
	public static class AnotherTriangle
	{

		public static void MakePyramid(int rows)
		{
			//Аналогичный вариант есть с двумя циклами (с шаблоном как в предыдущем задании)
			if (rows % 2 == 0) rows++;
			for (int i = 0; i < rows; i += 2)
			{
				for (int j = 0; j < (rows - 1) / 2 - (i / 2); j++)
				{
					Console.Write(' ');
				}
				for (int j = 0; j < i + 1; j++)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}
		}

	}
}
