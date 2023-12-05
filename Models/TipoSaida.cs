using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name ="Tipo da Saida Descrição")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
