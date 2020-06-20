using System;

namespace CString
{
    public class CustomString
    {
        private const int StartIndex = 0;
        private char[] customString;
        private int length = 0; //длина данных в массиве
        private float multy = (float)1.5; //коэффициент запаса пустых ячеек массива

        public CustomString() { }

        /// <summary>
        /// </summary>
        /// <param name="executer"></param>
        public CustomString(int executer)
        {
            length = executer;
            customString = new char[(int)(executer * multy)];
        }
        /// <summary>
        /// </summary>
        /// <param name="charArray"></param>
        public CustomString(char[] charArray) : this(charArray.Length)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                customString[i] = charArray[i];
            }
        }

        public CustomString(string str) : this(str.ToCharArray()) { }

        public CustomString(CustomString str) : this(str.ToCharArray()) { }

        public CustomString(CustomString str, int index, int length) : this(length > str.Length ? str.Length : length)
        {
            for (int i = index; i < i + length; i++)
            {
                customString[i] = str[i];
            }
        }
        private void ExpandLenght(int targetLength)
        {
            char[] _temp = new char[(int)(targetLength * multy)];
            for (int i = 0; i < length; i++)
            {
                _temp[i] = customString[i];
            }
            customString = _temp;
        }

        public char this[int index]
        {
            get => customString[index];
            set
            {
                if (index >= customString.Length)
                {
                    ExpandLenght(index);
                    length = index + 1;
                }
                if (index >= length)
                    length = index + 1;
                customString[index] = value;
            }
        }

        public uint Capacity => (uint)customString.Length;

        public int Length => length;

        public float Multilier
        {
            get => multy;
            set
            {
                if (value > 1 && value <= 3)
                    multy = value;
                else
                    multy = (float)1.5;
            }
        }

        public static implicit operator CustomString(string str)
        {
            return new CustomString(str);
        }

        public static implicit operator string(CustomString str)
        {
            return str.ToString();
        }

        public static CustomString operator +(CustomString str1, CustomString str2)
        {
            return str1.ConcatString(str2);
        }

        public CustomString ConcatString(string str)
        {
            CustomString temp = new CustomString(customString);
            for (int i = 0; i < str.Length; i++)
            {
                temp[length + i] = str[i];
            }
            return temp;
        }

        public CustomString ConcatString(CustomString str)
        {
            return ConcatString((string)str);
        }

        public char[] ToCharArray()
        {
            char[] temp = new char[length];
            for (int i = 0; i < length; i++)
            {
                temp[i] = customString[i];
            }
            return temp;
        }
        public int FindSymbol(char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                if (customString[i] == symbol)
                {
                    return i;
                }
            }

            return -1;
        }

        // -1 если символ не найден
        public int FindLastSymbol(char symbol)
        {
            var index = -1;
            for (int i = 0; i < length; i++)
            {
                if (customString[i] == symbol)
                {
                    index = i;
                }
            }

            return index;
        }

        /// <summary>
        /// 0 => равны (посимвольно)
        /// 1 => равны по длине
        /// 2 => строка длинее str
        /// 3 => строка короче str
        /// </summary>
        /// <param type="CString" name="firstString"></param>
        /// <param type="CString" name="secondString"></param>
        /// <returns></returns>
        static public int CompareString(CustomString firstString, CustomString secondString)
        {
            if (firstString?.Length > secondString?.Length)
            {
                return 2;
            }

            if (firstString?.Length < secondString?.Length)
            {
                return 3;
            }

            for (int i = 0; i < firstString?.Length; i++)
            {
                if (firstString?[i] != secondString?[i])
                {
                    return 1;
                }
            }
            return 0;
        }
        public int Compare(CustomString str)
        {
            return CompareString(this, str);
        }

        public bool ReplaceChar(char input, char output)
        {
            int changes = 0;
            for (int i = 0; i < length; i++)
            {
                if (customString[i] == input)
                {
                    customString[i] = output;
                    changes++;
                }
            }

            if (changes > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteByIndexChar(int index, int length)
        {
            for (int i = index; i < index + length; i++)
            {
                customString[i] = (char)0;
            }
        }

        public void TrimCharArray()
        {
            int firstIndex = 0;
            int lastIndex = customString.Length - 1;

            for (int i = 0; i < customString.Length && customString[i] == 0; i++)
            {
                firstIndex = i;
            }

            for (int i = customString.Length - 1; i > 0 && customString[i] == 0; i--)
            {
                lastIndex = i;
            }

            char[] temp = new char[lastIndex - firstIndex];
            for (int i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = customString[firstIndex + i + 1];
            }
            customString = temp;
            length = lastIndex - firstIndex;
        }

        public override string ToString()
        {
            return new string(value: customString,
                              startIndex: StartIndex,
                              length: length);
        }
    }
}
