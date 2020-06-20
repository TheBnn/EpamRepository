using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2._1._2.Entities
{
	class Square : BaseRectangle
	{
		public Square(Point centerPoint, double lengthSideA)
		{
			CenterPoint = centerPoint;
			LengthSideA = lengthSideA;
		}
	}
}
