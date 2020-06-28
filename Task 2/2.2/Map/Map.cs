using _2._2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Map
{
	class Map
	{
		public int MapWidth { get; set; }
		public int MapHeight { get; set; }


		public int countBufsInMap { get; set; }
		public int countDebufsInMap { get; set; }
		public int countEnemyInMap { get; set; }
		public Player Player { get; set; }

		public List<object> ObjectsInMap { get; set; }

		public WolfEnemy WolfEnemy { get; set; }
		public BearEnemy BearEnemy { get; set; }

	}
}
