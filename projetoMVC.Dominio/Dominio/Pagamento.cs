using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Dominio.Dominio
{
    [Table("tb_Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagamento { get; set; }

        public float Preco { get; set; }

        public int Quantidade { get; set; }

        public int Id_Produto { get; set; }

        [ForeignKey("Id_Produto")]
        public Produto Produto { get; set; }
    }
}
