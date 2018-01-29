using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context.Customer.Include(c =>c.MembershipType).ToList();
            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}