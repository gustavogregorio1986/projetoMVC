using projetoMVC.Data.Contexto;
using projetoMVC.Data.Repositorio.Interface;
using projetoMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMVC.Data.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ProjetoMVCContexto _db;

        public void AdiconarPRoduto(Produto produto)
        {
            _db.Add(produto);
        }

        public void AtualizarPproduto(Produto produto)
        {
            _db.Update(produto);
        }

        public Produto BuscarProduto(int Id)
        {
            return _db.Set<Produto>().Find(Id);
        }

        public void DeletarProduto(int id)
        {
            _db.Remove(id);
        }

        public List<Produto> ListarProdutos()
        {
            return _db.Produtos.ToList();
        }
    }
}
