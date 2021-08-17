using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignment1.Controllers
{
    public class InfoController : Controller
    {
        //private readonly IAboutRepo _aboutRepo;

        public IActionResult Home()
        {
            ViewBag.Message = "Home of Eric R Info Page";
            return View();
        }
        
        public IActionResult About()
        {
            ViewBag.Message = "About Eric R";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Eric R Contact info";
            return View();
        }

        public IActionResult Projects()
        {
            ViewBag.Message = "Eric R Projects";
            return View();
        }
    }
}
