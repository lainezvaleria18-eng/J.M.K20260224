using Microsoft.AspNetCore.Mvc;
using J.M.K20260224.Models;

namespace J.M.K20260224.Controllers
{
    public class DivisionController : Controller
    {
        public IActionResult Index()
        {
            return View(new Operacion());
        }

        [HttpPost]
        public IActionResult Calcular(Operacion op)
        {
            if (op.Numero2 == 0)
            {
                op.Resultado = 0;
                ViewBag.Error = "No se puede dividir entre cero";
            }
            else
            {
                op.Resultado = op.Numero1 / op.Numero2;
            }

            return View("Index", op);
        }
    }
}