using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlee.Models;

namespace Vidlee.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var cust = new Customer() { Name = "Cust3" };
            return View(cust);
        }
        public ActionResult Overview()
        {
            var customers = new List<Customer>
            {
                new Customer {Id=1,Name = "Customer 1"},
                new Customer {Id=2,Name = "Customer 2"}
            };
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var detail = new Customer() { Id = id };
            return View(detail);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
   
}