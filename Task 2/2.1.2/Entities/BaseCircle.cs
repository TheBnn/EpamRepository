using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2._1._2.Entities
{
	abstract class BaseCircle : BaseFigure
	{
		public double OutherRadius { get; set; }
		public double InnerRadius { get; set; }

		public BaseCircle()
		{
				
		}
		public BaseCircle(double outherRadius, double innerRadius = 0)
		{
			OutherRadius = outherRadius;
			InnerRadius = innerRadius;
		}

		public override double GetAreaFigure()
		{
			var area = 0.0;
			if (InnerRadius == 0)
			{
				area = Math.PI * (OutherRadius * OutherRadius);
			}
			else
			{
				area = 4 * (Math.PI * Math.PI) * (OutherRadius * InnerRadius);
			}

			return area;
		}

		//TODO
		//Чет не додумался как обьединить в 1 метод :C
		//Наверное надо было делать от типа фигуры 
		//Что-то вроде 
		//GetOutherLengthCircle(T) {  
		//	if(Torus)//do somthing    
		//	if(Round)//do else  
		//}
		public double GetOutherLengthCircle()
		{
			return 2 * Math.PI * OutherRadius;
		}
		public double GetInnerLengthCircle()
		{
			return 2 * Math.PI * InnerRadius;
		}

		public double GetSumLengthRadiusCircle()
		{
			return GetOutherLengthCircle() + GetInnerLengthCircle();
		}

	}
}
