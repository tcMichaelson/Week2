using AuctionSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionSite.Controllers
{
    public class AuctionItemsController : Controller
    {
        
        private Repository _repo = new Repository();

        public ActionResult BidOnItem(int id) {
            
            return RedirectToAction("Create", "Bids", new { auctionId = id });
        }

        // GET: AuctionItems
        public ActionResult Index()
        {
            return View(_repo.GetAllItems());
        }

        // GET: AuctionItems/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuctionItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuctionItems/Create
        [HttpPost]
        public ActionResult Create(AuctionItem collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid) {
                    _repo.SaveAuctionItem(collection);
                    return RedirectToAction("Index");
                } else {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: AuctionItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuctionItems/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuctionItems/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuctionItems/Delete/5
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
