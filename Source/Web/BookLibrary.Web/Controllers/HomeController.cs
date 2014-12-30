using BookLibrary.Data.Common.Repository;
using BookLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Book> books;

        public HomeController(IDeletableEntityRepository<Book> books)
        {
            this.books = books;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}