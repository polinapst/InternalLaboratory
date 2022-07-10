using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public static class Methods
    {
        /// <summary>
        /// Задание 2: Реализовать рекурсивный алгоритм поиска максимального элемента в неотсортированном целочисленом массиве.
        /// </summary>
        public static int FindMaxIntElement(int[] a)
        {
            return FindMaxIntElement(a, 0, a.Length, int.MinValue);
        }

        /// <summary>
        /// Задание 2: Реализовать рекурсивный алгоритм поиска максимального элемента в неотсортированном целочисленом массиве.
        /// </summary>
        public static int FindMaxIntElement(int[] a, int i, int size, int currentMax)
        {
            if (i < size)
            {
                if (a[i] > currentMax)
                {
                    currentMax = a[i];
                }

                return FindMaxIntElement(a, i + 1, a.Length, currentMax);
            }
            
            return currentMax;
        }

        /// <summary>
        /// Задание 3: Реализовать алгоритм поиска в вещественном массиве индекса элемента, для которого сумма элементов слева и сумма элементов спарава равны. Если такого элемента не существует вернуть null (или -1).
        /// </summary>
        public static int FindSymmetryCenter(double[] a)
        {
            double sumOnTheRight = 0;
            double sumOnTheLeft = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                sumOnTheRight += a[i];
            }

            for (int i = 1; i < a.Length - 1; i++)
            {                
                sumOnTheRight -= a[i];

                if (sumOnTheLeft == sumOnTheRight)
                {
                    return i;
                }

                sumOnTheLeft += a[i];
            }

            return -1;
        }

        /// <summary>
        /// Задание 4: Реализовать алгоритм конкатенации двух строк, содержащих только символы латинского алфавита, исключая повторяющиеся символы.
        /// </summary>
        public static string ConcatNonrepeating(string a, string b)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in a)
            {
                if (sb.ToString().IndexOf(c) < 0)
                {
                    sb.Append(c);
                }
            }

            foreach (char c in b)
            {
                if (sb.ToString().IndexOf(c) < 0)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Реализовать метод FindNextBiggerNumber, который принимает положительное целое число и возвращает ближайшее наибольшее целое, состоящее из цифр исходного числа, и null (или -1), если такого числа не существует.
        /// </summary>
        public static int FindNextBiggerNumber(int n)
        {
            char[] arrayOfDigitChars = n.ToString().ToCharArray();
            int result = -1;

            if (arrayOfDigitChars.Length == 1)
            {
                return result;
            }

            for (int i = arrayOfDigitChars.Length - 2; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (arrayOfDigitChars[j].CompareTo(arrayOfDigitChars[j + 1]) < 0)
                    {
                        char temp = arrayOfDigitChars[j + 1];
                        arrayOfDigitChars[j + 1] = arrayOfDigitChars[j];
                        arrayOfDigitChars[j] = temp;

                        arrayOfDigitChars = SortCharArrayAfterIndex(arrayOfDigitChars, j + 1);

                        string s = new string(arrayOfDigitChars);
                        int.TryParse(s, out result);

                        if (result == n)
                        {
                            return -1;
                        }

                        return result;
                    }
                }
            }

            return result;
        }

        private static char[] SortCharArrayAfterIndex(char[] a, int index)
        {
            int n = 2;

            for (int i = index; i <= a.Length - n; n++)
            {
                for (int j = i; j <= a.Length - n; j++)
                {
                    if (a[j].CompareTo(a[j + 1]) > 0)
                    {
                        char temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }

            return a;
        }
    }
}
