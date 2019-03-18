using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab2.Models;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Disease()
        {
            return View("~/Views/Disease/Index.cshtml");
        }

        [HttpGet]
        public IActionResult Medicine()
        {
            return View("~/Views/Medicine/Index.cshtml");
        }

        [HttpGet]
        public IActionResult Treatment()
        {
            return View("~/Views/Treatment/Index.cshtml");
        }

        [HttpPost]
        public string Disease(string name, string symptoms,
            string effects) {
            return "Болезнь \"" + name + "\"" + " c симптомами \"" + symptoms +
                "\" и последствиями \"" + effects + "\" добавлена в базу";
        }

        [HttpPost]
        public string Medicine(string name, string facturer, int dosage)
        {
            return "Лекарство \"" + name + "\" от \"" + facturer + "\" добавлено в базу.\nДозировка: \"" + dosage + "\"";
        }

        [HttpPost]
        public string Treatment(string nameDisease, string nameMedicine, string duration)
        {
            return "Лечение болезни \"" + nameDisease + "\" с помощью лекарства \"" + nameMedicine + "\" добавлено в базу. \nДлительность лечения: \"" + duration + "\"";
        }

        [HttpPost]
        public string Patient(string name, string sex, string phone, string disease, DateTime date)
        {
            return "Пациент: " + name + ". Номер телефона: " + phone + ". Болезнь: " + disease + ". Дата поступления: " + date.Year + "." + date.Month + "." +
            +date.Day + ". Пол: " + sex;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
