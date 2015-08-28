using RandomQuoteWithPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandomQuoteWithPartialView.Controllers
{
    public class QuotesController : Controller
    {
        [ChildActionOnly]
        public ActionResult getQuote()
        {
            var myList = new List<Quote> {
                new Quote {
                    Words="The mind is not a vessel to be filled but a fire to be kindled.",
                    ContributedBy="Plutarch"
                },
                new Quote {
                    Words="Intelligence is the ability to adapt to change.",
                    ContributedBy="Steven Hawking"
                },
                new Quote {
                    Words="How old would you be if you didn't know how old you are?",
                    ContributedBy="Satchel Paige"
                },
                new Quote {
                    Words="Cinema is the most beautiful fraud in the world.",
                    ContributedBy="Jean-Luc Godard"
                },
                new Quote {
                    Words="Good artists copy, great artists steal.",
                    ContributedBy="Pablo Picasso"
                }
            };
            var randomNum = new Random().Next(5);
            var randomQuote = myList[randomNum];

            return PartialView("_RandomQuote", randomQuote);
        }
        public ActionResult Index() {
            return View();
        }
    }

    

}