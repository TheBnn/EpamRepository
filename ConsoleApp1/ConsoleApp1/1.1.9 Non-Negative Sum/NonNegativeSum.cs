using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1_1_1._1._1._9_Non_Negative_Sum
{
	public class NonNegativeSum
	{
		public static void SumNonNegativeElements()
		{
			var arr = GetArray(10);
			PritArray(arr);
			Console.WriteLine($"{ arr.Where(item => item > 0).Sum() }");
		}

		private static List<int> GetArray(int sizeArray)
		{
			Random r = new Random();
			List<int> listElements = new List<int>();

			for (int i = 0; i < sizeArray; i++)
			{
				listElements.Add(r.Next(-sizeArray, sizeArray));
			}

			return listElements;
		}
		private static void PritArray(List<int> listElements, string process = "Вывод")
		{
			Console.WriteLine(process);
			for (int i = 0; i < listElements.Count; i++)
			{
				Console.Write("{0}, ", listElements[i]);
			}
			Console.WriteLine();
		}
	}
}
