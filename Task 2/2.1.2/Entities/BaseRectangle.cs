using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1._2.Entities
{
	abstract class BaseRectangle : BaseFigure
	{
		//Можно было сделать  еще и по координатам но мне лень
		public double LengthSideA { get; set; }
		public double LengthSideB { get; set; }

		public BaseRectangle()
		{

		}
		public BaseRectangle(double lengthSideA)
		{
			LengthSideA = lengthSideA;
		}
		public BaseRectangle(double lengthSideA, double lengthSideB)
		{
			LengthSideA = lengthSideA;
			LengthSideB = lengthSideB;
		}

		public override double GetAreaFigure()
		{ 
			if(LengthSideB > 0) {
				return LengthSideA * LengthSideB;
			}
			else
			{
				return LengthSideA * LengthSideA;
			}
		}
	}
}
