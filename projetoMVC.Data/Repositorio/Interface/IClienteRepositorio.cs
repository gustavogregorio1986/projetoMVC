using projetoMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMVC.Data.Repositorio.Interface
{
    public interface IClienteRepositorio
    {
        void AdiconarCliente(Cliente cliente);

        List<Cliente> ListarCLiente();

        void AtualizarCliente(Cliente cliente);

        void DeletarCliente(int id);

        Cliente BuscarCliente(int Id);
    }
}
