using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_1_1._11._1._10_2D_Array
{
	class Sum2dArrayElements
	{

		public static void SumElements()
		{
			var elements = GetArray();

			PrintArray(elements);

			int sum = 0;
			for (int i = 0; i < elements.GetLength(0); i++)
			{
				for (int j = 0; j < elements.GetLength(1); j++)
				{
					if ((i + j) % 2 == 0) sum += elements[i, j];
				}
			}
			Console.WriteLine("Сумма {0}", sum);
		}



		private static int[,] GetArray()
		{
			int[,] arrayElements = new int[3, 3];
			Random r = new Random();

				for (int j = 0; j < arrayElements.GetLength(0); j++)
				{
					for (int k = 0; k < arrayElements.GetLength(1); k++)
					{
						arrayElements[j, k] = r.Next(-10, 10);
					}
				}
			return arrayElements;
		}
		private static void PrintArray(int[,] elements)
		{
			for (int i = 0; i < elements.GetLength(0); i++)
			{
				for (int j = 0; j < elements.GetLength(1); j++)
				{
					Console.Write($"{elements[i, j]} ");
				}
				Console.WriteLine();
			}
		}
	}
}
