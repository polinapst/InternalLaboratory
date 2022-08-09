using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    public static class ArrayMethods
    {
        public static void SwapArrayElements<T>(ref T[] inputArray, int firstIndex, int secondIndex)
        {
            T temp = inputArray[firstIndex];
            inputArray[firstIndex] = inputArray[secondIndex];
            inputArray[secondIndex] = temp;
        }

		public static int FindMaxArrayElement(int[] inputArray)
		{
			int max = int.MinValue;

			for (int i = 0; i < inputArray.Length; i++)
			{
				if (inputArray[i] > max)
				{
					max = inputArray[i];
				}
			}

			return max;
		}

		public static int FindMinArrayElement(int[] inputArray)
		{
			int min = int.MaxValue;

			for (int i = 0; i < inputArray.Length; i++)
			{
				if (inputArray[i] < min)
				{
					min = inputArray[i];
				}
			}

			return min;
		}
	}
}
