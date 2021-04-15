using AndresMovieApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AndresMovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var area = new TextArea();
            return View(area);
        }

        [HttpPost]
        public IActionResult ChangeArea(TextArea textArea)
        {
            textArea.AreaTwo = textArea.AreaOne;

            return View("Index", textArea);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void Test()
        {
            //return new IActionResult<string>("test");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
