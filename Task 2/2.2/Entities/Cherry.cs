﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities
{
	class Cherry : BaseBuf
	{
		public void SetPlusMovement(int movement)
		{
			Player.MovementSpeed += movement;
		}
	}
}
