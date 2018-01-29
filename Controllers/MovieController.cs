using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.viewmodel;


namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "apne"
            };
            //           return View(move);
            //           return Content("hello world MVC");
            //           return HttpNotFound();
            //           return new EmptyResult();
            //return RedirectToAction("index", "home", new { page = 1, sortby = "Name" });



            ////ViewData["Movie"] = movie;

            var customers = new List<Customer>
            {
                new Customer {Name="customer 1" },
                new Customer {Name="customer 2" }

            };
            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };
            return View(viewmodel);
        }
        public ActionResult edit(int id)
        {
            return Content("id" + id);
        }

        public ActionResult Index(int? pageindex, string sortby)
        {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "name";
            return Content(string.Format("pageindex={0}&sortby={1}", pageindex, sortby));
        }


        [Route("movie/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
  
}