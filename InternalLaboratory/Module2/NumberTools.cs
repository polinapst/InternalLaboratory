using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public static class NumberTools
    {
        /// <summary>
        /// Задание 5: Реализовать метод FindNextBiggerNumber, который принимает положительное целое число 
        /// и возвращает ближайшее наибольшее целое, состоящее из цифр исходного числа, и null (или -1), 
        /// если такого числа не существует.
        /// </summary>
        public static int FindNextBiggerNumber(int inputNumber)
        {
            if (inputNumber < 1)
            {
                throw new ArgumentException("Input number has to be positive", nameof(inputNumber));
            }

            char[] arrayOfDigitChars = inputNumber.ToString().ToCharArray();
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
                        arrayOfDigitChars = SwitchElementsOfAnArray(arrayOfDigitChars, j, j + 1);
                        arrayOfDigitChars = SortCharArrayAfterIndex(arrayOfDigitChars, j + 1);

                        string s = new string(arrayOfDigitChars);
                        int.TryParse(s, out result);

                        if (result == inputNumber)
                        {
                            return -1;
                        }

                        return result;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Задание 5: Реализовать метод FindNextBiggerNumber, который принимает положительное целое число 
        /// и возвращает ближайшее наибольшее целое, состоящее из цифр исходного числа, и null (или -1), 
        /// если такого числа не существует.
        /// </summary>
        public static int FindNextBiggerNumber(int inputNumber, out string executionTime)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int methodResult = FindNextBiggerNumber(inputNumber);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            executionTime = ts.ToString(@"dd\.hh\:mm\:ss\:fffffff");
            return methodResult;
        }

        private static char[] SortCharArrayAfterIndex(char[] inputArray, int index)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputArray), "Input cannot be null or empty");
            }

            if (index >= inputArray.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be equal or greater than the array's length or less than zero");
            }

            if (inputArray.Length == 1 || index == inputArray.Length - 1)
            {
                return inputArray;
            }

            int n = 2;

            for (int i = index; i <= inputArray.Length - n; n++)
            {
                for (int j = i; j <= inputArray.Length - n; j++)
                {
                    if (inputArray[j].CompareTo(inputArray[j + 1]) > 0)
                    {
                        inputArray = SwitchElementsOfAnArray(inputArray, j, j + 1);
                    }
                }
            }

            return inputArray;
        }

        private static char[] SwitchElementsOfAnArray(char[] inputArray, int firstElement, int secondElement)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException(nameof(inputArray), "Input cannot be null");
            }

            if (inputArray.Length < 2)
            {
                throw new ArgumentException("To perform a switch of elements the array has to contain at least two of those", nameof(inputArray));
            }

            if (firstElement >= inputArray.Length || firstElement < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(firstElement), "Index cannot be equal or greater than the array's length or less than zero");
            }

            if (secondElement >= inputArray.Length || firstElement < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(secondElement), "Index cannot be equal or greater than the array's length or less than zero");
            }

            if (firstElement == secondElement)
            {
                return inputArray;
            }

            char temp = inputArray[secondElement];
            inputArray[secondElement] = inputArray[firstElement];
            inputArray[firstElement] = temp;

            return inputArray;
        }
        /// <summary>
        /// Задание 1: Даны два целых знаковых четырех байтовых числа и две позиции битов i и j (i<j). 
        /// Реализовать алгоритм InsertNumber вставки битов с j-ого по i-ый бит одного числа в другое так, 
        /// чтобы биты второго числа занимали позиции с бита j по бит i (биты нумеруются справа налево). 
        /// Разработать модульные тесты (NUnit и(!) MS Unit Test) для тестирования метода. 
        /// (Ниже пояснение к алгоритму).
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static int InsertNumber(int numberA, int numberB, int i, int j)
        {
            if (i < 0 || i > 31)
            {
                throw new ArgumentException("Index cannot be less than zero or bigger thatn 31", nameof(i));
            }

            if (j < 0 || j > 31)
            {
                throw new ArgumentException("Index cannot be less than zero or bigger thatn 31", nameof(j));
            }

            if (i > j)
            {
                throw new ArgumentException("Index i cannot be greater than index j", nameof(i));
            }

            char[] numberACharArray = Convert.ToString(numberA, 2).ToCharArray();
            char[] numberBCharArray = Convert.ToString(numberB, 2).ToCharArray();
            Array.Reverse(numberACharArray);
            Array.Reverse(numberBCharArray);

            char[] result = new char[Math.Max(Math.Max(numberACharArray.Length, numberBCharArray.Length), j + 1)];
            numberACharArray.CopyTo(result, 0);

            for (int k = 0, l = i; k <= j - i && k < numberBCharArray.Length; k++, l++)
            {
                result[l] = numberBCharArray[k];
            }

            Array.Reverse(result);

            string s = new string(result).Trim('\0').Replace('\0', '0');
            return Convert.ToInt32(s, 2);
        }
    }
}