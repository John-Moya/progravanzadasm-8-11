using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinariaTrab.Controllers
{
    public class AcercaController : Controller
    {
        // GET: AcercaController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Acerca()
        {
            return View();
        }

        // GET: AcercaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcercaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcercaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AcercaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcercaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AcercaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcercaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
