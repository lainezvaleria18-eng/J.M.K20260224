using Microsoft.AspNetCore.Mvc;

namespace J.M.K20260224.Controllers
{
    public class RestaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(double numero1, double numero2)
        {
            double resultado = numero1 - numero2;
            ViewBag.Resultado = resultado;
            return View("Index");

        }
    }
}