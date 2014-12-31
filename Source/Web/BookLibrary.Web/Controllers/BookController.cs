using BookLibrary.Data;
using BookLibrary.Data.Common.Repository;
using BookLibrary.Data.Models;
using BookLibrary.Web.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using BookLibrary.Web.ViewModels.Home;

namespace BookLibrary.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IDeletableEntityRepository<Book> books;

        public BookController(IDeletableEntityRepository<Book> books)
        {
            this.books = books;
        }

        // GET: /Book/
        [HttpGet]
        public ActionResult Create()
        {
            var model = new BookInputModel();
            return View();
        }

        [HttpPost]
        public ActionResult Create(BookInputModel inputBook)
        {
            if (ModelState.IsValid)
            {
                var book = new Book
                {
                    Name = inputBook.Name,
                    Description = inputBook.Description,
                    IsAvailable = true,
                };

                this.books.Add(book);
                this.books.SaveChanges();
                return RedirectToRoute("Library");
            }

            return View(inputBook);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var bookz = this.books.All().Project().To<BookViewModel>();

            return View(bookz);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var book = this.books.GetById(id);

            var model = new BookInputModel();
            model.Name = book.Name;
            model.Description = book.Description;

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(int id, BookInputModel book)
        {
            if (ModelState.IsValid)
            {
                var bookToUpdate = this.books.GetById(id);
                bookToUpdate.Name = book.Name;
                bookToUpdate.Description = book.Description;
                this.books.SaveChanges();

                return this.RedirectToRoute("Update Books");
            }

            return View(book);
        }
    }
}