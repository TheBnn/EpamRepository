using System;

namespace Task_4._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Режим работы");
			Console.WriteLine("1 - Слежка \n");
			Console.WriteLine("2 - Откат \n");
			Console.WriteLine("3 - Выход \n");

			bool next = true;

			while (next)
			{
				switch (Console.ReadLine())
				{
					case "1":
						Watcher.Watch();
						break;

					case "2": 
						Retracement.Retrace(); 
						break;
					case "3":
						next = false;
						break;
					default: break;
				}
			}
		}
	}
}
