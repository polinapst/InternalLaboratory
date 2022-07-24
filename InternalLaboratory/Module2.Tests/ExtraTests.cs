using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Module2.Tests
{
    internal class ExtraTests
    {
        [Test]
        public void ShouldReturnAListofBooks()
        {
            //Arrange
            var mock = new Mock<IBookCatalogue>();
            mock.Setup(_bookCatalogue => _bookCatalogue.GetAllBooks()).Returns(GetTestBooks());
            var bookShop = new Bookshop(mock.Object);

            //Act
            IEnumerable<Book> result = bookShop.GetBookCatalogue();

            //Assert
            Assert.AreEqual(result.Count(), GetTestBooks().Count);
        }

        private List<Book> GetTestBooks()
        {
            var books = new List<Book>
            {
                new Book { Author = "JRR Tolkien", Title = "Lord od the Rings"},
                new Book { Author = "Joseph Albahari", Title = "C# 6.0 in a Nutshell"}
            };

            return books;
        }
    }
}
