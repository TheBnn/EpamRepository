using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_1_1._1._1._8_No_Positive
{
	public static class AntiPositive
	{

		public static void NoPositive()
		{
			var arr = GetArray();
			Console.WriteLine("Первичный трехмерный массив");
			PrintArray(arr);
			Console.WriteLine("Измененный трехмерный массив");
			PrintArray(ChangeArray(arr));
		}


		private static int[,,] ChangeArray(int[,,] elements)
		{
			for (int i = 0; i < elements.GetLength(0); i++)
			{
				for (int j = 0; j < elements.GetLength(1); j++)
				{
					for (int k = 0; k < elements.GetLength(2); k++)
					{
						if (elements[i, j, k] > 0) elements[i, j, k] = 0;
					}
				}
			}
			return elements;
		}

		private static int[,,] GetArray()
		{
			int[,,] arrayElements = new int[3, 3, 3];
			Random r = new Random();
			for (int i = 0; i < arrayElements.GetLength(0); i++)
			{
				for (int j = 0; j < arrayElements.GetLength(1); j++)
				{
					for (int k = 0; k < arrayElements.GetLength(2); k++)
					{
						arrayElements[i, j, k] = r.Next(-10, 10);
					}
				}
			}

			return arrayElements;
		}

		private static void PrintArray(int[,,] elements)
		{
			for (int i = 0; i < elements.GetLength(0); i++)
			{
				for (int j = 0; j < elements.GetLength(1); j++)
				{
					for (int k = 0; k < elements.GetLength(2); k++)
					{
						Console.Write($"{elements[i, j, k]} ");
					}
					Console.WriteLine();
				}
				Console.WriteLine();
			}
		}
	}
}
