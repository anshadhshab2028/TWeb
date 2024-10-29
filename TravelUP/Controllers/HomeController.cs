using App.DLL.Model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelUP.Models;

namespace TravelUP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Main()
        {
            try
            {
                if (HttpContext.Session != null && HttpContext.Session.GetString("UserID") != null)
                {
                    return PartialView();
                }
                return RedirectToAction("Home");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Signout");
            }

        }

        public ActionResult Signout()
        {
            LoginDetails _LoginDetails_RS = new LoginDetails();
            try
            {
                HttpContext.Session.Clear();

                return RedirectToAction("Login", "Login");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Login");
            }
        }
    }
}
