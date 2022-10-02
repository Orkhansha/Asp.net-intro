using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Intro.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(int id, string name)
        //{
        //    return "Hello P130" + "-" + id + "-" + name;
        //}

        public IActionResult Index(int id, string name)
        {
            //return Json(new { name= "Orkhan", surname = "Akbarov"});
            //return Content("Salamlar");
            return View();
        }

        public int Age()
        {
            return 28;
        }

        public string FullData(string name, string surname, int age)
        {
            return $"Name: {name} Surname: {surname} Age: {age}";
        }
    }
}
