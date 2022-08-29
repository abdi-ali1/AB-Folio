using Microsoft.AspNetCore.Mvc;

namespace Ab_Folio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Projects()
        {
            return View();
        }
    }
}
