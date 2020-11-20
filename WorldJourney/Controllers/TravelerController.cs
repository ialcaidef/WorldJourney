using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldJourney.Controllers
{
    public class TravelerController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index(string name)
        {
            ViewBag.VisiterName = name;
            return View();
        }
    }
}
