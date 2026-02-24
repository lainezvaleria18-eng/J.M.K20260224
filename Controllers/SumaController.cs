using J.M.K20260224.Models;
using Microsoft.AspNetCore.Mvc;

namespace J.M.K20260224.Controllers
{
    public class SumaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double numero1, double numero2)
        {
            double resultado = numero1 + numero2;
            ViewBag.Resultado = resultado;
            return View();
        }
    }
}
