using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void ShouldThrowArgumentException_MatrixConstructorZeroRows() =>
            Assert.Throws<ArgumentException>(() => new Matrix(0), "Matrix has to have a least one row");

        [Test]
        public void ShouldThrowArgumentException_MatrixConstructorNegativeRows() =>
            Assert.Throws<ArgumentException>(() => new Matrix(-5), "Matrix has to have a least one row");

        [Test]
        public void ShouldThrowArgumentException_MatrixConstructorZoreColumns() =>
            Assert.Throws<ArgumentException>(() => new Matrix(columns: 0), "Matrix has to have a least one column");

        [Test]
        public void ShouldThrowArgumentException_MatrixConstructorNegativeColumns() =>
            Assert.Throws<ArgumentException>(() => new Matrix(-99), "Matrix has to have a least one column");

        [Test]
        public void ShouldThrowArgumentException_MatrixConstructorNegativeMaxElement() =>
            Assert.Throws<ArgumentException>(() => new Matrix(maxElement: -13), "Max element has to be positive");
    }
}
