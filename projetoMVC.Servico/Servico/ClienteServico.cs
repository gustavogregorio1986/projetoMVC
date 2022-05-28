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
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteServico()
        {

        }

        public ClienteServico(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdiconarCliente(Cliente cliente)
        {
            _repositorio.AdiconarCliente(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _repositorio.AtualizarCliente(cliente);
        }

        public Cliente BuscarCliente(int Id)
        {
            return _repositorio.BuscarCliente(Id);
        }

        public void DeletarCliente(int id)
        {
            _repositorio.DeletarCliente(id);
        }

        public List<Cliente> ListarCLiente()
        {
            return _repositorio.ListarCLiente();
        }
    }
}
