namespace projetoMVC.Aplicacao.Models
{
    public class ClienteView
    {
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public LojaView lojaView { get; set; }

        public ProdutoView produtoView { get; set; }

        public PagamentoView pagamentoView { get; set; }
    }
}
