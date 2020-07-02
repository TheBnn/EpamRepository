using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities.Bases
{
	abstract public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public void SetPoint(int x,int y)
		{
			X = x;
			Y = y;
		}
	}
}
