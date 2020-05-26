using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2._1._2._3_LowerCase
{
	class LowerCase
	{

		public static void GetLowerCase()
		{
			var sum = 0;
			var text = Console.ReadLine();
			var someString = text.Split(new char[] { ' ', ',', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < someString.Length; i++)
			{
				var cache = someString[i];
				var isLower = char.IsLower(cache[0]);

				if (isLower)
				{
					sum++;
				}
			}

			Console.WriteLine($"Result: {sum}");
		}

	}
}
