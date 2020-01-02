using Metas2020.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Metas2020.Data.Context
{
    public class MetaContext : DbContext
    {
        public MetaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Meta> Metas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Estrategia> Estrategias { get; set; }
    }
}
