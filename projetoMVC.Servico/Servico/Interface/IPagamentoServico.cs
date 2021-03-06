using projetoMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMVC.Servico.Servico.Interface
{
    public interface IPagamentoServico
    {
        void AdiconarPagamento(Pagamento pagamento);

        List<Pagamento> ListarPagamentos();

        void AtualizarPagamento(Pagamento pagamento);

        void DeletarPagamento(int id);

        Pagamento BuscarPagamento(int Id);
    }
}
