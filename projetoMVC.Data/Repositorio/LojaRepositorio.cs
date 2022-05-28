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
    public class LojaRepositorio : ILojaRepositorio
    {
        private readonly ProjetoMVCContexto _db;

        public void AdiconarLoja(Loja loja)
        {
            _db.Add(loja);
        }

        public void AtualizarLoja(Loja loja)
        {
            _db.Update(loja);
        }

        public Loja BuscarLoja(int Id)
        {
            return _db.Set<Loja>().Find(Id);
        }

        public void DeletarLoja(int id)
        {
            _db.Remove(id);
        }

        public List<Loja> ListarLojas()
        {
            return _db.Set<Loja>().ToList();
        }
    }
}
