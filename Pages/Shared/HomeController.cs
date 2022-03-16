using Microsoft.AspNetCore.Mvc;

namespace Web_App_Google_Wall_Calendar.Pages.Shared
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Weather()
        {
            return View();
        }
    }
}
