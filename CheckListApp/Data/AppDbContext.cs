using Microsoft.EntityFrameworkCore;
using CheckListApp.Models;

namespace CheckListApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ChecklistItem> ChecklistItens { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

