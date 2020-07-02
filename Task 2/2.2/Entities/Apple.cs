using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities
{
	class Apple : BaseBuf
	{
		public void SetPlusHeath(int health)
		{
			Player.Healths += health;
		}
	}
}
