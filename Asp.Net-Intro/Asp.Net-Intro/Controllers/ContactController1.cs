using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Intro.Controllers
{
    public class ContactController1 : Controller
    {
        public string Index()
        {
            return "Contact Us Page";
        }
    }
}
