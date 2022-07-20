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

        /// <summary>
        /// Задание 6: Реализовать метод FilterDigit который принимает массив целых чисел и фильтрует его таким образом, 
        /// чтобы на выходе остались только числа, содержащие заданную цифру (LINQ-запросы не использовать!) 
        /// Например, для цифры 7, FilterDigit (7,1,2,3,4,5,6,7,68,69,70, 15,17) -> {7, 7, 70, 17}. 
        /// Разработать модульные тесты (NUnit и MS Unit Test (включая подход DDT)) для тестирования метода.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="filterDigit"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static int[] FilterDigit(int[] inputArray, int filterDigit)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputArray), "Input cannot be null or empty");
            }

            if (filterDigit > 9 || filterDigit < 0)
            {
                throw new ArgumentException("The filter int has to be a single-digit positive number", nameof(filterDigit));
            }

            List<int> resultList = new();

            foreach (int number in inputArray)
            {
                if (number.ToString().IndexOf(char.Parse(filterDigit.ToString())) >= 0)
                {
                    resultList.Add(number);
                }
            }

            return resultList.ToArray();
        }
    }
}
