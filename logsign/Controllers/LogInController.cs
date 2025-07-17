using logsign.Models;
using Microsoft.AspNetCore.Mvc;

namespace logsign.Controllers
{
    public class LogInController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LogIn obj1)
        {
            if(obj1.Email == "sachal.com" && obj1.Password1 == "123")
            {
                ViewBag.res = "Welcome to our website!";
            }
            else if(obj1.Email != "sachal.com")
            {
                ViewBag.res = "Wrong Email Id";
            }
            else if (obj1.Password1 != "123")
            {
                ViewBag.res = "Wrong Password";
            }
                return View();
        }
    }
}
