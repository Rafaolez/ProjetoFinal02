using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        public int Id { get; set; }

        [Column("ProdutoNome")]
        [Display(Name ="Nome do Produto:")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("QuantidadeEstoque")]
        [Display(Name ="Quantidade que tem no Estoque:")]
        public int QuantidadeEstoque { get; set; }

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "TipoProduto")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
