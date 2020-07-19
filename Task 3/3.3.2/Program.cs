using System;
using System.Linq;

namespace _3._3._2
{
	class Program
	{
		static void Main(string[] args)
		{
            string str = "01FA#1";

            Console.WriteLine(str.ShowMyType());
        }
    }
    public static class SupStr
    {
        public enum StringTypes
        {
            Russian,
            English,
            Number,
            Mixed
        }
        public static StringTypes ShowMyType(this string str)
        {
            string rus = "абвгдеёзжийклмнопрстуфхцчшщъыьэюя";
            string eng = "abcdefghijklmnopqrstuvwxyz";
            string num = "0123456789";

            str = str.ToLower();
            if (str.Except(rus).Count() == 0)
                return StringTypes.Russian;
            if (str.Except(eng).Count() == 0)
                return StringTypes.English;
            if (str.Except(num).Count() == 0)
                return StringTypes.Number;
            return StringTypes.Mixed;
        }
    }
}
