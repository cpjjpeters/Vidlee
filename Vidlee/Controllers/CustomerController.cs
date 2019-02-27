using System;
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
    }
}