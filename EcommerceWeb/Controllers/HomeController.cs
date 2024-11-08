using CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.Controllers
{
    public class HomeController : Controller
    {
        ICustomerService customerService = new CustomerService();
        public ActionResult Index()
        {
            List<Customer> _customersList = new List<Customer>();
            _customersList.Add(new Customer { Id = 1, FirstName = "Swap", LastName = "Patil", Contact = "989898989", Email = "swap.patil@gmail.com" });
            _customersList.Add(new Customer { Id = 1, FirstName = "Swap", LastName = "Patil", Contact = "989898989", Email = "swap.patil@gmail.com" });
            return View(_customersList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}