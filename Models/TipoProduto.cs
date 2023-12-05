using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Tipo do Produto Descrição")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;

    }
}
