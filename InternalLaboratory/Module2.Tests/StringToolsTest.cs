using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Tests
{
    [TestFixture]
    internal class StringToolsTest
    {
        [TestCase("", "test")]
        [TestCase("test2", "")]
        [TestCase("", "")]
        public void ShouldThrowArgumentNullException_ConcatNonrepeating(string inputStringA, string inputStringB) =>
            Assert.Throws<ArgumentNullException>(() => StringTools.ConcatNonrepeating(inputStringA, inputStringB));

        [TestCase("abc", "brt", ExpectedResult = "abcrt")]
        [TestCase("qwerty", "rtyuiofff", ExpectedResult = "qwertyuiof")]
        [TestCase("g", "g", ExpectedResult = "g")]
        public string ShouldConcatNonrepeating(string inputStringA, string inputStringB)
            => StringTools.ConcatNonrepeating(inputStringA, inputStringB);
            
    }
}
