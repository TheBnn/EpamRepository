using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1._2.Entities
{
	abstract class BaseTriangle : BaseFigure
	{
		public int SideA { get; set; }
		public int SideB { get; set; }
		public int SideC { get; set; }

		public BaseTriangle()
		{

		}

		public BaseTriangle(int sideA, int sideB, int sideC)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		private double GetPerimeterFigure()
		{
			return (SideA + SideB + SideC) / 2;
		}

		public override double GetAreaFigure()
		{
			var p = GetPerimeterFigure();
			return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
		}
	}
}
