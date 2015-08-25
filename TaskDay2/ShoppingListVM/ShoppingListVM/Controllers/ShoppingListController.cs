using ShoppingListVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingListVM.Controllers
{
    public class ShoppingListController : Controller
    {
        Repository _repo = new Repository();
        // GET: Customers
        public ActionResult Index() {
            ShoppingCartIndexViewModel vm = new ShoppingCartIndexViewModel();
            vm.CustomerInfo = _repo.GetCustomer();
            vm.ProductList = _repo.GetItems();
            return View(vm);
        }

        public ActionResult ShowAllCarts() {
            ShoppingCartAllCustomersViewModel vm = new ShoppingCartAllCustomersViewModel();
            vm.AllCustomers= _repo.GetAllCustomers();
            vm.AllProdcuts = _repo.GetItems();
            return View(vm);
        }
    }
}