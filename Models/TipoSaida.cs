using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("TipoSaidaId")]
        public int Id { get; set; }

        [Column("TipoSaidaNome")]
        [Display(Name ="Tipo da Saida")]
        public string TipoSaidaNome { get; set; } = string.Empty;
    }
}
