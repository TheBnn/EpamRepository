using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2._1._2._1_Averages
{
	class Averages
	{
		public static void GetAverageLengthWord()
		{
			double average = 0;
			var someSting = Console.ReadLine();

			var arrayWord = someSting.Split(new char[] { ' ', '!', '?', ',', '.', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var item in arrayWord)
			{
				average += item.Length;
			}

			Console.WriteLine($"Среднее: {average / arrayWord.Length}");
		}
	}
}
