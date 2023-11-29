using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name ="Nome:")]
        public string UsuarioName { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name ="Email:")]
        public string UsuarioId { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha")]
        public string UserName { get; set; } = string.Empty;
    }
}
