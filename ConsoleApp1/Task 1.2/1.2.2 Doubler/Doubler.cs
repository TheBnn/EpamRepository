using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2._1._2._2_Doubler
{
	class Doubler
	{

		public static void AddDoubleLetter()
		{
			var someString = Console.ReadLine();
			var someWord = Console.ReadLine();

			for (int i = 0; i < someString.Length; i++)
			{
				if (someWord.Contains(someString.Substring(i, 1)))
				{
					Console.WriteLine(someString[i].ToString() + someString[i].ToString());
				}
				else
				{
					Console.WriteLine(someString[i]);
				}
			}

		}

	}
}
