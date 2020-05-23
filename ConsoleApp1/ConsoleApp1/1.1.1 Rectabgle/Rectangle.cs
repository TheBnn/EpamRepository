using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1._1._1._1_Rectabgle
{
	public static class Rectangle
	{

		public static int? CalculateRectangle(string a, string b)
		{
			try
			{
				if (int.TryParse(a, out var A) == false || int.TryParse(b, out var B) == false)
				{
					Console.WriteLine("Введены некоректные данные");
					return null;
				}
				else
				{
					if (A <= 0 || B <= 0)
					{
						Console.WriteLine("Введены некоректные данные");
						return null;
					}
					return A * B;
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Необработанное исключение");
				throw;
			}
		}

	}
}
