using Microsoft.EntityFrameworkCore;
using MVC_2024.Models;

namespace MVC_2024.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Cars> Car { get; set; }
    }
}
