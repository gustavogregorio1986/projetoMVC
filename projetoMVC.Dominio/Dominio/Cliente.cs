using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Dominio.Dominio
{
    [Table("tb_Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public int Id_Loja { get; set; }

        [ForeignKey("Id_Loja")]
        public Loja Loja { get; set; }
    }
}
