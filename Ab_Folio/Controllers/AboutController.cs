using Microsoft.AspNetCore.Mvc;

namespace Ab_Folio.Controllers
{
    public class AboutController : Controller
    {
        /// <summary>
        /// redirects to the About View
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            return View();
        }
    }
}
