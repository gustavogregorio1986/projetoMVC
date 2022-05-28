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
    public class ClienteRepositorio : IClienteRepositorio
    {

        private readonly ProjetoMVCContexto _db;


        public void AdiconarCliente(Cliente cliente)
        {
            _db.Add(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _db.Update(cliente);
        }

        public Cliente BuscarCliente(int Id)
        {
            return _db.Set<Cliente>().Find(Id);
        }

        public void DeletarCliente(int id)
        {
            _db.Remove(id);
        }

        public List<Cliente> ListarCLiente()
        {
            return _db.Set<Cliente>().ToList();
        }
    }
}
