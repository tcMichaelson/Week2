using CalculatorIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorIT.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index(AddViewModel incoming)
        {
            incoming.Sum = incoming.Num1 + incoming.Num2;
            return View(incoming);
        }
    }
}