using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    static class Search
    {
        /// <summary>
        /// Задание 2: Реализовать рекурсивный алгоритм поиска максимального элемента в неотсортированном целочисленом массиве.
        /// </summary>
        public static int MaxIntElement(int[] a)
        {
            return MaxIntElement(a, 0, a.Length, int.MinValue);
        }

        public static int MaxIntElement(int[] a, int i, int size, int currentMax)
        {
            if (i < size)
            {
                if (a[i] > currentMax)
                {
                    currentMax = a[i];
                }

                return MaxIntElement(a, i + 1, a.Length, currentMax);
            }
            
            return currentMax;
        }
    }
}
