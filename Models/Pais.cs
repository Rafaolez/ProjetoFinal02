using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Código do Pais")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name ="Pais")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
