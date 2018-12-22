using AspRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspRentals.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();           
            return View(customers);
        }

        public ActionResult Detail (int Id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);

            if (customer == null) {
                return HttpNotFound();
            }
            
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}