using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Controllers
{
    public class CasasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {
            string[] items = new string[] { "Casa roja grande", "Casa verde pequeña", "Casa azul mediana"};
            ViewBag.lista = items;
            return View();
        }
    }
}
