using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelperMethods.ArrayMethods;

namespace Module3
{
    public class ArrayBubleSort
    {
        private static int sumOfARow(int[] inputArray)
        {
            int sum = 0;

            foreach (int item in inputArray)
            {
                sum += item;
            }

            return sum;
        }

        public static int[][] BubleSortArrayRowSumAscending(int[][] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputArray), "Array cannot be null or empty");
            }

            for (int i = 1; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - i; j++)
                {
                    if (inputArray[j] == null || inputArray[j].Length == 0 
                        || inputArray[j + 1] == null || inputArray[j + 1].Length == 0)
                    {
                        throw new ArgumentNullException(nameof(inputArray), "Rows cannot be empty");
                    }

                    if (sumOfARow(inputArray[j]) > sumOfARow(inputArray[j + 1]))
                    {
                        SwapArrayElements(ref inputArray, j, j + 1);
                    }
                }
            }
            
            return inputArray;
        }

        public static int[][] BubleSortArrayRowSumDescending(int[][] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputArray), "Array cannot be null or empty");
            }

            for (int i = 1; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - i; j++)
                {
                    if (inputArray[j] == null || inputArray[j].Length == 0
                        || inputArray[j + 1] == null || inputArray[j + 1].Length == 0)
                    {
                        throw new ArgumentNullException(nameof(inputArray), "Rows cannot be empty");
                    }

                    if (sumOfARow(inputArray[j]) < sumOfARow(inputArray[j + 1]))
                    {
                        SwapArrayElements(ref inputArray, j, j + 1);
                    }
                }
            }

            return inputArray;
        }

        public static int[][] BubleSortByMaxRowElementAscending(int[][] inputArray)
        {
            int[] maxElementArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                maxElementArray[i] = FindMaxArrayElement(inputArray[i]);
            }

            for (int i = 1; i < maxElementArray.Length; i++)
            {
                for (int j = 0; j < maxElementArray.Length - i; j++)
                {
                    if (maxElementArray[j] > maxElementArray[j + 1])
                    {
                        SwapArrayElements(ref maxElementArray, j, j + 1);
                        SwapArrayElements(ref inputArray, j, j + 1);
                    }
                }
            }

            return inputArray;
        }

        public static int[][] BubleSortByMaxRowElementDescending(int[][] inputArray)
        {
            int[] maxElementArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                maxElementArray[i] = FindMaxArrayElement(inputArray[i]);
            }

            for (int i = 1; i < maxElementArray.Length; i++)
            {
                for (int j = 0; j < maxElementArray.Length - i; j++)
                {
                    if (maxElementArray[j] < maxElementArray[j + 1])
                    {
                        SwapArrayElements(ref maxElementArray, j, j + 1);
                        SwapArrayElements(ref inputArray, j, j + 1);
                    }
                }
            }

            return inputArray;
        }

        public static int[][] BubleSortByMinRowElementAscending(int[][] inputArray)
        {
            int[] minElementArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                minElementArray[i] = FindMinArrayElement(inputArray[i]);
            }

            for (int i = 1; i < minElementArray.Length; i++)
            {
                for (int j = 0; j < minElementArray.Length - i; j++)
                {
                    if (minElementArray[j] < minElementArray[j + 1])
                    {
                        SwapArrayElements(ref minElementArray, j, j + 1);
                        SwapArrayElements(ref inputArray, j, j + 1);
                    }
                }
            }

            return inputArray;
        }

        public static int[][] BubleSortByMinRowElementDescending(int[][] inputArray)
        {
            int[] minElementArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                minElementArray[i] = FindMinArrayElement(inputArray[i]);
            }

            for (int i = 1; i < minElementArray.Length; i++)
            {
                for (int j = 0; j < minElementArray.Length - i; j++)
                {
                    if (minElementArray[j] < minElementArray[j + 1])
                    {
                        SwapArrayElements(ref minElementArray, j, j + 1);
                        SwapArrayElements(ref inputArray, j, j + 1);
                    }
                }
            }

            return inputArray;
        }
    }
}
