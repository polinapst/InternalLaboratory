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

		public static void SwapMultidimentionalIntArrayRows(ref int[,] inputArray, int firstIndex, int secondIndex)
        {			
			int columns = inputArray.GetUpperBound(1) + 1;
			int rowByteLength = 4 * columns;
			int[] temp = new int[columns];
			int firstArrayOffset = firstIndex * rowByteLength;
			int secondArrayOffset = secondIndex * rowByteLength;

			System.Buffer.BlockCopy(inputArray, firstArrayOffset, temp, 0, rowByteLength);
			System.Buffer.BlockCopy(inputArray, secondArrayOffset, inputArray, firstArrayOffset, rowByteLength);
			System.Buffer.BlockCopy(temp, 0, inputArray, secondArrayOffset, rowByteLength);
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
