using createPartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace createPartialView.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            Ogrenci student = new Ogrenci();
            student.Name = "Gokhan";
            student.SurName = "Gulsen";
            student.Age = 28;

            return View(student);
        }
        [HttpGet]
        public IActionResult YeniOgrenci()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniOgrenci(Ogrenci student)
        {
            Ogrenci alinanOgrenci = new Ogrenci();
            alinanOgrenci.Name = student.Name;
            alinanOgrenci.SurName = student.SurName;
            alinanOgrenci.Age = student.Age;

            return View(alinanOgrenci);
        }
    }
}
