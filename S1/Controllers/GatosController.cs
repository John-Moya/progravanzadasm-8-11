using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Controllers
{
    public class GatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {
            string[] items = new string[] { "Persa", "Bengala", "Siames", "Esfinge" };
            ViewBag.lista = items;
            return View();
        }
    }
}
