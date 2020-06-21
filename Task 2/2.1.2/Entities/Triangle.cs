using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2._1._2.Entities
{
	class Triangle : BaseTriangle
	{
		public Triangle(Point centerPoint,int sideA, int sideB, int sideC)
		{
			CenterPoint = centerPoint;
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}
	}
}
