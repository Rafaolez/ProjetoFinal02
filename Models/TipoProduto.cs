using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("TipoProdutoId")]
        public int Id { get; set; }

        [Column("TipoProdutoNome")]
        [Display(Name = "Tipo do Produto")]
        public string TipoProdutoNome { get; set; } = string.Empty;

    }
}
