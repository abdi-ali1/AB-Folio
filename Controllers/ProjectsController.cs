using Microsoft.AspNetCore.Mvc;

namespace Crypto_Webscrapper.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Projects()
        {
            return View();
        }
    }
}
