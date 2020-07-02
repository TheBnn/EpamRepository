using _2._2.Entities.Bases;
using _2._2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities
{
	class Player : Point, IMovable, ISnachable
	{
		public Point Point { get; set; }
		public string Name { get; set; }
		public int Healths { get; set; }
		public int MovementSpeed { get; set; }

		public Player(Point spawnPoint)
		{
			Point = spawnPoint;
		}

		public void Move()
		{
			Console.WriteLine("Двигаюсь ууууу");
		}

		public void Snach()
		{

			Console.WriteLine("МММ Бонус");
		}
	}
}
