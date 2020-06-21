using _2._1._2.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2._1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<object> storage = new List<object>();

			int userChose;
			bool next = false;
			bool userChoseValidator;
			int x, y;

			while (!next)
			{
				Console.WriteLine("Выберите фигуру: \n\t");
				Console.WriteLine("\n1.Line  \n2.Rectangle \n3.Round \n4.Square  \n5.Torus \n6.Triangle");
				Console.WriteLine("\n11.Show All  \n22.clear");

				Console.Write("\nFigure: ");
				userChoseValidator = int.TryParse(Console.ReadLine(), out userChose);

				if (userChoseValidator == false)
				{
					Console.WriteLine("Enter integer value: ");
					userChoseValidator = int.TryParse(Console.ReadLine(), out userChose);
				}

				switch (userChose)
				{
					case 1:
						Console.WriteLine("Start X: ");
						x = int.Parse(Console.ReadLine());
						Console.WriteLine("Start Y: ");
						y = int.Parse(Console.ReadLine());
						Point startPoint = new Point(x, y);

						Console.WriteLine("End X: ");
						var x2 = int.Parse(Console.ReadLine());
						Console.WriteLine("End Y: ");
						var y2 = int.Parse(Console.ReadLine());
						Point endPoint = new Point(x2, y2);
						storage.Add(new Line(startPoint, endPoint));

						break;
					case 2:
						Console.WriteLine("Center point X: ");
						x = int.Parse(Console.ReadLine());
						Console.WriteLine("Center point Y: ");
						y = int.Parse(Console.ReadLine());
						Point point = new Point(x, y);

						Console.WriteLine("Side A: ");
						x = int.Parse(Console.ReadLine());
						Console.WriteLine("Side B: ");
						y = int.Parse(Console.ReadLine());

						storage.Add(new Entities.Rectangle(point, x, y));
						break;
					case 3:
						Console.WriteLine("Start X: ");
						x = int.Parse(Console.ReadLine());
						Console.WriteLine("Start Y: ");
						y = int.Parse(Console.ReadLine());
						Point c = new Point(x, y);

						Console.WriteLine("Start X: ");
						var R = int.Parse(Console.ReadLine());

						storage.Add(new Round(c, R));
						break;
					case 4:
						Console.WriteLine("Start X: ");
						x = int.Parse(Console.ReadLine());
						Console.WriteLine("Start Y: ");
						y = int.Parse(Console.ReadLine());
						Point S = new Point(x, y);

						Console.WriteLine("Side A: ");
						x = int.Parse(Console.ReadLine());

						storage.Add(new Square(S, x));
						break;
					case 5:
						Console.WriteLine("Start X: ");
						x = int.Parse(Console.ReadLine());
						Console.WriteLine("Start Y: ");
						y = int.Parse(Console.ReadLine());
						Point z = new Point(x, y);

						Console.WriteLine("Outher radius R: ");
						R = int.Parse(Console.ReadLine());
						Console.WriteLine("Inner radius r: ");
						var r = int.Parse(Console.ReadLine());

						storage.Add(new Torus(z, R, r));
						break;
					case 6:
						Console.WriteLine("Start X: ");
						x = int.Parse(Console.ReadLine());
						Console.WriteLine("Start Y: ");
						y = int.Parse(Console.ReadLine());
						Point point1 = new Point(x, y);


						Console.WriteLine("Side A: ");
						x = int.Parse(Console.ReadLine());
						Console.WriteLine("Side B: ");
						y = int.Parse(Console.ReadLine());
						Console.WriteLine("Side C: ");
						var n = int.Parse(Console.ReadLine());

						var a = new Triangle(point1, x, y, n);

						storage.Add(a);
						break;

					case 11:
						foreach (var item in storage)
						{
							///???????
						}
						break;
					case 22:
						storage.Clear();
						break;
					default:
						next = true;
						break;
				}
			}
		}
	}
}
