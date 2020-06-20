using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2._1._2.Entities
{
	class Torus : BaseCircle
	{
		public Torus(Point point, double outherRadius, double innerRadius)
		{
			CenterPoint = point;
			OutherRadius = outherRadius;
			InnerRadius = innerRadius;
		}
	}
}
