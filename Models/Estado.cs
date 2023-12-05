﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Código do Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name ="Estado")]
        public string EstadoNome { get; set; } = string.Empty;

        [ForeignKey("PaisId")]
        [Display(Name = "Pais")]
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }
    }
}
