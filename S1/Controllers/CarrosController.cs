using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Controllers
{
    public class CarrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {
            string[] items = new string[] { "Mazda", "Ferrari", "Nissan", "Toyota" };
            ViewBag.lista = items;
            return View();
        }
    }
}
