using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите N:");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите x:");
			int x = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"ВЫВОД: Сгенерирован круг людей. Начинаем вычеркивать каждого {x}.");



			List<int> people = new List<int>(Enumerable.Range(1, n));

			int count = 0;
			while (people.Count != 1)
			{
				count++;
				if (people.Count == x-1)
				{
					Console.WriteLine();
					for (int i = 0; i < people.Count; i++)
					{
						Console.WriteLine($"{people[i]}");
					}
					Console.WriteLine("Game Over");
					break;
				}

				Console.WriteLine(String.Join(",", people));

				try
				{
					people.RemoveAt(x-1);
				}
				catch (Exception)
				{
					Console.WriteLine("Невозможно вычеркнуть колличество оставшихся элементов меньше индекса вычеркиваемого");
					break;
				}

				Console.WriteLine("Раунд "+ count);
			}

		}
		private static void SomeMethod()
		{
			Console.WriteLine("Введите N:");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите x:");
			int k = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"ВЫВОД: Сгенерирован круг людей. Начинаем вычеркивать каждого {k}.");

			Queue<int> peoples = new Queue<int>(Enumerable.Range(1, n));
			int count = 1;
			while (peoples.Count != 1)
			{

				for (int i = 1; i <= k; ++i)
				{
					int x = peoples.Dequeue();
					if (i != k)
					{
						peoples.Enqueue(x);
					}
				}
				Console.WriteLine($"Раунд {count}. Вычеркнут человек. Oсталось: {peoples.Count}");
				count++;
			}
			Console.WriteLine($"Остался номер {peoples.Dequeue()}");
		}

	}
}

