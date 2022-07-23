using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Tests
{
    [TestFixture]
    public class ArrayToolsTest
    {
    
        [Test]    
        public void ShouldThrowArgumentNullException_FindMaxIntElement() =>
            Assert.Throws<ArgumentNullException>(() => ArrayTools.FindMaxIntElement(Array.Empty<int>()), "Input cannot be null or empty");

        [TestCase(new int[] { 5, 6, 0, 28, 3}, ExpectedResult = 28)]
        [TestCase(new int[] { 100, 15, 48, 3, 12, 1, 5, 4 }, ExpectedResult = 100)]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = 0)]
        public int ShouldFindMaxNumber_FindMaxIntElement(int[] inputArray) => ArrayTools.FindMaxIntElement(inputArray);

        [Test]
        public void ShouldThrowArgumentNullException_FindSymmetryCenter() =>
            Assert.Throws<ArgumentNullException>(() => ArrayTools.FindSymmetryCenter(Array.Empty<double>()), "Input cannot be null or empty");

        [TestCase(new double[] { 5.0, 6.2, 0.33, 8.2, 3 }, ExpectedResult = 2)]
        [TestCase(new double[] { 111, 6, 1, 10, 0, 0, 0, 100 }, ExpectedResult = 1)]
        [TestCase(new double[] { 0 }, ExpectedResult = 0)]
        [TestCase(new double[] { 0, 0.3, 6, 0.111, 2 }, ExpectedResult = -1)]
        public double ShouldFindSymmetryCenter_FindSymmetryCenter(double[] inputArray) => ArrayTools.FindSymmetryCenter(inputArray);

        [Test]
        public void ShouldThrowArgumentNullException_FilterDigit() =>
            Assert.Throws<ArgumentNullException>(() => ArrayTools.FilterDigit(Array.Empty<int>(), 0), "Input cannot be null or empty");
        
        [Test]
        public void ShouldThrowArgumentNullExceptionEmptyArray_FilterDigit()
        {
            int[] inputArray = Array.Empty<int>();
            int filterDigit = -1;

            Assert.That(() => ArrayTools.FilterDigit(inputArray, filterDigit), Throws.TypeOf<ArgumentNullException>());
        }

        [TestCase(new int[] { 1, 2, 3}, -1)]
        [TestCase(new int[] { 1, 2, 3 }, 10)]
        [TestCase(new int[] { 1, 2, 3 }, 13)]
        [TestCase(new int[] { 1, 2, 3 }, -100)]
        public void ShouldThrowArgumentException_FilterDigit(int[] inputArray, int filterDigit)
        {
            Assert.That(() => ArrayTools.FilterDigit(inputArray, filterDigit), Throws.TypeOf<ArgumentException>());
        }

        [TestCase(new int[] { 1, 2, 3, 2, 15, 28, 16, 2 }, 1, ExpectedResult = new int[] { 1, 15, 16 })]
        [TestCase(new int[] { 1, 2, 3, 2, 15, 28, 16, 2 }, 2, ExpectedResult = new int[] { 2, 2, 28, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2, 15, 28, 16, 2 }, 7, ExpectedResult = new int[] { })]
        public int[] ShouldFilterArray_FilterDigit(int[] inputArray, int filterDigit) => ArrayTools.FilterDigit(inputArray, filterDigit);
    }
}
