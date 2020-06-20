using _2._1._2.Entities;
using System;
using System.Drawing;

namespace _2._1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Round round = new Round(new Point(0, 0), 10);

			Console.WriteLine(round.GetAreaFigure());
			Console.WriteLine(round.GetInnerLengthCircle());
			Console.WriteLine(round.GetOutherLengthCircle());
			Console.WriteLine(round.GetSumLengthRadiusCircle());

			Console.WriteLine("-----");
			Torus r = new Torus(new Point(0, 0), 10, 5);

			Console.WriteLine(r.GetAreaFigure());
			Console.WriteLine(r.GetInnerLengthCircle());
			Console.WriteLine(r.GetOutherLengthCircle());
			Console.WriteLine(r.GetSumLengthRadiusCircle());
		}
	}
}
