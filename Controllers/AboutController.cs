using Microsoft.AspNetCore.Mvc;

namespace Crypto_Webscrapper.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
