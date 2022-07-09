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

        /// <summary>
        /// Задание 3: Реализовать алгоритм поиска в вещественном массиве индекса элемента, для которого сумма элементов слева и сумма элементов спарава равны. Если такого элемента не существует вернуть null (или -1).
        /// </summary>
        public static int SymmetryCenter(double[] a)
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
    }
}
