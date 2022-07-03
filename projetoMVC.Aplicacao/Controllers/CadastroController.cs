using Microsoft.AspNetCore.Mvc;
using projetoMVC.Aplicacao.Models;
using projetoMVC.Dominio.Dominio;
using projetoMVC.Servico.Servico;
using projetoMVC.Servico.Servico.Interface;
using System.Collections.Generic;

namespace projetoMVC.Aplicacao.Controllers
{
    public class CadastroController : Controller
    {

        private IClienteServico servicoCliene;
        private ILojaServico lojaServico;
        private IProdutoServico produtoServico;
        private IPagamentoServico pagamentoServico;

        public IActionResult Cadastrar()
        {
            return View();
        }

       
    }
}
