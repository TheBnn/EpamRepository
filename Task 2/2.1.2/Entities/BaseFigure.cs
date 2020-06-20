using System.Drawing;

namespace _2._1._2
{

	/// <summary>
	/// По хорошему тут надо было использовать интерфейс... но мне лень...
	/// </summary>
	abstract class BaseFigure
	{
		public Point CenterPoint { get; set; }

		public BaseFigure()
		{
		}
		public BaseFigure(Point center)
		{
			CenterPoint = center;
		}

		public virtual double GetAreaFigure() { return 0.0; }

		public Point GetCenterPoint() { return CenterPoint; }

	}
}
