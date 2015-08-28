using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStoreWithCustomLayout.Controllers
{
    public class BannerController : Controller
    {
        [ChildActionOnly]
        public ActionResult GetAd() {
            var adText = "Drink a Vanilla Latte!";
            if (new Random().NextDouble() < .5) {
                adText = "Drink a cup of Assam Tea!";
            }
            return PartialView("_BannerAd", adText);
        }
    }
}