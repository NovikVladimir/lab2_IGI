using System;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class MedicineController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}