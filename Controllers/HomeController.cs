using EjemploMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploMVC.Controllers
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
            ViewBag.Mensaje = "casa";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Otro(string a, string b, string op)
        {
            double num1 = Convert.ToDouble(a);
            double num2 = Convert.ToDouble(b);
            if (op == "Suma")
            {
                ViewBag.Respuesta = "sumaron "+num1 +" mas "+ num2+"el resultado es "+(num1+num2) ;
            }
            return View();
        }

        
        public IActionResult Otro()
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