using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MovieMVC.Models;


namespace MovieMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            Movies movies = new Movies();

            name = movies.GetMockDataName();
            numTimes = movies.GetMockDataNumTimes();

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}