using NUnit.Framework;
using System;

namespace Module3.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
        [TestCase(0.0081, 4, 0.01, ExpectedResult = 0.3)]
        public double ShouldFindNthRoot(double number, int degree, double precison) => NewtonsMethod.FindNthRoot(number, degree, precison);

        

        [Test]
        public void ShouldSortBySumAscending()
        {
            int[][] testInput = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 0 }, new int[] { 0, 0, 0 } };
            int[][] expectedOutput = { new int[] { 0, 0, 0 }, new int[] { 1, 2, 3 }, new int[] { 4, 5, 0 } };
            int[][] result;

            result = ArrayBubleSort.BubleSortArrayRowSumAscending(testInput);

            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ShouldBubleSortArrayRowSumDescending()
        {
            int[][] testInput = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 0 }, new int[] { 0, 0, 0 } };
            int[][] expectedOutput = { new int[] { 4, 5, 0 }, new int[] { 1, 2, 3 }, new int[] { 0, 0, 0 }  };
            int[][] result;

            result = ArrayBubleSort.BubleSortArrayRowSumDescending(testInput);

            Assert.AreEqual(expectedOutput, result);
        }


        [Test]
        public void ShouldBubleSortByMaxRowElementAscending()
        {
            int[][] testInput = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 0 }, new int[] { 0, 0, 0 } };
            int[][] expectedOutput = { new int[] { 0, 0, 0 }, new int[] { 1, 2, 3 }, new int[] { 4, 5, 0 } };
            int[][] result;

            result = ArrayBubleSort.BubleSortByMaxRowElementAscending(testInput);

            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ShouldBubleSortByMaxRowElementDescending()
        {
            int[][] testInput = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 0 }, new int[] { 0, 0, 0 } };
            int[][] expectedOutput = { new int[] { 4, 5, 0 }, new int[] { 1, 2, 3 }, new int[] { 0, 0, 0 } };
            int[][] result;

            result = ArrayBubleSort.BubleSortByMaxRowElementDescending(testInput);

            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ShouldBubleSortByMinRowElementAscending()
        {
            int[][] testInput = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 0, 0, 0 } };
            int[][] expectedOutput = { new int[] { 0, 0, 0 }, new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
            int[][] result;

            result = ArrayBubleSort.BubleSortByMinRowElementAscending(testInput);

            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ShouldBubleSortByMinRowElementDescending()
        {
            int[][] testInput = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 0 }, new int[] { 0, 0, 0 } };
            int[][] expectedOutput = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 0 }, new int[] { 0, 0, 0 } };
            int[][] result;

            result = ArrayBubleSort.BubleSortByMinRowElementDescending(testInput);

            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortArrayRowSumAscending()
        {
            int[][] inputArray = Array.Empty<int[]>();

            Assert.That(() => ArrayBubleSort.BubleSortArrayRowSumAscending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortArrayRowSumDescending()
        {
            int[][] inputArray = Array.Empty<int[]>();

            Assert.That(() => ArrayBubleSort.BubleSortArrayRowSumDescending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortByMaxRowElementAscending()
        {
            int[][] inputArray = Array.Empty<int[]>();

            Assert.That(() => ArrayBubleSort.BubleSortByMaxRowElementAscending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortByMaxRowElementDescending()
        {
            int[][] inputArray = Array.Empty<int[]>();

            Assert.That(() => ArrayBubleSort.BubleSortByMaxRowElementDescending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortByMinRowElementAscending()
        {
            int[][] inputArray = Array.Empty<int[]>();

            Assert.That(() => ArrayBubleSort.BubleSortByMinRowElementAscending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortByMinRowElementDescending()
        {
            int[][] inputArray = Array.Empty<int[]>();

            Assert.That(() => ArrayBubleSort.BubleSortByMinRowElementDescending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortArrayRowSumAscending_EmptyRows()
        {
            int[][] inputArray = new int[10][];

            Assert.That(() => ArrayBubleSort.BubleSortArrayRowSumAscending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortArrayRowSumDescending_EmptyRows()
        {
            int[][] inputArray = new int[10][];

            Assert.That(() => ArrayBubleSort.BubleSortArrayRowSumDescending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortByMaxRowElementAscending_EmptyRows()
        {
            int[][] inputArray = new int[10][];

            Assert.That(() => ArrayBubleSort.BubleSortByMaxRowElementAscending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortByMaxRowElementDescending_EmptyRows()
        {
            int[][] inputArray = new int[10][];

            Assert.That(() => ArrayBubleSort.BubleSortByMaxRowElementDescending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortByMinRowElementAscending_EmptyRows()
        {
            int[][] inputArray = new int[10][];

            Assert.That(() => ArrayBubleSort.BubleSortByMinRowElementAscending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ShouldThrowArgumentNullException_BubleSortByMinRowElementDescending_EmptyRows()
        {
            int[][] inputArray = new int[10][];

            Assert.That(() => ArrayBubleSort.BubleSortByMinRowElementDescending(inputArray), Throws.TypeOf<ArgumentNullException>());
        }
    }

    


}