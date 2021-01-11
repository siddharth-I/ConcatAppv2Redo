using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StringConcatWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StringConcatWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(string name, int repetitions = userInput)
        {
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < userInput; i++)
            {
                sb.AppendLine(i.ToString());
            }
            System.Console.WriteLine(sb.ToString());
            ViewData["Message"] = name;
            ViewData["NumTimes"] = repetitions;

            return View();
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
