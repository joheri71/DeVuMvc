using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMvc.Models;

namespace HelloMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.BobCreatedThisValue = "Hello Mvc";
            ViewBag.BobCreatedThisValue += "Hello Mvc";
            ViewBag.BobCreatedThisValue += "Johan är bäst";
            var cars = HelloModel.GetCars();

            return View(cars);
        }
    }
}