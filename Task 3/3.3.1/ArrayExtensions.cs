using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3._1
{
	public static class ArrayExtensions
	{
        public static void Action(this int[] arr, Func<int, int> act)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = act(arr[i]);
        }

        public static void PrintArr(this int[] arr)
        {
            foreach (var item in arr)
                Console.Write($"{item}\t");
            Console.WriteLine();
        }

        public static void PrintArr(this int[] arr, string comment)
        {
            Console.WriteLine(comment);
            arr.PrintArr();
        }

        public static void FillRandom(this int[] arr, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(min, max);
        }

        public static int SumOfAll(this int[] arr)
        {
            if (arr == null) throw new NullReferenceException();
            return arr.Sum();
        }

        public static double Avg(this int[] arr)
        {
            if (arr == null) throw new NullReferenceException();
            return arr.Average();
        }

        public static int Prevalent(this int[] arr) => arr.GroupBy(a => a).OrderByDescending(b => b.Count()).FirstOrDefault().Key;
    }
}
