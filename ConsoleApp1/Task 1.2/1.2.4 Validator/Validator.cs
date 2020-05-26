using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_1._2._1._2._4_Validator
{
	class Validator
	{

		public static void GetValidate()
		{
            Console.WriteLine("Entry: ");
            var someString = Console.ReadLine();

            string[] temp = Regex.Split(someString, @"(?<=[.?!])\s");

            Console.WriteLine("Respons: ")
                ;
            for (int i = 0; i < temp.Length; i++)
            {
                char[] arr = temp[i].ToCharArray();
                arr[0] = char.ToUpper(arr[0]);
                Console.Write(new string(arr) + " ");
            }
        }


	}
}
