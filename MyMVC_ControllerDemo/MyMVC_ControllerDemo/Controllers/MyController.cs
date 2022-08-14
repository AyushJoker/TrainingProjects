using Microsoft.AspNetCore.Mvc;

namespace MyMVC_ControllerDemo.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }
        public ActionResult MyExample()
        {
            ViewData["name"] = "Joker";
            ViewData["role"] = "Under Construction";
            return View();
        }
        

    }
}
