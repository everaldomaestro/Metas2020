using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metas2020.Domain.Entity
{
    [Table("Meta")]
    public class Meta
    {
        private Meta() { }

        public Meta(DateTime dataInicio, int usuarioId, string descricao, int areaId, bool usaRecursoFinanceiro, Status status, string motivacao)
        {
            DataInicio = dataInicio;
            UsuarioId = usuarioId;
            Descricao = descricao;
            AreaId = areaId;
            UsaRecursoFinanceiro = usaRecursoFinanceiro;
            Status = status;
            Motivacao = motivacao;
        }

        [Key]
        [Required]
        [Column("metaId")]
        public int MetaId { get; private set; }

        [Required]
        [Column("data_inicio")]
        public DateTime DataInicio { get; private set; }

        [Required]
        [Column("usuarioId")]
        public int UsuarioId { get; private set; }

        [Required]
        [Column("descricao")]
        public string Descricao { get; private set; }

        [Required]
        [Column("areaId")]
        public int AreaId { get; private set; }

        [Required]
        [Column("usa_recurso_financeiro")]
        public bool UsaRecursoFinanceiro { get; private set; }

        [Required]
        [Column("status")]
        public Status Status { get; private set; }

        [Required]
        [Column("motivacao")]
        public string Motivacao { get; private set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; private set; }

        [ForeignKey("AreaId")]
        public Area Area { get; private set; }

        public IEnumerable<Estrategia> Estrategias { get; private set; }
    }
}
