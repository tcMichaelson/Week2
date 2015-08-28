using PhoneMVCUsingEditorTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneMVCUsingEditorTemplates.Controllers
{
    public class CustomersController : Controller
    {
        Repository _repo = new Repository();
        // GET: Customers
        public ActionResult Index()
        {
            return View(_repo.GetCustomers());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetCustomers()[id]);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(Customer collection)
        {
            try
            { 
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetCustomers()[0]);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
