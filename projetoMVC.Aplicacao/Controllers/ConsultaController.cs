using Microsoft.AspNetCore.Mvc;

namespace projetoMVC.Aplicacao.Controllers
{
    public class ConsultaController : Controller
    {
        public IActionResult Consultar()
        {
            return View();
        }
    }
}
