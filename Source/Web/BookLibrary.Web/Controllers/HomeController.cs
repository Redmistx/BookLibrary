using BookLibrary.Data;
using BookLibrary.Data.Common.Repository;
using BookLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.QueryableExtensions;
using System.Web.Mvc;
using BookLibrary.Web.ViewModels.Home;

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
            var bookz = this.books.All().Project().To<BookViewModel>();

            return View(bookz);
        }

        [HttpGet]
        public ActionResult Rent(int id)
        {
            if (ModelState.IsValid)
            {
                var bookToRent = books.GetById(id);
                if (bookToRent.IsAvailable)
                {
                    bookToRent.IsAvailable = false;
                    bookToRent.RentedBy = User.Identity.Name;
                    bookToRent.LastRenter = User.Identity.Name;
                    this.books.SaveChanges();

                    return this.RedirectToAction("Index");
                }
            }

            return Content("some error");
        }

        [HttpGet]
        public ActionResult Return(int id)
        {
            if (ModelState.IsValid)
            {
                
                var bookToReturn = books.GetById(id);
                
                if (!bookToReturn.IsAvailable)
                {
                    if (User.Identity.Name == bookToReturn.RentedBy)
                    {
                        bookToReturn.IsAvailable = true;
                        bookToReturn.RentedBy = null;
                        this.books.SaveChanges();

                        return this.RedirectToAction("Index");
                    }
                }
            }

            return Content("some error");
        }
    }
}