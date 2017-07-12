using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloMVC.Models;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cars = HelloModel.GetCars();
            ViewBag.DanielCreatedThis = "Daniel Created this";

            return View(cars);
        }
    }
}