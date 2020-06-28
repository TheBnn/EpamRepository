using _2._2.Entities.Bases;
using _2._2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.Entities
{
	class BaseItem : Point, ISnachable
	{
		public string Name { get; set; }

		//Наверное надо было баффы и дебаффы реализовывать через интерфейсы. 
		//Что-то меня смущает текущая стркутура типо от айтема наследуются бафф и дебафф 
		//а если я захочу айтем который будет бафать и дебафать у меня такой создать не выйдет....
		public void Snach()
		{
			//I've fallen, and I can't get up!
		}
	}
}
