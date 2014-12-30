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
                url: "books/create",
                defaults: new { controller = "Book", action = "Create" }
            );

            // /books/update
            routes.MapRoute(
                name: "Update a Book",
                url: "books/update/{id}",
                defaults: new { controller = "Book", action = "Update" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
