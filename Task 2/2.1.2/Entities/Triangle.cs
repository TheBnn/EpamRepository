using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1._2.Entities
{
	class Triangle : BaseTriangle
	{
		protected Triangle(double sideA, double sideB, double sideC)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}
	}
}
