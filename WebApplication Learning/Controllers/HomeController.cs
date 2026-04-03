using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_Learning.Models;

namespace WebApplication_Learning.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string show_)
        {
            if (show_ == "show")
            {
                ViewBag.ShowLogin = true;
            }

            else
            {
                ViewBag.ShowLogin = false;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
