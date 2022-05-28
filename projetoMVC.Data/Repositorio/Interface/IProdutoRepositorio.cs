using projetoMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMVC.Data.Repositorio.Interface
{
    public interface IProdutoRepositorio
    {
        void AdiconarPRoduto(Produto produto);

        List<Produto> ListarProdutos();

        void AtualizarPproduto(Produto produto);

        void DeletarProduto(int id);

        Produto BuscarProduto(int Id);
    }
}
