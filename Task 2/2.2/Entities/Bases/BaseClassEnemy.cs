using _2._2.Entities.Bases;
using _2._2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities
{
	class BaseClassEnemy : Point, IMovable, ISnachable
	{
		public string Name { get; set; }
		public int MovementSpeed { get; set; }

		public void Move()
		{
			//Двигаюсь по какому либо алгоритму
			Console.WriteLine("Поймаю отниму");
		}

		public void Snach()
		{
			Console.WriteLine("Поймал отнял");
		}
	}
}
