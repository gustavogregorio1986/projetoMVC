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
    internal class PagamentoRepositorio : IPagamentoRepositorio
    {
        private readonly ProjetoMVCContexto _db;

        public void AdiconarPagamento(Pagamento pagamento)
        {
            _db.Add(pagamento);
        }

        public void AtualizarPagamento(Pagamento pagamento)
        {
            _db.Update(pagamento);
        }

        public Pagamento BuscarPagamento(int Id)
        {
            return _db.Set<Pagamento>().Find(Id);
        }

        public void DeletarPagamento(int id)
        {
            _db.Remove(id);
        }

        public List<Pagamento> ListarPagamentos()
        {
            return _db.Pagamentos.ToList();
        }
    }
}
