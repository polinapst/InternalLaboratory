using NUnit.Framework;

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
        
    }

    


}