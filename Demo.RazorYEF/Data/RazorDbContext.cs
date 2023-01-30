using Demo.RazorYEF.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Demo.RazorYEF.Data
{
    public class RazorDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public RazorDbContext(DbContextOptions<RazorDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
