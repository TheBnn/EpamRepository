using System;
using System.Drawing;

namespace _2._1._2.Entities
{
	class Line : BaseFigure
	{
		public Point StartPoint { get; set; }
		public Point EndPoint { get; set; }
		private double length
		{
			get { return length; }
			set
			{
				length = Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2));
			}
		}

		public Line(Point startPoint, Point endPoint)
		{
			CenterPoint = new Point( (startPoint.X + endPoint.X)/2 , (startPoint.Y + endPoint.Y)/2);
			StartPoint = startPoint;
			EndPoint = endPoint;
		}

	}
}
