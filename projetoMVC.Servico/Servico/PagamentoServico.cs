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
    public class PagamentoServico : IPagamentoServico
    {
        private readonly IPagamentoRepositorio _repositorio;

        public PagamentoServico()
        {

        }

        public PagamentoServico(IPagamentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdiconarPagamento(Pagamento pagamento)
        {
            _repositorio.AdiconarPagamento(pagamento);
        }

        public void AtualizarPagamento(Pagamento pagamento)
        {
            _repositorio.AtualizarPagamento(pagamento);
        }

        public Pagamento BuscarPagamento(int Id)
        {
            return _repositorio.BuscarPagamento(Id);
        }

        public void DeletarPagamento(int id)
        {
            _repositorio.DeletarPagamento(id);
        }

        public List<Pagamento> ListarPagamentos()
        {
            return _repositorio.ListarPagamentos();
        }
    }
}
