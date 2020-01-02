using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metas2020.Domain.Entity
{
    [Table("Area")]
    public class Area
    {
        [Key]
        [Required]
        [Column("areaId")]
        public int AreaId { get; private set; }

        [Required]
        [Column("descricao")]
        public string Descricao { get; private set; }

        public IEnumerable<Meta> Metas { get; private set; }
    }
}