using Microsoft.AspNetCore.Mvc;

namespace Ab_Folio.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
