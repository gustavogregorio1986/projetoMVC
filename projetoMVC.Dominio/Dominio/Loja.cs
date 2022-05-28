using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Dominio.Dominio
{
    [Table("tb_Loja")]
    public class Loja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLoja { get; set; }

        public string NomeLoja { get; set; }
    }
}
