using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public static class ArrayTools
    {
        /// <summary>
        /// Задание 2: Реализовать рекурсивный алгоритм поиска максимального элемента в неотсортированном целочисленом массиве.
        /// </summary>
        public static int FindMaxIntElement(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputArray), "Input cannot be null or empty");
            }

            return FindMaxIntElement(inputArray, 0, int.MinValue);
        }

        /// <summary>
        /// Задание 2: Реализовать рекурсивный алгоритм поиска максимального элемента в неотсортированном целочисленом массиве.
        /// </summary>
        public static int FindMaxIntElement(int[] inputArray, int currentIterationIndex, int currentMaxElement)
        {
            if (currentIterationIndex < inputArray.Length)
            {
                if (inputArray[currentIterationIndex] > currentMaxElement)
                {
                    currentMaxElement = inputArray[currentIterationIndex];
                }

                return FindMaxIntElement(inputArray, currentIterationIndex + 1, currentMaxElement);
            }

            return currentMaxElement;
        }

        /// <summary>
        /// Задание 3: Реализовать алгоритм поиска в вещественном массиве индекса элемента, для которого сумма элементов слева и сумма элементов спарава равны. Если такого элемента не существует вернуть null (или -1).
        /// </summary>
        public static int FindSymmetryCenter(double[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputArray), "Input cannot be null or empty");
            }

            if (inputArray.Length == 1)
            {
                return 0;
            }

            double sumToTheRightOfCurrentIndex = 0;
            double sumToTheLeftOfCurrentIndex = inputArray[0];

            for (int i = 1; i < inputArray.Length; i++)
            {
                sumToTheRightOfCurrentIndex += inputArray[i];
            }

            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                sumToTheRightOfCurrentIndex -= inputArray[i];

                if (sumToTheLeftOfCurrentIndex == sumToTheRightOfCurrentIndex)
                {
                    return i;
                }

                sumToTheLeftOfCurrentIndex += inputArray[i];
            }

            return -1;
        }
    }
}
