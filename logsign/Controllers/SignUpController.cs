using logsign.Models;
using Microsoft.AspNetCore.Mvc;

namespace logsign.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignData obj)
        {
            ViewBag.result = "Welcome " + obj.Name + "! Go to Log In page.";
            return View();
        }
    }
}
