using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Web.Controllers
{
    public class BookController : Controller
    {
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
	}
}