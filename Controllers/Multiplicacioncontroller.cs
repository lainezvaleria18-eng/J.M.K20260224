using Microsoft.AspNetCore.Mvc;
using J.M.K20260224.Models;

namespace J.M.K20260224.Controllers
{
    public class MultiplicacionController : Controller
    {
        public IActionResult Index()
        {
            return View(new Operacion());
        }

        [HttpPost]
        public IActionResult Calcular(Operacion op)
        {
            op.Resultado = op.Numero1 * op.Numero2;
            return View("Index", op);
        }
    }
}