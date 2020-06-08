using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workingwithmodels.Models;


namespace Workingwithmodels.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {

            // MockDate

            MockData myData = new MockData();

            string name = myData.GetName();

            int numTimes = myData.GetnumTimes();

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();


        }
    }
}