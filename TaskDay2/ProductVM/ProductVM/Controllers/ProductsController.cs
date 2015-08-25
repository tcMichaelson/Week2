using ProductVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductVM.Controllers
{
    public class ProductsController : Controller
    {
        private Repository _repo = new Repository();
        // GET: Products
        public ActionResult Index()
        {
            ProductIndexViewModel vm = new ProductIndexViewModel();

            vm.Products = _repo.ListProducts();
            return View(vm);
        }
    }
}