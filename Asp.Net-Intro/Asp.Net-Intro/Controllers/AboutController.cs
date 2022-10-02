using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Intro.Controllers
{
    public class AboutController : Controller
    {
        public string Index()
        {
            return "About Page";
        }
    }
}
