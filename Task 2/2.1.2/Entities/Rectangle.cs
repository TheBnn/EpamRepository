using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2._1._2.Entities
{
	class Rectangle : BaseRectangle
	{
		public Rectangle(Point centerPoint,double lengthSideA, double lengthSideB)
		{
			CenterPoint = centerPoint;
			LengthSideA = lengthSideA;
			LengthSideB = lengthSideB;
		}
	}
}
