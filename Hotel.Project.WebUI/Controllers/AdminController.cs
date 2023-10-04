using Microsoft.AspNetCore.Mvc;

namespace Hotel.Project.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();

        }
    }
}
