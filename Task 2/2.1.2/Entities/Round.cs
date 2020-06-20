using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2._1._2.Entities
{
	class Round : BaseCircle
	{
		public Round(Point point, double outherRadius)
		{
			CenterPoint = point;
			OutherRadius = outherRadius;
		}
	}
}
