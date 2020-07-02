using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities.Bases
{
	class Thorns : BaseDebuf
	{
		public void SetMinusHealh(int heath)
		{
			Player.Healths -= heath;
		}

	}
}
