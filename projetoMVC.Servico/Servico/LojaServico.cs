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
    public class LojaServico : ILojaServico
    {
        private readonly ILojaRepositorio _repositorio;

        public LojaServico()
        {

        }

        public LojaServico(ILojaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdiconarLoja(Loja loja)
        {
            throw new NotImplementedException();
        }

        public void AtualizarLoja(Loja loja)
        {
            _repositorio.AtualizarLoja(loja);
        }

        public Loja BuscarLoja(int Id)
        {
            return _repositorio.BuscarLoja(Id);
        }

        public void DeletarLoja(int id)
        {
            _repositorio.DeletarLoja(id);
        }

        public List<Loja> ListarLojas()
        {
            return _repositorio.ListarLojas();
        }
    }
}
