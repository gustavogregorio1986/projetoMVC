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

        public void Cadastrar(ClienteView clienteVM, LojaView lojaVM, ProdutoView produtoVM, PagamentoView pagamentoVM)
        {
            try
            {
                clienteVM = new ClienteView();
                Cliente cliente = new Cliente();
                clienteVM.IdCliente = cliente.IdCliente;
                clienteVM.NomeCliente = cliente.NomeCliente;
                clienteVM.EmailCliente = cliente.EmailCliente; 

                lojaVM = new LojaView();
                Loja loja = new Loja();
                lojaVM.IdLoja = loja.IdLoja;
                lojaVM.NomeLoja = loja.NomeLoja;
                

                produtoVM = new ProdutoView();
                Produto produto = new Produto();
                produtoVM.IdProduto = produto.IdProduto;
                produtoVM.NomeProd = produto.NomeProd;

                pagamentoVM = new PagamentoView();
                Pagamento pagamento = new Pagamento();
                pagamentoVM.IdPagamento = pagamento.IdPagamento;
                pagamentoVM.Preco = pagamento.Preco;
                pagamentoVM.Quantidade = pagamento.Quantidade;

                servicoCliene.AdiconarCliente(cliente);
                lojaServico.AdiconarLoja(loja);
                produtoServico.AdiconarPRoduto(produto);
                pagamentoServico.AdiconarPagamento(pagamento);
            }
            catch
            {
                throw;
            }
        }

        public IActionResult Cadastrar()
        {
            return View();
        }



        public List<Loja> ListarLojas()
        {
            var lista = new List<Loja>();

            foreach(var loja in lista)
            {
                lista.Add(loja);
            }

            return lista;
        }
    }
}
