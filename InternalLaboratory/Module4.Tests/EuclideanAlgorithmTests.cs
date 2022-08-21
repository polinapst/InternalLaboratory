using NUnit.Framework;

namespace Module4.Tests
{
    [TestFixture]
    public class EuclideanAlgorithmTests
    {
        [Test]
        public void ShouldThrowArgumentNullException_CalculateGCD() =>
            Assert.Throws<ArgumentNullException>(() => EuclideanAlgorithm.CalculateGCD(input: Array.Empty<int>()));

        [TestCase(true, 5, 15, 25, ExpectedResult = 5)]
        [TestCase(true, 0, ExpectedResult = 0)]
        [TestCase(false, 0, 0, 0, 0, 0, ExpectedResult = 0)]
        [TestCase(true, 1, 99, 16, ExpectedResult = 1)]
        [TestCase(false, 100, 40, ExpectedResult = 20)]
        [TestCase(false, 555, 555, ExpectedResult = 555)]
        [TestCase(true, -5, 10, ExpectedResult = 5)]
        [TestCase(false, -100, -40, ExpectedResult = 20)]
        [TestCase(false, -6, ExpectedResult = 6)]
        public int ShouldCalculateGCDForSeveralNumbers(bool isEuclidean, params int[] inputNumbers) =>
            EuclideanAlgorithm.CalculateGCD(isEuclidean, input: inputNumbers);

        [Test]
        public void ShouldReturnExecitionTime_CalculateGCD()
        {
            //Arrange
            string timeElapsed;
            int[] inputNumbers = { 5, 6, 7};

            //Act
            EuclideanAlgorithm.CalculateGCD(out timeElapsed, true, inputNumbers);

            //Assert
            Assert.IsNotEmpty(timeElapsed);
        }
    }
}