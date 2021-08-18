using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignment1.Controllers
{
    public class InfoController : Controller
    {

        public IActionResult Home()
        {
            ViewBag.Title = "Home of Eric R Info Page";
            return View();
        }
        
        public IActionResult About()
        {
            ViewBag.Title = "About Eric R";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Eric R Contact info";
            return View();
        }

        public IActionResult Projects()
        {
            ViewBag.Title = "Eric R Projects";
            return View();
        }
    }
}
