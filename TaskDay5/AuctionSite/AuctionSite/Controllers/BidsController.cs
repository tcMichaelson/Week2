﻿using AuctionSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionSite.Controllers
{
    public class BidsController : Controller
    {
        private Repository _repo = new Repository();

        // GET: Bids
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bids/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bids/Create
        public ActionResult Create(int AuctionId)
        {
            return View(_repo.CreateNewBid(AuctionId));
        }

        // POST: Bids/Create
        [HttpPost]
        public ActionResult Create(PlaceBidViewModel model)
        {
            try
            {
                if (model.Bid.Name == "") {
                    return View(model.Bid);
                } else { 
                    // TODO: Add insert logic here
                    if (ModelState.IsValid) {
                        _repo.AddBidToItem(model.Bid, _repo.GetAuctionItemById(model.AccountId));
                        return RedirectToAction("Index", "AuctionItems");
                    } else {
                        return View();
                    }
                }
            }
            catch
            {
                return View(model.Bid);
            }
        }

        // GET: Bids/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bids/Edit/5
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

        // GET: Bids/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bids/Delete/5
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
