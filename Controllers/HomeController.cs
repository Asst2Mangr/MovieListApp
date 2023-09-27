using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MovieListApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}