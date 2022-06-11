using Microsoft.AspNetCore.Mvc;
using projetoMVC.Aplicacao.Models;
using projetoMVC.Dominio.Dominio;
using projetoMVC.Servico.Servico;
using System.Collections.Generic;

namespace projetoMVC.Aplicacao.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        
    }
}
