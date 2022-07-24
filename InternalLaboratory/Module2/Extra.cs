using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    internal class Extra
    {

    }

    public class Bookshop
    {
        IBookCatalogue _bookCatalogue;

        public Bookshop(IBookCatalogue bookCatalogue)
        {
            _bookCatalogue = bookCatalogue;
        }
        public string Name { get; set; }

        public IEnumerable<Book> GetBookCatalogue()
        {
            return _bookCatalogue.GetAllBooks();
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public interface IBookCatalogue
    {
        IEnumerable<Book> GetAllBooks();
    }
}
