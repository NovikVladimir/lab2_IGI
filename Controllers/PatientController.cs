using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return Content("<html></html>");
        }
    }
}