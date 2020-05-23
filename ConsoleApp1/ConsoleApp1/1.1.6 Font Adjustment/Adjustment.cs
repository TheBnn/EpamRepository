using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1_1_1._1._6_Font_Adjustment
{
	public static class Adjustment
	{

		public static void GetFont()
		{
            Fonts font = Fonts.None;

            Console.WriteLine("Параметры: {0}", font);
            Console.WriteLine("Введите: 1: bold \t 2: italic \t3: underline");


            StageTextType(font);
        }

        private static void StageTextType(Fonts font)
        {
            while (true)
            {
                string str = Console.ReadLine();
                int n = int.Parse(str);
                switch (n)
                {
                    case 1:
                        font = font ^ Fonts.Bold;
                        break;
                    case 2:
                        font = font ^ Fonts.Italic;
                        break;
                    case 3:
                        font = font ^ Fonts.Underline;
                        break;
                    case 0:
                        return;
                }
                Console.WriteLine("Параметры: {0}", font);
                Console.WriteLine("Введите: 1: bold \t 2: italic \t3: underline");
            }
        }

        [Flags]
        enum Fonts
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
        }
    }
}