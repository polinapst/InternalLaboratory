using NUnit.Framework;
using System;

namespace Module2.Tests
{
    [TestFixture]
    public class NumberToolsTest
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        [TestCase(8, ExpectedResult = -1)]
        [TestCase(5, ExpectedResult = -1)]
        public int ShouldFindNextBiggerNumber(int n) => NumberTools.FindNextBiggerNumber(n);

        [Test]
        public void ShouldThrowArgumentException_FindNextBiggerNumber() => 
            Assert.Throws<ArgumentException>(() => NumberTools.FindNextBiggerNumber(-1), "Input number has to be positive");

        [Test]
        public void ShouldReturnTimeOfExecution_FindNextBiggerNumber()
        {
            //Arrange
            string timeElapsed;
            int number = 14;

            //Act
            NumberTools.FindNextBiggerNumber(number, out timeElapsed);

            //Assert
            Assert.IsFalse(string.IsNullOrEmpty(timeElapsed));
        }

        [Test]
        public void ShouldReturnDifferentTimeOfExecution_FindNextBiggerNumber()
        {
            //Arrange
            string timeElapsed1;
            string timeElapsed2;
            int number1 = 14;
            int number2 = 5976;

            //Act
            NumberTools.FindNextBiggerNumber(number1, out timeElapsed1);
            NumberTools.FindNextBiggerNumber(number2, out timeElapsed2);

            //Assert
            Assert.AreNotEqual(timeElapsed1, timeElapsed2);
        }

        [Test]
        public void ShouldThrowArgumentException_InsertNumber() =>
            Assert.Throws<ArgumentException>(() => NumberTools.InsertNumber(15, 16, -1, 0), "Index cannot be less than zero");
        
    }
}