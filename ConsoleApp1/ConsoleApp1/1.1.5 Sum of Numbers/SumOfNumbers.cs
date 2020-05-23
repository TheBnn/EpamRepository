using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Range;
using static System.Index;

namespace Task_1_1._1._1._5_Sum_of_Numbers
{
	public static class SumOfNumbers
	{

		public static int SumOfNumbersMethod()
		{
			return Enumerable.Range(1, 999).Where(item => item % 3 == 0 || item % 5 == 0).Sum();
		}

	}
}
