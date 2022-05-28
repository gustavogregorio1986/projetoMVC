using projetoMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMVC.Servico.Servico.Interface
{
    public interface ILojaServico
    {
        void AdiconarLoja(Loja loja);

        List<Loja> ListarLojas();

        void AtualizarLoja(Loja loja);

        void DeletarLoja(int id);

        Loja BuscarLoja(int Id);
    }
}
