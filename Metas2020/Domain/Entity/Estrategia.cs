using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metas2020.Domain.Entity
{
    [Table("Estrategia")]
    public class Estrategia
    {
        [Key]
        [Required]
        [Column("estrategiaId")]
        public int EstrategiaId { get; private set; }

        [Required]
        [Column("metaId")]
        public int MetaId { get; private set; }

        [Required]
        [Column("descricao")]
        public string Descricao { get; private set; }

        [Required]
        [Column("data_inicio")]
        public DateTime DataInicio { get; private set; }

        [Required]
        [Column("status")]
        public Status Status { get; private set; }

        [ForeignKey("MetaId")]
        public Meta Meta { get; private set; }
    }
}
