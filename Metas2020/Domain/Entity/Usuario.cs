using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metas2020.Domain.Entity
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Required]
        [Column("usuarioId")]
        public int UsuarioId { get; private set; }

        [Required]
        [Column("nome")]
        public string Nome { get; private set; }

        public IEnumerable<Meta> Metas { get; private set; }
    }
}