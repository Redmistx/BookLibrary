using BookLibrary.Data;
using BookLibrary.Data.Common.Repository;
using BookLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IDeletableEntityRepository<Book> books;

        public BookController(IDeletableEntityRepository<Book> books)
        {
            this.books = books;
        }
        //
        // GET: /Book/
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string something)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

	}
}