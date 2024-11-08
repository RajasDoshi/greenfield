using Ecommerceweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerceweb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new  Customer { Id = 7 ,  FirstName  = "DD", LastName = "sasd" });
            customers.Add(new  Customer { Id = 9,    FirstName  = "daspjiip", LastName = "sajdiqwhsd" });
            customers.Add(new  Customer { Id = 10,    FirstName  = "ohdio", LastName = "sdohoqhohasd" });
            customers.Add(new Customer { Id = 11, FirstName = "dajsbufb", LastName = "saasdpj0pijsd" });
            return View(customers);
        }
    }
}