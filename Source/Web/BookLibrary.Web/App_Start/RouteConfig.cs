using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookLibrary.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /books/create
            routes.MapRoute(
                name: "Create a Book",
                url: "Books/Create",
                defaults: new { controller = "Book", action = "Create" }
            );

            // /books/update
            routes.MapRoute(
                name: "Update Books",
                url: "Books/Update",
                defaults: new { controller = "Book", action = "Edit" }
            );

            routes.MapRoute(
                name: "Rent a Book",
                url: "Book/Rent/{id}",
                defaults: new { controller = "Home", action = "Rent" }
            );

            routes.MapRoute(
                name: "Library",
                url: "Home/Index",
                defaults: new { controller = "Home", action = "Index", }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
