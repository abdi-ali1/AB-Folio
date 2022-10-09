using Crypto_Webscrapper.Models;
using Crypto_Webscrapper.Objecten;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crypto_Webscrapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Goes to the index page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
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