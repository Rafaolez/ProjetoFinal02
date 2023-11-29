using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("PaisId")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name ="Pais")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
