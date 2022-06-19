using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudSqlSever.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Display(Name ="Código")]
        public int Id { get; set; } 

        [Required]
        [MaxLength(100)]
        [Display(Name ="Nome")]
        public string Nome { get; set; }
    }
}
