using Microsoft.AspNetCore.Mvc;

namespace Ab_Folio.Controllers
{
    public class ProjectsController : Controller
    {
        /// <summary>
        /// redirects to the  Projects View
        /// </summary>
        /// <returns></returns>
        public IActionResult Projects()
        {
            return View();
        }
    }
}
