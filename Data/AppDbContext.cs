s

using Microsoft.EntityFrameworkCore;
using API_REST.Models;

namespace API_REST.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
    }
}