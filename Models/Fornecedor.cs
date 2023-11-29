using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("FornecedorId")]
        public int Id { get; set; }

        [Column("FornecedroNome")]
        [Display(Name ="Nome:")]
        public string FornecedroNome { get; set; } = string.Empty;

        [Column("FornecedroEmail")]
        [Display(Name = "Email:")]
        public string FornecedroEmail { get; set; } = string.Empty;

        [Column("FornecedroCnpj")]
        [Display(Name = "CNPJ:")]
        public string FornecedroCnpj { get; set; } = string.Empty;


    }
}
