using _2._2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities
{
	class WolfEnemy : BaseClassEnemy
	{
		WolfEnemy()
		{
			Name = "Wolfy";
			MovementSpeed = 20;
		}
	}
}
