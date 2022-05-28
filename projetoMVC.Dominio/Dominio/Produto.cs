using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoMVC.Dominio.Dominio
{
    [Table("tb_Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }

        public string NomeProd { get; set; }

        public int Id_Cliente { get; set; }

        [ForeignKey("Id_Cliente")]
        public Cliente Cliente { get; set; }
    }
}
