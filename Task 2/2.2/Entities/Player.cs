using _2._2.Entities.Bases;
using _2._2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities
{
	class Player : Point, IMovable, ISnachable
	{
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
