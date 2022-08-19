using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksDL _booksModule;

        public BooksController(IBooksDL booksModule)
        {
            _booksModule = booksModule;
        }

        public IActionResult Index()
        {
            List<BookInfo> bookInfos = _booksModule.List();
            return View(bookInfos);
        }

        public IActionResult Details(int id)
        {
            BookInfo bookInfo = _booksModule.GetById(id);

            if (bookInfo == null)
            {
                return NoContent();
            }

            return View(bookInfo);
        }
    }
}
