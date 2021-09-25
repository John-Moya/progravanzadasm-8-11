using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinica.Controllers
{
    public class ServicesController : Controller
    {
        // GET: ServicesController
        public ActionResult Services()
        {
            return View();
        }

    }
}
