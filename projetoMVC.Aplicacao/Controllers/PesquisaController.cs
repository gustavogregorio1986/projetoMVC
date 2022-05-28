using Microsoft.AspNetCore.Mvc;

namespace projetoMVC.Aplicacao.Controllers
{
    public class PesquisaController : Controller
    {
        public IActionResult Pesquisar()
        {
            return View();
        }
    }
}
