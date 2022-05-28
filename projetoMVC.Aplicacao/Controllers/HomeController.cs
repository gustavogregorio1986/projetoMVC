using Microsoft.AspNetCore.Mvc;

namespace projetoMVC.Aplicacao.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
