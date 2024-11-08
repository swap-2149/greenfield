using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        IProductService productService = new ProductService();
        public ActionResult Index()
        {
            List<Product> _productsList = productService.GetAll();
            return View(_productsList);
        }

        public ActionResult Insert()
        {
            productService.Insert(new Product { Id = 1, Name = "Bag", Quantity = 1, Description = "Shopping bag", UnitPrice = 56, URL = "asdfasdfp.com"});
            return View();
        }

    }
}