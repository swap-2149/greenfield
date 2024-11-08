using CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService customerService = new CustomerService();
        public ActionResult Index()
        {
            ICustomerService customerService = new CustomerService();
            List<Customer> _customersList = customerService.GetAll();
            return View(_customersList);
        }
        public ActionResult AddCustomer()
        {
            return View();
        }

        public ActionResult UpdateCustomer()
        {
            return View();
        }
    }
}