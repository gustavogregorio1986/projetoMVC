using Microsoft.EntityFrameworkCore;
using projetoMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMVC.Data.Contexto
{
    public class ProjetoMVCContexto : DbContext
    {
        public ProjetoMVCContexto(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Loja> Lojas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
