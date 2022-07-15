using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public static class StringTools
    {
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
        /// Задание 4: Реализовать алгоритм конкатенации двух строк, содержащих только символы латинского алфавита, исключая повторяющиеся символы.
        /// </summary>
        public static string ConcatNonrepeating(string inputStringA, string inputStringB)
        {
            if (inputStringA == null || inputStringA.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputStringA), "Input cannot be null or empty");
            }

            if (inputStringB == null || inputStringB.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputStringB), "Input cannot be null or empty");
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (char character in inputStringA)
            {
                if (stringBuilder.ToString().IndexOf(character) < 0)
                {
                    stringBuilder.Append(character);
                }
            }

            foreach (char character in inputStringB)
            {
                if (stringBuilder.ToString().IndexOf(character) < 0)
                {
                    stringBuilder.Append(character);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
