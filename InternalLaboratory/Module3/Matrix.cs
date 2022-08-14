using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelperMethods.ArrayMethods;

namespace Module3
{
    public class Matrix
    {
        private int[,] matrixArray;
        readonly int _rows;
        readonly int _columns;
        int currentMaxElement;

        public Matrix(int rows = 10, int columns = 10, int maxElement = 9)
        {
            matrixArray = new int[rows, columns];
            _rows = rows;
            _columns = columns;

            FillInMatrix(maxElement);
            currentMaxElement = maxElement;
        }

        public void FillInMatrix(int maxElement)
        {
            currentMaxElement = maxElement;
            Random random = new();

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    matrixArray[i, j] = random.Next(maxElement + 1);
                }
            }
        }

        public void PrintMatrix()
        {
            int partitionLength = currentMaxElement.ToString().Length + 3;

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write(matrixArray[i, j].ToString().PadRight(partitionLength));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private int[] CalculateSumsOfRows()
        {
            int[] sumsOfRows = new int[_rows];

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    sumsOfRows[i] += matrixArray[i, j];
                }
            }

            return sumsOfRows;
        }

        private int[] FindMaxRowsElements()
        {
            int[] maxRowsElements = new int[_rows];

            for (int i = 0; i < _rows; i++)
            {
                maxRowsElements[i] = int.MinValue;

                for (int j = 0; j < _columns; j++)
                {
                    if (matrixArray[i,j] > maxRowsElements[i])
                    {
                        maxRowsElements[i] = matrixArray[i, j];
                    }
                }
            }

            return maxRowsElements;
        }

        private int[] FindMinRowsElements()
        {
            int[] minRowsElements = new int[_rows];

            for (int i = 0; i < _rows; i++)
            {
                minRowsElements[i] = int.MaxValue;

                for (int j = 0; j < _columns; j++)
                {
                    if (matrixArray[i, j] < minRowsElements[i])
                    {
                        minRowsElements[i] = matrixArray[i, j];
                    }
                }
            }

            return minRowsElements;
        }

        private void SortAscending(int[] sortingArray)
        {
            for (int i = 1; i < _rows; i++)
            {
                for (int j = 0; j < _rows - i; j++)
                {
                    if (sortingArray[j] > sortingArray[j + 1])
                    {
                        SwapArrayElements(ref sortingArray, j, j + 1);
                        SwapMultidimentionalIntArrayRows(ref matrixArray, j, j + 1);
                    }
                }
            }
        }

        private void SortDescending(int[] sortingArray)
        {
            for (int i = 1; i < _rows; i++)
            {
                for (int j = 0; j < _rows - i; j++)
                {
                    if (sortingArray[j] < sortingArray[j + 1])
                    {
                        SwapArrayElements(ref sortingArray, j, j + 1);
                        SwapMultidimentionalIntArrayRows(ref matrixArray, j, j + 1);
                    }
                }
            }
        }

        public void SortAscendingByMaxRowElement()
        {
            int[] maxRowsElements = FindMaxRowsElements();
            SortAscending(maxRowsElements);
            Console.WriteLine("Sorted ascending by max row elements:");
            PrintMatrix();
        }

        public void SortAscendingByMinRowElement()
        {
            int[] minRowsElements = FindMinRowsElements();
            SortAscending(minRowsElements);
            Console.WriteLine("Sorted ascending by min row elements:");
            PrintMatrix();
        }

        public void SortAscendingByRowSums()
        {
            int[] sumsOfRows = CalculateSumsOfRows();
            SortAscending(sumsOfRows);
            Console.WriteLine("Sorted ascending by row sums:");
            PrintMatrix();
        }

        public void SortDescendingByMaxRowElement()
        {
            int[] maxRowsElements = FindMaxRowsElements();
            SortDescending(maxRowsElements);
            Console.WriteLine("Sorted descending by max row elements:");
            PrintMatrix();
        }
        public void SortDescendingByMinRowElement()
        {
            int[] minRowsElements = FindMinRowsElements();
            SortDescending(minRowsElements);
            Console.WriteLine("Sorted descending by min row elements:");
            PrintMatrix();
        }

        public void SortDescendingByRowSums()
        {
            int[] sumsOfRows = CalculateSumsOfRows();
            SortDescending(sumsOfRows);
            Console.WriteLine("Sorted descending by row sums:");
            PrintMatrix();
        }
    }
}
