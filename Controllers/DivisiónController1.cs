using Microsoft.AspNetCore.Mvc;

namespace J.M.K20260224.Controllers
{
    public class DivisiónController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double numero1, double numero2)
        {
            if (numero2 != 0)
            {
                double resultado = numero1 / numero2;
                ViewBag.Resultados = resultado;
            }
            else
            {
                ViewBag.Error = "No se puede dividir entre cero.";
            }

            return View();
        }
    }
}
