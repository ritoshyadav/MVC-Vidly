using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); // multi routes at once

            //*** single single routes
            //routes.MapRoute(
            //    "MovieReleaseDate",
            //    "movie/released/{year}/{month}",
            //    new { Controller = "movie", Action = "ByReleaseDate"},
            //    //new { year =@"\d{4}",month=@"\d{2}"}        // 4 digit in 4 year and digit 2 on date
            //   new { year=@"2015|2016",month=@"\d{2}"}
            //    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
