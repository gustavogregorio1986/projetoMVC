using projetoMVC.Data.Repositorio.Interface;
using projetoMVC.Dominio.Dominio;
using projetoMVC.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMVC.Servico.Servico
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _repositorio;

        public ProdutoServico()
        {

        }

        public ProdutoServico(IProdutoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdiconarPRoduto(Produto produto)
        {
            _repositorio.AdiconarPRoduto(produto);
        }

        public void AtualizarPproduto(Produto produto)
        {
            _repositorio.AtualizarPproduto(produto);
        }

        public Produto BuscarProduto(int Id)
        {
            return _repositorio.BuscarProduto(Id);
        }

        public void DeletarProduto(int id)
        {
            _repositorio.DeletarProduto(id);
        }

        public List<Produto> ListarProdutos()
        {
            return _repositorio.ListarProdutos();
        }
    }
}
