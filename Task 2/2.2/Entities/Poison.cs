using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities.Bases
{
	class Poison : BaseDebuf
	{
		public void SetMinusMovement(int movement)
		{
			Player.MovementSpeed -= movement;
		}
	}
}
