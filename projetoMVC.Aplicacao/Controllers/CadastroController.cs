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

        public IActionResult Cadastrar(Cliente cliente)
        {
            ClienteView clienteView = new ClienteView();
            cliente = new Cliente();
            clienteView.IdCliente = cliente.IdCliente;
            clienteView.NomeCliente = cliente.NomeCliente;
            clienteView.EmailCliente = cliente.EmailCliente;
            clienteView.Telefone = cliente.Telefone;
            clienteView.Cpf = cliente.Cpf;
            LojaView  lojaView = new LojaView();
            Loja loja = new Loja();
            lojaView.NomeLoja = loja.NomeLoja;
            ProdutoView produtoView = new ProdutoView();
            Produto produto = new Produto();
            produtoView.NomeProd = produto.NomeProd;
            PagamentoView pagamentoView = new PagamentoView();
            Pagamento pagamento = new Pagamento();
            pagamentoView.Preco = pagamento.Preco;
            pagamentoView.Quantidade = pagamento.Quantidade;
            cliente.Id_Loja = loja.IdLoja;
            produto.Id_Cliente = cliente.IdCliente;
            pagamento.Id_Produto = produto.IdProduto;

            ClienteServico clienteServico = new ClienteServico();
            LojaServico lojaServico = new LojaServico();
            ProdutoServico produtoServico = new ProdutoServico();
            PagamentoServico pagamentoServico = new PagamentoServico();

            List<Loja> lojas = new List<Loja>();

            foreach (var loj in lojaServico.ListarLojas())
            {
                lojas.Add(loj);
            }

            clienteServico.AdiconarCliente(cliente);
            lojaServico.AdiconarLoja(loja);
            produtoServico.AdiconarPRoduto(produto);
            pagamentoServico.AdiconarPagamento(pagamento);

            return View();
        }
    }
}
