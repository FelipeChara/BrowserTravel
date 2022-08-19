using Data.Access;
using Data.Models;
using NUnit.Framework;
using System.Collections.Generic;
using Data.BD;

namespace UnitTest
{
    [TestFixture]
    public class BooksDLTest
    {
        private readonly TravelContext _context;
        private readonly BooksDL _booksDL;

        public BooksDLTest()
        {
            _context = new TravelContext();
            _booksDL = new BooksDL(_context);
        }

        [Test]
        public void List_Ok()
        {
            List<BookInfo> books = _booksDL.List();
            Assert.IsTrue(books.Count > 0);
        }

        [Test]
        public void Get_Exist()
        {
            int id = 1;
            BookInfo book = _booksDL.GetById(id);
            Assert.IsNotNull(book);
            Assert.AreEqual(id, book.Id);
        }

        [Test]
        public void Get_Not_Exist()
        {
            int id = 100;
            BookInfo book = _booksDL.GetById(id);
            Assert.IsNull(book);
        }
    }
}