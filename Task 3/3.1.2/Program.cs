﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._1._2
{
	class Program
	{
		static void Main(string[] args)
		{

			//Пока-что хардкодом. Можно было сделать чтение из файла но пожалуй как нибудь потом. 
			var _tempStringTemplate = $"Chicago, the state of Illinois, is known Chicago, the state of Illinois, is known Chicago, the state of Illinois, is known as The Second City, which refers to its rebuilding after the fire. The current city is literally the second Chicago, after the one that disappeared in 1871. It can also refer to the city’s long-held position as the United States’ second largest city, after New York City. Today, Chicago is called as The Windy City. You might suspect that Chicago got this nickname from the winds off Lake Michigan, which shove through the downtown corridors with intense force.But the true origin of the saying comes from politics.Some say it may have been coined by rivals like Cincinnati and New York as a derogatory reference to the Chicagoan endless political conventions. Others say that the term originated from the fact that Chicago politicians change their minds as \"often as the wind.\" Finally, the city is often named as The City That Works.It refers to Chicago’s labor tradition and the long hours worked by its residents, its willingness to tackle grand civic projects and to make fortunes for a lucky few.The city is bidding for the 2016 Olympics, a new reason to build vast and wild. As the hub of the Midwest, Chicago is easy to find.Its picturesque skyline calls across the waters of Lake Michigan.The first impression one can get lies in the world -class museums of art and science miles of sandy beaches, huge parks and public art, and perhaps the finest downtown collection of modern architecture in the world.Chicago is the home of the blues and the truth of jazz, and the heart of comedy.Here the age of railroads found its center, and airplanes followed suit. It’s a city with a swagger, but without the surliness or even the fake smiles found in other cities of its size. With a wealth of iconic sights and neighborhoods to explore, there’s enough to fill a visit of days, weeks, or even months without ever seeing the end. Dress warm in the winter, and prepare to cover a lot of ground: the meaning of Chicago is only found in movement, through subways and archaic elevated tracks, in the pride of tired feet and eyes raised once more to the sky.";


			Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

			var _tempArrayStrings = _tempStringTemplate.ToLower().Split(new[] { '-',',', '.', ' ', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
			var _temp = _tempArrayStrings;

			foreach (var item in _tempArrayStrings)
			{
				keyValuePairs[item] = _temp.Count(i => i == item);
			}





			foreach (var item in keyValuePairs.OrderByDescending(i => i.Value))
			{
				if(item.Value > keyValuePairs.Count / 100) { 
					Console.WriteLine(item);
				}

			}
		}
	}
}
