using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1._1._14_X_mas_Tree
{
	public static class XmasTree
	{
		public static void MakeXmasTree(int rows)
		{
			for (int i = 1; i <= rows; i++)
			{
				for (int j = 0; j < i; j++)
				{
					string tree = new String('*', j);
					Console.WriteLine(tree.PadLeft(rows + 3) + "*" + tree);
				}
			}
		}
	}
}
