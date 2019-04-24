using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}