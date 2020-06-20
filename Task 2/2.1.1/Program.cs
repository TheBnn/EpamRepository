using System;
using CString;

namespace _2._1._1
{
    class Program
	{
		static void Main(string[] args)
		{
			CustomString str = "Hello World!";
			Console.WriteLine($"{str} {str.Length} {str.Capacity}");

			str.DeleteByIndexChar(2, 6);
			str.TrimCharArray();

			Console.WriteLine($"{str} {str.Length} {str.Capacity}");

			str[0] = 'E';
			str[1] = 't';
			str[2] = 'e';
			str[3] = 'r';
			str[4] = 'n';
			str[5] = 'i';
			str[6] = 't';
			str[7] = 'y';
			str[8] = ' ';
			str[9] = 'W';
			str[10] = 'o';
			str[11] = 'r';
			str[12] = 'l';
			str[13] = 'd';


			Console.WriteLine($"{str} {str.Length} {str.Capacity}");
		}
	}
}
