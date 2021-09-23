using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Controllers
{
    public class PerrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lista()
        {
            string[] items = new string[] { "American Stafford", "Pitbull", "Boxer", "Cane Corso" };
            ViewBag.lista = items;
            return View();
        }
    }
}
