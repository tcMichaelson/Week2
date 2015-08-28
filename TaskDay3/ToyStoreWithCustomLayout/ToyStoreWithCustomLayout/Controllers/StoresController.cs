using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyStoreWithCustomLayout.Models;

namespace ToyStoreWithCustomLayout.Controllers
{
    public class StoresController : Controller
    {
        Repository _repo = new Repository();
        // GET: Stores
        public ActionResult Index()
        {
            var storeName = new Store();
            storeName.AllToys = _repo.GetToys();
            return View(storeName);
        }
    }
}