using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1_1_1._1._1._7_Array_Processing
{
	class ArrayProcessing
	{
		public static void ArrayProcess(int sizeArray)
		{
			var array = GetArray(sizeArray);
			PritArray(array);
			var sortedArray = SortArray(array);
			PritArray(sortedArray, "Сортировка");
			GetMinElement(sortedArray, "Минимальный элемент");
			GetMaxElement(sortedArray, "Максимальный элемент");
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
		private static void GetMinElement(List<int> listElements, string process)
		{
			Console.WriteLine($"{process}");
			Console.WriteLine($"{ listElements[0] }");
		}
		private static void GetMaxElement(List<int> listElements, string process)
		{
			Console.WriteLine($"{process}");
			Console.WriteLine($"{listElements[listElements.Count - 1]}");
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
		private static List<int> SortArray(List<int> listElements)
		{
			int cache;
			for (int k = 0; k < listElements.Count - 1; k++)
			{
				cache = k;
				for (int j = k + 1; j < listElements.Count; j++)
				{
					if (listElements[j] < listElements[cache])
						cache = j;
				}
				int tmp = listElements[k];
				listElements[k] = listElements[cache];
				listElements[cache] = tmp;
			}

			return listElements;
		}
	}
}
